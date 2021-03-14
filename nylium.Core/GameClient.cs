﻿using System;
using System.Buffers.Binary;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using DaanV2.UUID;
using fNbt.Tags;
using nylium.Core.Block;
using nylium.Core.Entity;
using nylium.Core.Tags;
using nylium.Core.World;
using nylium.Extensions;
using nylium.Core.DataTypes;
using nylium.Core.Packet;
using nylium.Core.Packet.Client.Handshake;
using nylium.Core.Packet.Client.Login;
using nylium.Core.Packet.Client.Play;
using nylium.Core.Packet.Client.Status;
using nylium.Core.Packet.Server.Login;
using nylium.Core.Packet.Server.Play;
using nylium.Core.Packet.Server.Status;
using nylium.Utilities;

namespace nylium.Core {

    public class GameClient : IDisposable {

        public const int BUFFER_SIZE = 4096;
        public readonly byte[] buffer = new byte[BUFFER_SIZE];

        private readonly Random random = new();

        public Socket Socket { get; set; }
        public KeepAlive KeepAlive { get; set; }

        public ProtocolState ProtocolState { get; set; }

        public sbyte ViewDistance { get; set; }

        public GameEntity Player { get; set; }
        public GameWorld World { get; set; }

        /// <summary>
        /// If true, the client is ready to receive/send packets
        /// </summary>
        public bool Ready { get; set; }

        public GameClient(Socket socket) {
            Socket = socket;
            ProtocolState = ProtocolState.Handshaking;
            Ready = false;
        }

