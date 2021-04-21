// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class StrippedBirchLogBlock : BaseBlock {

        public Axis Axis { get; }

        public StrippedBirchLogBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 42, 95) { }

        public StrippedBirchLogBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z, 42, state) {
            if(state == 94) {
                Axis = Axis.X;
            } else if(state == 95) {
                Axis = Axis.Y;
            } else if(state == 96) {
                Axis = Axis.Z;
            }
        }

        public StrippedBirchLogBlock(Chunk chunk, int x, int y, int z, Axis axis) : base(chunk, x, y, z, 42, 95) {
if(axis == Axis.X) {
                State = 94;
            } else if(axis == Axis.Y) {
                State = 95;
            } else if(axis == Axis.Z) {
                State = 96;
            }
        }
    }
}