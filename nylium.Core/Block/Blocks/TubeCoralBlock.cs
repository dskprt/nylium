// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class TubeCoralBlock : BaseBlock {

        public bool Waterlogged { get; }

        public TubeCoralBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 593, 9534) { }

        public TubeCoralBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z, 593, state) {
            if(state == 9534) {
                Waterlogged = true;
            } else if(state == 9535) {
                Waterlogged = false;
            }
        }

        public TubeCoralBlock(Chunk chunk, int x, int y, int z, bool waterlogged) : base(chunk, x, y, z, 593, 9534) {
if(waterlogged == true) {
                State = 9534;
            } else if(waterlogged == false) {
                State = 9535;
            }
        }
    }
}