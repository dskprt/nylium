// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class HayBlockBlock : BaseBlock {

        public Axis Axis { get; }

        public HayBlockBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 390, 7868) { }

        public HayBlockBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z, 390, state) {
            if(state == 7867) {
                Axis = Axis.X;
            } else if(state == 7868) {
                Axis = Axis.Y;
            } else if(state == 7869) {
                Axis = Axis.Z;
            }
        }

        public HayBlockBlock(Chunk chunk, int x, int y, int z, Axis axis) : base(chunk, x, y, z, 390, 7868) {
if(axis == Axis.X) {
                State = 7867;
            } else if(axis == Axis.Y) {
                State = 7868;
            } else if(axis == Axis.Z) {
                State = 7869;
            }
        }
    }
}