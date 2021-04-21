// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class DarkOakWoodBlock : BaseBlock {

        public Axis Axis { get; }

        public DarkOakWoodBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 52, 125) { }

        public DarkOakWoodBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z, 52, state) {
            if(state == 124) {
                Axis = Axis.X;
            } else if(state == 125) {
                Axis = Axis.Y;
            } else if(state == 126) {
                Axis = Axis.Z;
            }
        }

        public DarkOakWoodBlock(Chunk chunk, int x, int y, int z, Axis axis) : base(chunk, x, y, z, 52, 125) {
if(axis == Axis.X) {
                State = 124;
            } else if(axis == Axis.Y) {
                State = 125;
            } else if(axis == Axis.Z) {
                State = 126;
            }
        }
    }
}