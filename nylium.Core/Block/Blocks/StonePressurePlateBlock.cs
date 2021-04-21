// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class StonePressurePlateBlock : BaseBlock {

        public bool Powered { get; }

        public StonePressurePlateBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 172, 3808) { }

        public StonePressurePlateBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z, 172, state) {
            if(state == 3807) {
                Powered = true;
            } else if(state == 3808) {
                Powered = false;
            }
        }

        public StonePressurePlateBlock(Chunk chunk, int x, int y, int z, bool powered) : base(chunk, x, y, z, 172, 3808) {
if(powered == true) {
                State = 3807;
            } else if(powered == false) {
                State = 3808;
            }
        }
    }
}