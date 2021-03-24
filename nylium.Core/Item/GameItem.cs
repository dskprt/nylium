﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using Jil;
using nylium.Core.Entity.Inventory;
using nylium.Utilities;
using Serilog;

namespace nylium.Core.Item {

    public class GameItem {

        private static readonly Dictionary<string, int> items = new();

        public EntityInventory.Slot Parent { get; }
        public int Id { get; }

        public GameItem(EntityInventory.Slot parent, int id) {
            Parent = parent;
            Id = id;
        }

        // TODO better way to do this?
        public static string GetItemNamedId(int id) {
            return items
                .FirstOrDefault(x => x.Value == id)
                .Key;
        }

        public static int GetItemProtocolId(string sid) {
            return items.ContainsKey(sid.Replace("minecraft:", "")) ? items[sid.Replace("minecraft:", "")] : -1;
        }

        public static void Initialize() {
            Stopwatch stopwatch = new();
            stopwatch.Start();

            using(MemoryStream compressedStream = RMSManager.Get().GetStream(Properties.Resources.items)) {
                using(GZipStream zipStream = new(compressedStream, CompressionMode.Decompress)) {
                    using(MemoryStream resultStream = RMSManager.Get().GetStream()) {
                        zipStream.CopyTo(resultStream);

                        dynamic json = JSON.DeserializeDynamic(Encoding.UTF8.GetString(resultStream.ToArray()));

                        foreach(dynamic item in json[0].items.item) {
                            string namedId = item.Value.text_id;
                            int id = item.Value.numeric_id;

                            items.Add(namedId, id);
                        }
                    }
                }
            }

            stopwatch.Stop();
            Log.Debug("Initialized items in " + Math.Round(stopwatch.Elapsed.TotalMilliseconds, 2) + "ms");
        }
    }
}