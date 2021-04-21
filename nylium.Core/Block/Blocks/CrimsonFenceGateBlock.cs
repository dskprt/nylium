// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class CrimsonFenceGateBlock : BaseBlock {

        public Face Facing { get; }
        public bool In_Wall { get; }
        public bool Open { get; }
        public bool Powered { get; }

        public CrimsonFenceGateBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 714, 15270) { }

        public CrimsonFenceGateBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z, 714, state) {
            if(state == 15263) {
                Facing = Face.North;
                In_Wall = true;
                Open = true;
                Powered = true;
            } else if(state == 15264) {
                Facing = Face.North;
                In_Wall = true;
                Open = true;
                Powered = false;
            } else if(state == 15265) {
                Facing = Face.North;
                In_Wall = true;
                Open = false;
                Powered = true;
            } else if(state == 15266) {
                Facing = Face.North;
                In_Wall = true;
                Open = false;
                Powered = false;
            } else if(state == 15267) {
                Facing = Face.North;
                In_Wall = false;
                Open = true;
                Powered = true;
            } else if(state == 15268) {
                Facing = Face.North;
                In_Wall = false;
                Open = true;
                Powered = false;
            } else if(state == 15269) {
                Facing = Face.North;
                In_Wall = false;
                Open = false;
                Powered = true;
            } else if(state == 15270) {
                Facing = Face.North;
                In_Wall = false;
                Open = false;
                Powered = false;
            } else if(state == 15271) {
                Facing = Face.South;
                In_Wall = true;
                Open = true;
                Powered = true;
            } else if(state == 15272) {
                Facing = Face.South;
                In_Wall = true;
                Open = true;
                Powered = false;
            } else if(state == 15273) {
                Facing = Face.South;
                In_Wall = true;
                Open = false;
                Powered = true;
            } else if(state == 15274) {
                Facing = Face.South;
                In_Wall = true;
                Open = false;
                Powered = false;
            } else if(state == 15275) {
                Facing = Face.South;
                In_Wall = false;
                Open = true;
                Powered = true;
            } else if(state == 15276) {
                Facing = Face.South;
                In_Wall = false;
                Open = true;
                Powered = false;
            } else if(state == 15277) {
                Facing = Face.South;
                In_Wall = false;
                Open = false;
                Powered = true;
            } else if(state == 15278) {
                Facing = Face.South;
                In_Wall = false;
                Open = false;
                Powered = false;
            } else if(state == 15279) {
                Facing = Face.West;
                In_Wall = true;
                Open = true;
                Powered = true;
            } else if(state == 15280) {
                Facing = Face.West;
                In_Wall = true;
                Open = true;
                Powered = false;
            } else if(state == 15281) {
                Facing = Face.West;
                In_Wall = true;
                Open = false;
                Powered = true;
            } else if(state == 15282) {
                Facing = Face.West;
                In_Wall = true;
                Open = false;
                Powered = false;
            } else if(state == 15283) {
                Facing = Face.West;
                In_Wall = false;
                Open = true;
                Powered = true;
            } else if(state == 15284) {
                Facing = Face.West;
                In_Wall = false;
                Open = true;
                Powered = false;
            } else if(state == 15285) {
                Facing = Face.West;
                In_Wall = false;
                Open = false;
                Powered = true;
            } else if(state == 15286) {
                Facing = Face.West;
                In_Wall = false;
                Open = false;
                Powered = false;
            } else if(state == 15287) {
                Facing = Face.East;
                In_Wall = true;
                Open = true;
                Powered = true;
            } else if(state == 15288) {
                Facing = Face.East;
                In_Wall = true;
                Open = true;
                Powered = false;
            } else if(state == 15289) {
                Facing = Face.East;
                In_Wall = true;
                Open = false;
                Powered = true;
            } else if(state == 15290) {
                Facing = Face.East;
                In_Wall = true;
                Open = false;
                Powered = false;
            } else if(state == 15291) {
                Facing = Face.East;
                In_Wall = false;
                Open = true;
                Powered = true;
            } else if(state == 15292) {
                Facing = Face.East;
                In_Wall = false;
                Open = true;
                Powered = false;
            } else if(state == 15293) {
                Facing = Face.East;
                In_Wall = false;
                Open = false;
                Powered = true;
            } else if(state == 15294) {
                Facing = Face.East;
                In_Wall = false;
                Open = false;
                Powered = false;
            }
        }

        public CrimsonFenceGateBlock(Chunk chunk, int x, int y, int z, Face facing, bool in_wall, bool open, bool powered) : base(chunk, x, y, z, 714, 15270) {
if(facing == Face.North && in_wall == true && open == true && powered == true) {
                State = 15263;
            } else if(facing == Face.North && in_wall == true && open == true && powered == false) {
                State = 15264;
            } else if(facing == Face.North && in_wall == true && open == false && powered == true) {
                State = 15265;
            } else if(facing == Face.North && in_wall == true && open == false && powered == false) {
                State = 15266;
            } else if(facing == Face.North && in_wall == false && open == true && powered == true) {
                State = 15267;
            } else if(facing == Face.North && in_wall == false && open == true && powered == false) {
                State = 15268;
            } else if(facing == Face.North && in_wall == false && open == false && powered == true) {
                State = 15269;
            } else if(facing == Face.North && in_wall == false && open == false && powered == false) {
                State = 15270;
            } else if(facing == Face.South && in_wall == true && open == true && powered == true) {
                State = 15271;
            } else if(facing == Face.South && in_wall == true && open == true && powered == false) {
                State = 15272;
            } else if(facing == Face.South && in_wall == true && open == false && powered == true) {
                State = 15273;
            } else if(facing == Face.South && in_wall == true && open == false && powered == false) {
                State = 15274;
            } else if(facing == Face.South && in_wall == false && open == true && powered == true) {
                State = 15275;
            } else if(facing == Face.South && in_wall == false && open == true && powered == false) {
                State = 15276;
            } else if(facing == Face.South && in_wall == false && open == false && powered == true) {
                State = 15277;
            } else if(facing == Face.South && in_wall == false && open == false && powered == false) {
                State = 15278;
            } else if(facing == Face.West && in_wall == true && open == true && powered == true) {
                State = 15279;
            } else if(facing == Face.West && in_wall == true && open == true && powered == false) {
                State = 15280;
            } else if(facing == Face.West && in_wall == true && open == false && powered == true) {
                State = 15281;
            } else if(facing == Face.West && in_wall == true && open == false && powered == false) {
                State = 15282;
            } else if(facing == Face.West && in_wall == false && open == true && powered == true) {
                State = 15283;
            } else if(facing == Face.West && in_wall == false && open == true && powered == false) {
                State = 15284;
            } else if(facing == Face.West && in_wall == false && open == false && powered == true) {
                State = 15285;
            } else if(facing == Face.West && in_wall == false && open == false && powered == false) {
                State = 15286;
            } else if(facing == Face.East && in_wall == true && open == true && powered == true) {
                State = 15287;
            } else if(facing == Face.East && in_wall == true && open == true && powered == false) {
                State = 15288;
            } else if(facing == Face.East && in_wall == true && open == false && powered == true) {
                State = 15289;
            } else if(facing == Face.East && in_wall == true && open == false && powered == false) {
                State = 15290;
            } else if(facing == Face.East && in_wall == false && open == true && powered == true) {
                State = 15291;
            } else if(facing == Face.East && in_wall == false && open == true && powered == false) {
                State = 15292;
            } else if(facing == Face.East && in_wall == false && open == false && powered == true) {
                State = 15293;
            } else if(facing == Face.East && in_wall == false && open == false && powered == false) {
                State = 15294;
            }
        }
    }
}