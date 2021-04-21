// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class DeadBrainCoralWallFanBlock : BaseBlock {

        public Face Facing { get; }
        public bool Waterlogged { get; }

        public DeadBrainCoralWallFanBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 609, 9572) { }

        public DeadBrainCoralWallFanBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z, 609, state) {
            if(state == 9572) {
                Facing = Face.North;
                Waterlogged = true;
            } else if(state == 9573) {
                Facing = Face.North;
                Waterlogged = false;
            } else if(state == 9574) {
                Facing = Face.South;
                Waterlogged = true;
            } else if(state == 9575) {
                Facing = Face.South;
                Waterlogged = false;
            } else if(state == 9576) {
                Facing = Face.West;
                Waterlogged = true;
            } else if(state == 9577) {
                Facing = Face.West;
                Waterlogged = false;
            } else if(state == 9578) {
                Facing = Face.East;
                Waterlogged = true;
            } else if(state == 9579) {
                Facing = Face.East;
                Waterlogged = false;
            }
        }

        public DeadBrainCoralWallFanBlock(Chunk chunk, int x, int y, int z, Face facing, bool waterlogged) : base(chunk, x, y, z, 609, 9572) {
if(facing == Face.North && waterlogged == true) {
                State = 9572;
            } else if(facing == Face.North && waterlogged == false) {
                State = 9573;
            } else if(facing == Face.South && waterlogged == true) {
                State = 9574;
            } else if(facing == Face.South && waterlogged == false) {
                State = 9575;
            } else if(facing == Face.West && waterlogged == true) {
                State = 9576;
            } else if(facing == Face.West && waterlogged == false) {
                State = 9577;
            } else if(facing == Face.East && waterlogged == true) {
                State = 9578;
            } else if(facing == Face.East && waterlogged == false) {
                State = 9579;
            }
        }
    }
}