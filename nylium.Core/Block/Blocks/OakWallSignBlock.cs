// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class OakWallSignBlock : BaseBlock {

        public Face Facing { get; }
        public bool Waterlogged { get; }

        public OakWallSignBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 165, 3736) { }

        public OakWallSignBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z, 165, state) {
            if(state == 3735) {
                Facing = Face.North;
                Waterlogged = true;
            } else if(state == 3736) {
                Facing = Face.North;
                Waterlogged = false;
            } else if(state == 3737) {
                Facing = Face.South;
                Waterlogged = true;
            } else if(state == 3738) {
                Facing = Face.South;
                Waterlogged = false;
            } else if(state == 3739) {
                Facing = Face.West;
                Waterlogged = true;
            } else if(state == 3740) {
                Facing = Face.West;
                Waterlogged = false;
            } else if(state == 3741) {
                Facing = Face.East;
                Waterlogged = true;
            } else if(state == 3742) {
                Facing = Face.East;
                Waterlogged = false;
            }
        }

        public OakWallSignBlock(Chunk chunk, int x, int y, int z, Face facing, bool waterlogged) : base(chunk, x, y, z, 165, 3736) {
if(facing == Face.North && waterlogged == true) {
                State = 3735;
            } else if(facing == Face.North && waterlogged == false) {
                State = 3736;
            } else if(facing == Face.South && waterlogged == true) {
                State = 3737;
            } else if(facing == Face.South && waterlogged == false) {
                State = 3738;
            } else if(facing == Face.West && waterlogged == true) {
                State = 3739;
            } else if(facing == Face.West && waterlogged == false) {
                State = 3740;
            } else if(facing == Face.East && waterlogged == true) {
                State = 3741;
            } else if(facing == Face.East && waterlogged == false) {
                State = 3742;
            }
        }
    }
}