// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class DamagedAnvilBlock : BaseBlock {

        public Face Facing { get; }

        public DamagedAnvilBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 328, 6622) { }

        public DamagedAnvilBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z, 328, state) {
            if(state == 6622) {
                Facing = Face.North;
            } else if(state == 6623) {
                Facing = Face.South;
            } else if(state == 6624) {
                Facing = Face.West;
            } else if(state == 6625) {
                Facing = Face.East;
            }
        }

        public DamagedAnvilBlock(Chunk chunk, int x, int y, int z, Face facing) : base(chunk, x, y, z, 328, 6622) {
if(facing == Face.North) {
                State = 6622;
            } else if(facing == Face.South) {
                State = 6623;
            } else if(facing == Face.West) {
                State = 6624;
            } else if(facing == Face.East) {
                State = 6625;
            }
        }
    }
}