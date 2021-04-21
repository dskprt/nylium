// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class AcaciaWoodBlock : BaseBlock {

        public Axis Axis { get; }

        public AcaciaWoodBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 51, 122) { }

        public AcaciaWoodBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z, 51, state) {
            if(state == 121) {
                Axis = Axis.X;
            } else if(state == 122) {
                Axis = Axis.Y;
            } else if(state == 123) {
                Axis = Axis.Z;
            }
        }

        public AcaciaWoodBlock(Chunk chunk, int x, int y, int z, Axis axis) : base(chunk, x, y, z, 51, 122) {
if(axis == Axis.X) {
                State = 121;
            } else if(axis == Axis.Y) {
                State = 122;
            } else if(axis == Axis.Z) {
                State = 123;
            }
        }
    }
}