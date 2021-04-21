// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class CreeperWallHeadBlock : BaseBlock {

        public Face Facing { get; }

        public CreeperWallHeadBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 323, 6590) { }

        public CreeperWallHeadBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z, 323, state) {
            if(state == 6590) {
                Facing = Face.North;
            } else if(state == 6591) {
                Facing = Face.South;
            } else if(state == 6592) {
                Facing = Face.West;
            } else if(state == 6593) {
                Facing = Face.East;
            }
        }

        public CreeperWallHeadBlock(Chunk chunk, int x, int y, int z, Face facing) : base(chunk, x, y, z, 323, 6590) {
if(facing == Face.North) {
                State = 6590;
            } else if(facing == Face.South) {
                State = 6591;
            } else if(facing == Face.West) {
                State = 6592;
            } else if(facing == Face.East) {
                State = 6593;
            }
        }
    }
}