        public void HandlePacket(NetworkPacket packet) {
            switch(ProtocolState) {
                case ProtocolState.Handshaking:
                    switch(packet) {
                        case CH00Handshake: {
                                CH00Handshake handshake = (CH00Handshake) packet;
                                ProtocolState = handshake.NextState;
                                break;
                            }
                    }
                    break;
                case ProtocolState.Status:
                    switch(packet) {
                        case CS00Request: {
                                SS00Response response = new(GameServer.STATUS_STRING);
                                Send(response);
                                break;
                            }
                        case CS01Ping: {
                                CS01Ping ping = (CS01Ping) packet;

                                SS01Pong pong = new(ping.Payload);
                                Send(pong);

                                Dispose();
                                return;
                            }
                    }
                    break;
                case ProtocolState.Login:
                    switch(packet) {
                        case CL00LoginStart: {
                                CL00LoginStart loginStart = (CL00LoginStart) packet;

                                SL02LoginSuccess loginSuccess = new(
                                    UUIDFactory.CreateUUID(3, 1, "OfflinePlayer:" + loginStart.Username),
                                    loginStart.Username);
                                Send(loginSuccess);

                                ProtocolState = ProtocolState.Play;
                                World = GameServer.World;
                                Player = new(World, "minecraft:player", 0, 16, 0, 0, 0);

                                SP24JoinGame joinGame = new(Player.EntityId, false, Gamemode.Creative, Gamemode.Creative,
                                    new Utilities.Identifier[] { new("world") }, GameServer.DimensionCodec.RootTag, GameServer.OverworldDimension.RootTag,
                                    new("world"), 0, 99, 8, false, true, false, true);
                                Send(joinGame);

                                KeepAlive = new(Send, Timeout, 1000);
                                KeepAlive.Start();

                                SP17PluginMessage brand = new(new Utilities.Identifier("minecraft", "brand"),
                                    (sbyte[]) (Array) Encoding.UTF8.GetBytes("nylium"));
                                // TODO this causes out of bounds on the client
                                //Send(brand);
                                break;
                            }
                    }
                    break;
                case ProtocolState.Play:
                    switch(packet) {
                        case CP10KeepAlive: {
                                if(KeepAlive != null) {
                                    KeepAlive.HasResponded = true;
                                } else {
                                    SP19Disconnect disconnect = new(new {
                                        text = "keepAlive == null"
                                    });

                                    Dispose();
                                    return;
                                }
                                break;
                            }
                        case CP05ClientSettings: {
                                CP05ClientSettings clientSettings = (CP05ClientSettings) packet;
                                ViewDistance = clientSettings.ViewDistance;

                                SP3FHeldItemChange heldItemChange = new(0);
                                Send(heldItemChange);

                                SP5ADeclareRecipes declareRecipes = new(null); // TODO generate recipes from recipes.json
                                Send(declareRecipes);

                                SP5BTags tags = new(Tag.blockTags.ToArray(),
                                    Tag.itemTags.ToArray(),
                                    Tag.fluidTags.ToArray(),
                                    Tag.entityTags.ToArray());
                                Send(tags);

                                SP34PlayerPositionAndLook playerPositionAndLook = new(Player.X, Player.Y, Player.Z,
                                    Player.Yaw, Player.Pitch, 0, random.Next(int.MaxValue));
                                Send(playerPositionAndLook);

                                SP40UpdateViewPosition updateViewPosition = new(0, 0);
                                Send(updateViewPosition);

                                Chunk[] chunks = World.GetChunksInViewDistance((int) Math.Floor(Player.X / 16), (int) Math.Floor(Player.Z / 16),
                                    (sbyte) (ViewDistance - 1));

                                // TODO unhardcode everything here
                                int mask = 0b00000000_00000000_00000000_00000001;

                                byte[] a = new byte[] { 0x01, 0x00, 0x80, 0x40, 0x20, 0x10, 0x08, 0x04 };
                                byte[] b = new byte[] { 0x00, 0x00, 0x00, 0x00, 0x20, 0x10, 0x08, 0x04 };

                                long al = BinaryPrimitives.ReadInt64LittleEndian(a);
                                long bl = BinaryPrimitives.ReadInt64LittleEndian(b);

                                NbtCompound heightmap = new("") {
                                    new NbtLongArray("MOTION_BLOCKING", new long[] {
                                            al, al, al, al, al, al, al, al, al, al, al, al, al, al, al, al, al, al, al, al,
                                            al, al, al, al, al, al, al, al, al, al, al, al, al, al, al,
                                            bl
                                        }),
                                    new NbtLongArray("WORLD_SURFACE")
                                };

                                int[] biomes = Enumerable.Repeat(127, 1024).ToArray();

                                // TODO somehow the entire chunk is underwater?
                                for(int i = 0; i < chunks.Length; i++) {
                                    Chunk chunk = chunks[i];
                                    sbyte[] data = null;

                                    using(MemoryStream stream = RMSManager.Get().GetStream("chunk data convert thing")) {
                                        // only 1 section sent (see primary bit mask) therefore no loop
                                        int nonAirBlockCount = chunk.GetBlockCountInSection(0, false);

                                        Short blockCount = new((short) nonAirBlockCount);
                                        UByte bitsPerBlock = new((byte) GameBlock.bitsPerBlock);

                                        VarInt paletteLength = new(3);
                                        VarInt stone = new(1);
                                        VarInt air = new(0);

                                        int[] blockIds = chunk.GetBlocksInSection(0);
                                        long[] compactedLong = SectionUtils.ToCompactedLongArray(blockIds, GameBlock.bitsPerBlock);

                                        VarInt dataArrayLength = new(compactedLong.Length);
                                        Array<long, Long> dataArray = new(compactedLong);

                                        blockCount.Write(stream);
                                        bitsPerBlock.Write(stream);
                                        dataArrayLength.Write(stream);
                                        dataArray.Write(stream);

                                        data = (sbyte[]) (Array) stream.ToArray();
                                    }

                                    SP20ChunkData chunkData = new(chunk.X, chunk.Z, true, mask, heightmap,
                                        biomes, data, new NbtCompound[] { });
                                    Send(chunkData);
                                }

                                SP3DWorldBorder worldBorder = new(0, 0, 0, 64, 0, 29999984, 16, 2);
                                Send(worldBorder);

                                SP42SpawnPosition spawnPosition = new(new(0, 16, 0));
                                Send(spawnPosition);

                                playerPositionAndLook = new(Player.X, Player.Y, Player.Z,
                                    Player.Yaw, Player.Pitch, 0, random.Next(int.MaxValue));
                                Send(playerPositionAndLook);

                                Ready = true;
                                break;
                            }
                    }
                    break;
            }
        }

        public void Send(NetworkPacket packet) {
            try {
                byte[] data = packet.ToBytes();

                Socket.BeginSend(data, 0, data.Length, 0,
                    new AsyncCallback(SendCallback), packet);
            } catch(ObjectDisposedException) { } catch(SocketException) { }
        }

        private void SendCallback(IAsyncResult ar) {
            NetworkPacket packet = (NetworkPacket) ar.AsyncState;

            try {
                Socket.EndSend(ar);
            } catch(Exception e) {
                Console.WriteLine(e.ToString());
            } finally {
                packet.Dispose();
            }
        }

        private void Timeout() {
            SP19Disconnect disconnect = new(GameServer.TIMEOUT_MESSAGE);
            Send(disconnect);
        }

        public void Dispose() {
            try {
                Socket.Shutdown(SocketShutdown.Both);
                Socket.Close();
            } catch(ObjectDisposedException) { }

            Socket = null;

            if(KeepAlive != null) KeepAlive.Stop();

            Player = null;
            World = null;
        }
    }
}