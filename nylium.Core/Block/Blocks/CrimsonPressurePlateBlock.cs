// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class CrimsonPressurePlateBlock : BaseBlock {

        public bool Powered { get; }

        public CrimsonPressurePlateBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 708, 15068) { }

        public CrimsonPressurePlateBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z, 708, state) {
            if(state == 15067) {
                Powered = true;
            } else if(state == 15068) {
                Powered = false;
            }
        }

        public CrimsonPressurePlateBlock(Chunk chunk, int x, int y, int z, bool powered) : base(chunk, x, y, z, 708, 15068) {
if(powered == true) {
                State = 15067;
            } else if(powered == false) {
                State = 15068;
            }
        }
    }
}