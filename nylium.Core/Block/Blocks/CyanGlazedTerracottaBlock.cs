// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class CyanGlazedTerracottaBlock : BaseBlock {

        public Face Facing { get; }

        public CyanGlazedTerracottaBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 535, 9414) { }

        public CyanGlazedTerracottaBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z, 535, state) {
            if(state == 9414) {
                Facing = Face.North;
            } else if(state == 9415) {
                Facing = Face.South;
            } else if(state == 9416) {
                Facing = Face.West;
            } else if(state == 9417) {
                Facing = Face.East;
            }
        }

        public CyanGlazedTerracottaBlock(Chunk chunk, int x, int y, int z, Face facing) : base(chunk, x, y, z, 535, 9414) {
if(facing == Face.North) {
                State = 9414;
            } else if(facing == Face.South) {
                State = 9415;
            } else if(facing == Face.West) {
                State = 9416;
            } else if(facing == Face.East) {
                State = 9417;
            }
        }
    }
}