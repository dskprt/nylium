// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class BrainCoralBlock : BaseBlock {

        public bool Waterlogged { get; }

        public BrainCoralBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 594, 9536) { }

        public BrainCoralBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z, 594, state) {
            if(state == 9536) {
                Waterlogged = true;
            } else if(state == 9537) {
                Waterlogged = false;
            }
        }

        public BrainCoralBlock(Chunk chunk, int x, int y, int z, bool waterlogged) : base(chunk, x, y, z, 594, 9536) {
if(waterlogged == true) {
                State = 9536;
            } else if(waterlogged == false) {
                State = 9537;
            }
        }
    }
}