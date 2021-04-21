// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class OrangeGlazedTerracottaBlock : BaseBlock {

        public Face Facing { get; }

        public OrangeGlazedTerracottaBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 527, 9382) { }

        public OrangeGlazedTerracottaBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z, 527, state) {
            if(state == 9382) {
                Facing = Face.North;
            } else if(state == 9383) {
                Facing = Face.South;
            } else if(state == 9384) {
                Facing = Face.West;
            } else if(state == 9385) {
                Facing = Face.East;
            }
        }

        public OrangeGlazedTerracottaBlock(Chunk chunk, int x, int y, int z, Face facing) : base(chunk, x, y, z, 527, 9382) {
if(facing == Face.North) {
                State = 9382;
            } else if(facing == Face.South) {
                State = 9383;
            } else if(facing == Face.West) {
                State = 9384;
            } else if(facing == Face.East) {
                State = 9385;
            }
        }
    }
}