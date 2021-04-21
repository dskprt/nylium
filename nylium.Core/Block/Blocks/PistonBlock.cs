// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class PistonBlock : BaseBlock {

        public bool Extended { get; }
        public Face Facing { get; }

        public PistonBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 100, 1354) { }

        public PistonBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z, 100, state) {if(state == 1348) {
                Extended = true;
                Facing = Face.North;
            } else if(state == 1349) {
                Extended = true;
                Facing = Face.East;
            } else if(state == 1350) {
                Extended = true;
                Facing = Face.South;
            } else if(state == 1351) {
                Extended = true;
                Facing = Face.West;
            } else if(state == 1352) {
                Extended = true;
                Facing = Face.Up;
            } else if(state == 1353) {
                Extended = true;
                Facing = Face.Down;
            } else if(state == 1354) {
                Extended = false;
                Facing = Face.North;
            } else if(state == 1355) {
                Extended = false;
                Facing = Face.East;
            } else if(state == 1356) {
                Extended = false;
                Facing = Face.South;
            } else if(state == 1357) {
                Extended = false;
                Facing = Face.West;
            } else if(state == 1358) {
                Extended = false;
                Facing = Face.Up;
            } else if(state == 1359) {
                Extended = false;
                Facing = Face.Down;
            }
        }

        public PistonBlock(Chunk chunk, int x, int y, int z, bool extended, Face facing) : base(chunk, x, y, z, 100, 1354) {
if(extended == true && facing == Face.North) {
                State = 1348;
            } else if(extended == true && facing == Face.East) {
                State = 1349;
            } else if(extended == true && facing == Face.South) {
                State = 1350;
            } else if(extended == true && facing == Face.West) {
                State = 1351;
            } else if(extended == true && facing == Face.Up) {
                State = 1352;
            } else if(extended == true && facing == Face.Down) {
                State = 1353;
            } else if(extended == false && facing == Face.North) {
                State = 1354;
            } else if(extended == false && facing == Face.East) {
                State = 1355;
            } else if(extended == false && facing == Face.South) {
                State = 1356;
            } else if(extended == false && facing == Face.West) {
                State = 1357;
            } else if(extended == false && facing == Face.Up) {
                State = 1358;
            } else if(extended == false && facing == Face.Down) {
                State = 1359;
            }
        }

        public enum BlockType {

            Normal,
            Sticky
        }
    }
}