// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class SpruceWallSignBlock : BaseBlock {

        public Face Facing { get; }
        public bool Waterlogged { get; }

        public SpruceWallSignBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 166, 3744) { }

        public SpruceWallSignBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z, 166, state) {
            if(state == 3743) {
                Facing = Face.North;
                Waterlogged = true;
            } else if(state == 3744) {
                Facing = Face.North;
                Waterlogged = false;
            } else if(state == 3745) {
                Facing = Face.South;
                Waterlogged = true;
            } else if(state == 3746) {
                Facing = Face.South;
                Waterlogged = false;
            } else if(state == 3747) {
                Facing = Face.West;
                Waterlogged = true;
            } else if(state == 3748) {
                Facing = Face.West;
                Waterlogged = false;
            } else if(state == 3749) {
                Facing = Face.East;
                Waterlogged = true;
            } else if(state == 3750) {
                Facing = Face.East;
                Waterlogged = false;
            }
        }

        public SpruceWallSignBlock(Chunk chunk, int x, int y, int z, Face facing, bool waterlogged) : base(chunk, x, y, z, 166, 3744) {
if(facing == Face.North && waterlogged == true) {
                State = 3743;
            } else if(facing == Face.North && waterlogged == false) {
                State = 3744;
            } else if(facing == Face.South && waterlogged == true) {
                State = 3745;
            } else if(facing == Face.South && waterlogged == false) {
                State = 3746;
            } else if(facing == Face.West && waterlogged == true) {
                State = 3747;
            } else if(facing == Face.West && waterlogged == false) {
                State = 3748;
            } else if(facing == Face.East && waterlogged == true) {
                State = 3749;
            } else if(facing == Face.East && waterlogged == false) {
                State = 3750;
            }
        }
    }
}