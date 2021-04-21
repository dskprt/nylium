// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class SmokerBlock : BaseBlock {

        public Face Facing { get; }
        public bool Lit { get; }

        public SmokerBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 669, 14808) { }

        public SmokerBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z, 669, state) {
            if(state == 14807) {
                Facing = Face.North;
                Lit = true;
            } else if(state == 14808) {
                Facing = Face.North;
                Lit = false;
            } else if(state == 14809) {
                Facing = Face.South;
                Lit = true;
            } else if(state == 14810) {
                Facing = Face.South;
                Lit = false;
            } else if(state == 14811) {
                Facing = Face.West;
                Lit = true;
            } else if(state == 14812) {
                Facing = Face.West;
                Lit = false;
            } else if(state == 14813) {
                Facing = Face.East;
                Lit = true;
            } else if(state == 14814) {
                Facing = Face.East;
                Lit = false;
            }
        }

        public SmokerBlock(Chunk chunk, int x, int y, int z, Face facing, bool lit) : base(chunk, x, y, z, 669, 14808) {
if(facing == Face.North && lit == true) {
                State = 14807;
            } else if(facing == Face.North && lit == false) {
                State = 14808;
            } else if(facing == Face.South && lit == true) {
                State = 14809;
            } else if(facing == Face.South && lit == false) {
                State = 14810;
            } else if(facing == Face.West && lit == true) {
                State = 14811;
            } else if(facing == Face.West && lit == false) {
                State = 14812;
            } else if(facing == Face.East && lit == true) {
                State = 14813;
            } else if(facing == Face.East && lit == false) {
                State = 14814;
            }
        }
    }
}