// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class StrippedBirchWoodBlock : BaseBlock {

        public Axis Axis { get; }

        public StrippedBirchWoodBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 55, 134) { }

        public StrippedBirchWoodBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z, 55, state) {
            if(state == 133) {
                Axis = Axis.X;
            } else if(state == 134) {
                Axis = Axis.Y;
            } else if(state == 135) {
                Axis = Axis.Z;
            }
        }

        public StrippedBirchWoodBlock(Chunk chunk, int x, int y, int z, Axis axis) : base(chunk, x, y, z, 55, 134) {
if(axis == Axis.X) {
                State = 133;
            } else if(axis == Axis.Y) {
                State = 134;
            } else if(axis == Axis.Z) {
                State = 135;
            }
        }
    }
}