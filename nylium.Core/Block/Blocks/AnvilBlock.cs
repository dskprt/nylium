// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class AnvilBlock : BaseBlock {

        public Face Facing { get; }

        public AnvilBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 326, 6614) { }

        public AnvilBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z, 326, state) {
            if(state == 6614) {
                Facing = Face.North;
            } else if(state == 6615) {
                Facing = Face.South;
            } else if(state == 6616) {
                Facing = Face.West;
            } else if(state == 6617) {
                Facing = Face.East;
            }
        }

        public AnvilBlock(Chunk chunk, int x, int y, int z, Face facing) : base(chunk, x, y, z, 326, 6614) {
if(facing == Face.North) {
                State = 6614;
            } else if(facing == Face.South) {
                State = 6615;
            } else if(facing == Face.West) {
                State = 6616;
            } else if(facing == Face.East) {
                State = 6617;
            }
        }
    }
}