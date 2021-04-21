// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class CrimsonTrapdoorBlock : BaseBlock {

        public Face Facing { get; }
        public Half Half { get; }
        public bool Open { get; }
        public bool Powered { get; }
        public bool Waterlogged { get; }

        public CrimsonTrapdoorBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 712, 15150) { }

        public CrimsonTrapdoorBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z, 712, state) {
            if(state == 15135) {
                Facing = Face.North;
                Half = Half.Top;
                Open = true;
                Powered = true;
                Waterlogged = true;
            } else if(state == 15136) {
                Facing = Face.North;
                Half = Half.Top;
                Open = true;
                Powered = true;
                Waterlogged = false;
            } else if(state == 15137) {
                Facing = Face.North;
                Half = Half.Top;
                Open = true;
                Powered = false;
                Waterlogged = true;
            } else if(state == 15138) {
                Facing = Face.North;
                Half = Half.Top;
                Open = true;
                Powered = false;
                Waterlogged = false;
            } else if(state == 15139) {
                Facing = Face.North;
                Half = Half.Top;
                Open = false;
                Powered = true;
                Waterlogged = true;
            } else if(state == 15140) {
                Facing = Face.North;
                Half = Half.Top;
                Open = false;
                Powered = true;
                Waterlogged = false;
            } else if(state == 15141) {
                Facing = Face.North;
                Half = Half.Top;
                Open = false;
                Powered = false;
                Waterlogged = true;
            } else if(state == 15142) {
                Facing = Face.North;
                Half = Half.Top;
                Open = false;
                Powered = false;
                Waterlogged = false;
            } else if(state == 15143) {
                Facing = Face.North;
                Half = Half.Bottom;
                Open = true;
                Powered = true;
                Waterlogged = true;
            } else if(state == 15144) {
                Facing = Face.North;
                Half = Half.Bottom;
                Open = true;
                Powered = true;
                Waterlogged = false;
            } else if(state == 15145) {
                Facing = Face.North;
                Half = Half.Bottom;
                Open = true;
                Powered = false;
                Waterlogged = true;
            } else if(state == 15146) {
                Facing = Face.North;
                Half = Half.Bottom;
                Open = true;
                Powered = false;
                Waterlogged = false;
            } else if(state == 15147) {
                Facing = Face.North;
                Half = Half.Bottom;
                Open = false;
                Powered = true;
                Waterlogged = true;
            } else if(state == 15148) {
                Facing = Face.North;
                Half = Half.Bottom;
                Open = false;
                Powered = true;
                Waterlogged = false;
            } else if(state == 15149) {
                Facing = Face.North;
                Half = Half.Bottom;
                Open = false;
                Powered = false;
                Waterlogged = true;
            } else if(state == 15150) {
                Facing = Face.North;
                Half = Half.Bottom;
                Open = false;
                Powered = false;
                Waterlogged = false;
            } else if(state == 15151) {
                Facing = Face.South;
                Half = Half.Top;
                Open = true;
                Powered = true;
                Waterlogged = true;
            } else if(state == 15152) {
                Facing = Face.South;
                Half = Half.Top;
                Open = true;
                Powered = true;
                Waterlogged = false;
            } else if(state == 15153) {
                Facing = Face.South;
                Half = Half.Top;
                Open = true;
                Powered = false;
                Waterlogged = true;
            } else if(state == 15154) {
                Facing = Face.South;
                Half = Half.Top;
                Open = true;
                Powered = false;
                Waterlogged = false;
            } else if(state == 15155) {
                Facing = Face.South;
                Half = Half.Top;
                Open = false;
                Powered = true;
                Waterlogged = true;
            } else if(state == 15156) {
                Facing = Face.South;
                Half = Half.Top;
                Open = false;
                Powered = true;
                Waterlogged = false;
            } else if(state == 15157) {
                Facing = Face.South;
                Half = Half.Top;
                Open = false;
                Powered = false;
                Waterlogged = true;
            } else if(state == 15158) {
                Facing = Face.South;
                Half = Half.Top;
                Open = false;
                Powered = false;
                Waterlogged = false;
            } else if(state == 15159) {
                Facing = Face.South;
                Half = Half.Bottom;
                Open = true;
                Powered = true;
                Waterlogged = true;
            } else if(state == 15160) {
                Facing = Face.South;
                Half = Half.Bottom;
                Open = true;
                Powered = true;
                Waterlogged = false;
            } else if(state == 15161) {
                Facing = Face.South;
                Half = Half.Bottom;
                Open = true;
                Powered = false;
                Waterlogged = true;
            } else if(state == 15162) {
                Facing = Face.South;
                Half = Half.Bottom;
                Open = true;
                Powered = false;
                Waterlogged = false;
            } else if(state == 15163) {
                Facing = Face.South;
                Half = Half.Bottom;
                Open = false;
                Powered = true;
                Waterlogged = true;
            } else if(state == 15164) {
                Facing = Face.South;
                Half = Half.Bottom;
                Open = false;
                Powered = true;
                Waterlogged = false;
            } else if(state == 15165) {
                Facing = Face.South;
                Half = Half.Bottom;
                Open = false;
                Powered = false;
                Waterlogged = true;
            } else if(state == 15166) {
                Facing = Face.South;
                Half = Half.Bottom;
                Open = false;
                Powered = false;
                Waterlogged = false;
            } else if(state == 15167) {
                Facing = Face.West;
                Half = Half.Top;
                Open = true;
                Powered = true;
                Waterlogged = true;
            } else if(state == 15168) {
                Facing = Face.West;
                Half = Half.Top;
                Open = true;
                Powered = true;
                Waterlogged = false;
            } else if(state == 15169) {
                Facing = Face.West;
                Half = Half.Top;
                Open = true;
                Powered = false;
                Waterlogged = true;
            } else if(state == 15170) {
                Facing = Face.West;
                Half = Half.Top;
                Open = true;
                Powered = false;
                Waterlogged = false;
            } else if(state == 15171) {
                Facing = Face.West;
                Half = Half.Top;
                Open = false;
                Powered = true;
                Waterlogged = true;
            } else if(state == 15172) {
                Facing = Face.West;
                Half = Half.Top;
                Open = false;
                Powered = true;
                Waterlogged = false;
            } else if(state == 15173) {
                Facing = Face.West;
                Half = Half.Top;
                Open = false;
                Powered = false;
                Waterlogged = true;
            } else if(state == 15174) {
                Facing = Face.West;
                Half = Half.Top;
                Open = false;
                Powered = false;
                Waterlogged = false;
            } else if(state == 15175) {
                Facing = Face.West;
                Half = Half.Bottom;
                Open = true;
                Powered = true;
                Waterlogged = true;
            } else if(state == 15176) {
                Facing = Face.West;
                Half = Half.Bottom;
                Open = true;
                Powered = true;
                Waterlogged = false;
            } else if(state == 15177) {
                Facing = Face.West;
                Half = Half.Bottom;
                Open = true;
                Powered = false;
                Waterlogged = true;
            } else if(state == 15178) {
                Facing = Face.West;
                Half = Half.Bottom;
                Open = true;
                Powered = false;
                Waterlogged = false;
            } else if(state == 15179) {
                Facing = Face.West;
                Half = Half.Bottom;
                Open = false;
                Powered = true;
                Waterlogged = true;
            } else if(state == 15180) {
                Facing = Face.West;
                Half = Half.Bottom;
                Open = false;
                Powered = true;
                Waterlogged = false;
            } else if(state == 15181) {
                Facing = Face.West;
                Half = Half.Bottom;
                Open = false;
                Powered = false;
                Waterlogged = true;
            } else if(state == 15182) {
                Facing = Face.West;
                Half = Half.Bottom;
                Open = false;
                Powered = false;
                Waterlogged = false;
            } else if(state == 15183) {
                Facing = Face.East;
                Half = Half.Top;
                Open = true;
                Powered = true;
                Waterlogged = true;
            } else if(state == 15184) {
                Facing = Face.East;
                Half = Half.Top;
                Open = true;
                Powered = true;
                Waterlogged = false;
            } else if(state == 15185) {
                Facing = Face.East;
                Half = Half.Top;
                Open = true;
                Powered = false;
                Waterlogged = true;
            } else if(state == 15186) {
                Facing = Face.East;
                Half = Half.Top;
                Open = true;
                Powered = false;
                Waterlogged = false;
            } else if(state == 15187) {
                Facing = Face.East;
                Half = Half.Top;
                Open = false;
                Powered = true;
                Waterlogged = true;
            } else if(state == 15188) {
                Facing = Face.East;
                Half = Half.Top;
                Open = false;
                Powered = true;
                Waterlogged = false;
            } else if(state == 15189) {
                Facing = Face.East;
                Half = Half.Top;
                Open = false;
                Powered = false;
                Waterlogged = true;
            } else if(state == 15190) {
                Facing = Face.East;
                Half = Half.Top;
                Open = false;
                Powered = false;
                Waterlogged = false;
            } else if(state == 15191) {
                Facing = Face.East;
                Half = Half.Bottom;
                Open = true;
                Powered = true;
                Waterlogged = true;
            } else if(state == 15192) {
                Facing = Face.East;
                Half = Half.Bottom;
                Open = true;
                Powered = true;
                Waterlogged = false;
            } else if(state == 15193) {
                Facing = Face.East;
                Half = Half.Bottom;
                Open = true;
                Powered = false;
                Waterlogged = true;
            } else if(state == 15194) {
                Facing = Face.East;
                Half = Half.Bottom;
                Open = true;
                Powered = false;
                Waterlogged = false;
            } else if(state == 15195) {
                Facing = Face.East;
                Half = Half.Bottom;
                Open = false;
                Powered = true;
                Waterlogged = true;
            } else if(state == 15196) {
                Facing = Face.East;
                Half = Half.Bottom;
                Open = false;
                Powered = true;
                Waterlogged = false;
            } else if(state == 15197) {
                Facing = Face.East;
                Half = Half.Bottom;
                Open = false;
                Powered = false;
                Waterlogged = true;
            } else if(state == 15198) {
                Facing = Face.East;
                Half = Half.Bottom;
                Open = false;
                Powered = false;
                Waterlogged = false;
            }
        }

        public CrimsonTrapdoorBlock(Chunk chunk, int x, int y, int z, Face facing, Half half, bool open, bool powered, bool waterlogged) : base(chunk, x, y, z, 712, 15150) {
if(facing == Face.North && half == Half.Top && open == true && powered == true && waterlogged == true) {
                State = 15135;
            } else if(facing == Face.North && half == Half.Top && open == true && powered == true && waterlogged == false) {
                State = 15136;
            } else if(facing == Face.North && half == Half.Top && open == true && powered == false && waterlogged == true) {
                State = 15137;
            } else if(facing == Face.North && half == Half.Top && open == true && powered == false && waterlogged == false) {
                State = 15138;
            } else if(facing == Face.North && half == Half.Top && open == false && powered == true && waterlogged == true) {
                State = 15139;
            } else if(facing == Face.North && half == Half.Top && open == false && powered == true && waterlogged == false) {
                State = 15140;
            } else if(facing == Face.North && half == Half.Top && open == false && powered == false && waterlogged == true) {
                State = 15141;
            } else if(facing == Face.North && half == Half.Top && open == false && powered == false && waterlogged == false) {
                State = 15142;
            } else if(facing == Face.North && half == Half.Bottom && open == true && powered == true && waterlogged == true) {
                State = 15143;
            } else if(facing == Face.North && half == Half.Bottom && open == true && powered == true && waterlogged == false) {
                State = 15144;
            } else if(facing == Face.North && half == Half.Bottom && open == true && powered == false && waterlogged == true) {
                State = 15145;
            } else if(facing == Face.North && half == Half.Bottom && open == true && powered == false && waterlogged == false) {
                State = 15146;
            } else if(facing == Face.North && half == Half.Bottom && open == false && powered == true && waterlogged == true) {
                State = 15147;
            } else if(facing == Face.North && half == Half.Bottom && open == false && powered == true && waterlogged == false) {
                State = 15148;
            } else if(facing == Face.North && half == Half.Bottom && open == false && powered == false && waterlogged == true) {
                State = 15149;
            } else if(facing == Face.North && half == Half.Bottom && open == false && powered == false && waterlogged == false) {
                State = 15150;
            } else if(facing == Face.South && half == Half.Top && open == true && powered == true && waterlogged == true) {
                State = 15151;
            } else if(facing == Face.South && half == Half.Top && open == true && powered == true && waterlogged == false) {
                State = 15152;
            } else if(facing == Face.South && half == Half.Top && open == true && powered == false && waterlogged == true) {
                State = 15153;
            } else if(facing == Face.South && half == Half.Top && open == true && powered == false && waterlogged == false) {
                State = 15154;
            } else if(facing == Face.South && half == Half.Top && open == false && powered == true && waterlogged == true) {
                State = 15155;
            } else if(facing == Face.South && half == Half.Top && open == false && powered == true && waterlogged == false) {
                State = 15156;
            } else if(facing == Face.South && half == Half.Top && open == false && powered == false && waterlogged == true) {
                State = 15157;
            } else if(facing == Face.South && half == Half.Top && open == false && powered == false && waterlogged == false) {
                State = 15158;
            } else if(facing == Face.South && half == Half.Bottom && open == true && powered == true && waterlogged == true) {
                State = 15159;
            } else if(facing == Face.South && half == Half.Bottom && open == true && powered == true && waterlogged == false) {
                State = 15160;
            } else if(facing == Face.South && half == Half.Bottom && open == true && powered == false && waterlogged == true) {
                State = 15161;
            } else if(facing == Face.South && half == Half.Bottom && open == true && powered == false && waterlogged == false) {
                State = 15162;
            } else if(facing == Face.South && half == Half.Bottom && open == false && powered == true && waterlogged == true) {
                State = 15163;
            } else if(facing == Face.South && half == Half.Bottom && open == false && powered == true && waterlogged == false) {
                State = 15164;
            } else if(facing == Face.South && half == Half.Bottom && open == false && powered == false && waterlogged == true) {
                State = 15165;
            } else if(facing == Face.South && half == Half.Bottom && open == false && powered == false && waterlogged == false) {
                State = 15166;
            } else if(facing == Face.West && half == Half.Top && open == true && powered == true && waterlogged == true) {
                State = 15167;
            } else if(facing == Face.West && half == Half.Top && open == true && powered == true && waterlogged == false) {
                State = 15168;
            } else if(facing == Face.West && half == Half.Top && open == true && powered == false && waterlogged == true) {
                State = 15169;
            } else if(facing == Face.West && half == Half.Top && open == true && powered == false && waterlogged == false) {
                State = 15170;
            } else if(facing == Face.West && half == Half.Top && open == false && powered == true && waterlogged == true) {
                State = 15171;
            } else if(facing == Face.West && half == Half.Top && open == false && powered == true && waterlogged == false) {
                State = 15172;
            } else if(facing == Face.West && half == Half.Top && open == false && powered == false && waterlogged == true) {
                State = 15173;
            } else if(facing == Face.West && half == Half.Top && open == false && powered == false && waterlogged == false) {
                State = 15174;
            } else if(facing == Face.West && half == Half.Bottom && open == true && powered == true && waterlogged == true) {
                State = 15175;
            } else if(facing == Face.West && half == Half.Bottom && open == true && powered == true && waterlogged == false) {
                State = 15176;
            } else if(facing == Face.West && half == Half.Bottom && open == true && powered == false && waterlogged == true) {
                State = 15177;
            } else if(facing == Face.West && half == Half.Bottom && open == true && powered == false && waterlogged == false) {
                State = 15178;
            } else if(facing == Face.West && half == Half.Bottom && open == false && powered == true && waterlogged == true) {
                State = 15179;
            } else if(facing == Face.West && half == Half.Bottom && open == false && powered == true && waterlogged == false) {
                State = 15180;
            } else if(facing == Face.West && half == Half.Bottom && open == false && powered == false && waterlogged == true) {
                State = 15181;
            } else if(facing == Face.West && half == Half.Bottom && open == false && powered == false && waterlogged == false) {
                State = 15182;
            } else if(facing == Face.East && half == Half.Top && open == true && powered == true && waterlogged == true) {
                State = 15183;
            } else if(facing == Face.East && half == Half.Top && open == true && powered == true && waterlogged == false) {
                State = 15184;
            } else if(facing == Face.East && half == Half.Top && open == true && powered == false && waterlogged == true) {
                State = 15185;
            } else if(facing == Face.East && half == Half.Top && open == true && powered == false && waterlogged == false) {
                State = 15186;
            } else if(facing == Face.East && half == Half.Top && open == false && powered == true && waterlogged == true) {
                State = 15187;
            } else if(facing == Face.East && half == Half.Top && open == false && powered == true && waterlogged == false) {
                State = 15188;
            } else if(facing == Face.East && half == Half.Top && open == false && powered == false && waterlogged == true) {
                State = 15189;
            } else if(facing == Face.East && half == Half.Top && open == false && powered == false && waterlogged == false) {
                State = 15190;
            } else if(facing == Face.East && half == Half.Bottom && open == true && powered == true && waterlogged == true) {
                State = 15191;
            } else if(facing == Face.East && half == Half.Bottom && open == true && powered == true && waterlogged == false) {
                State = 15192;
            } else if(facing == Face.East && half == Half.Bottom && open == true && powered == false && waterlogged == true) {
                State = 15193;
            } else if(facing == Face.East && half == Half.Bottom && open == true && powered == false && waterlogged == false) {
                State = 15194;
            } else if(facing == Face.East && half == Half.Bottom && open == false && powered == true && waterlogged == true) {
                State = 15195;
            } else if(facing == Face.East && half == Half.Bottom && open == false && powered == true && waterlogged == false) {
                State = 15196;
            } else if(facing == Face.East && half == Half.Bottom && open == false && powered == false && waterlogged == true) {
                State = 15197;
            } else if(facing == Face.East && half == Half.Bottom && open == false && powered == false && waterlogged == false) {
                State = 15198;
            }
        }
    }
}