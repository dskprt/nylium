// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class EndStoneBrickStairsBlock : BaseBlock {

        public Face Facing { get; }
        public Half Half { get; }
        public Shape Shape { get; }
        public bool Waterlogged { get; }

        public EndStoneBrickStairsBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 632, 10084) { }

        public EndStoneBrickStairsBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z, 632, state) {
            if(state == 10073) {
                Facing = Face.North;
                Half = Half.Top;
                Shape = Shape.Straight;
                Waterlogged = true;
            } else if(state == 10074) {
                Facing = Face.North;
                Half = Half.Top;
                Shape = Shape.Straight;
                Waterlogged = false;
            } else if(state == 10075) {
                Facing = Face.North;
                Half = Half.Top;
                Shape = Shape.InnerLeft;
                Waterlogged = true;
            } else if(state == 10076) {
                Facing = Face.North;
                Half = Half.Top;
                Shape = Shape.InnerLeft;
                Waterlogged = false;
            } else if(state == 10077) {
                Facing = Face.North;
                Half = Half.Top;
                Shape = Shape.InnerRight;
                Waterlogged = true;
            } else if(state == 10078) {
                Facing = Face.North;
                Half = Half.Top;
                Shape = Shape.InnerRight;
                Waterlogged = false;
            } else if(state == 10079) {
                Facing = Face.North;
                Half = Half.Top;
                Shape = Shape.OuterLeft;
                Waterlogged = true;
            } else if(state == 10080) {
                Facing = Face.North;
                Half = Half.Top;
                Shape = Shape.OuterLeft;
                Waterlogged = false;
            } else if(state == 10081) {
                Facing = Face.North;
                Half = Half.Top;
                Shape = Shape.OuterRight;
                Waterlogged = true;
            } else if(state == 10082) {
                Facing = Face.North;
                Half = Half.Top;
                Shape = Shape.OuterRight;
                Waterlogged = false;
            } else if(state == 10083) {
                Facing = Face.North;
                Half = Half.Bottom;
                Shape = Shape.Straight;
                Waterlogged = true;
            } else if(state == 10084) {
                Facing = Face.North;
                Half = Half.Bottom;
                Shape = Shape.Straight;
                Waterlogged = false;
            } else if(state == 10085) {
                Facing = Face.North;
                Half = Half.Bottom;
                Shape = Shape.InnerLeft;
                Waterlogged = true;
            } else if(state == 10086) {
                Facing = Face.North;
                Half = Half.Bottom;
                Shape = Shape.InnerLeft;
                Waterlogged = false;
            } else if(state == 10087) {
                Facing = Face.North;
                Half = Half.Bottom;
                Shape = Shape.InnerRight;
                Waterlogged = true;
            } else if(state == 10088) {
                Facing = Face.North;
                Half = Half.Bottom;
                Shape = Shape.InnerRight;
                Waterlogged = false;
            } else if(state == 10089) {
                Facing = Face.North;
                Half = Half.Bottom;
                Shape = Shape.OuterLeft;
                Waterlogged = true;
            } else if(state == 10090) {
                Facing = Face.North;
                Half = Half.Bottom;
                Shape = Shape.OuterLeft;
                Waterlogged = false;
            } else if(state == 10091) {
                Facing = Face.North;
                Half = Half.Bottom;
                Shape = Shape.OuterRight;
                Waterlogged = true;
            } else if(state == 10092) {
                Facing = Face.North;
                Half = Half.Bottom;
                Shape = Shape.OuterRight;
                Waterlogged = false;
            } else if(state == 10093) {
                Facing = Face.South;
                Half = Half.Top;
                Shape = Shape.Straight;
                Waterlogged = true;
            } else if(state == 10094) {
                Facing = Face.South;
                Half = Half.Top;
                Shape = Shape.Straight;
                Waterlogged = false;
            } else if(state == 10095) {
                Facing = Face.South;
                Half = Half.Top;
                Shape = Shape.InnerLeft;
                Waterlogged = true;
            } else if(state == 10096) {
                Facing = Face.South;
                Half = Half.Top;
                Shape = Shape.InnerLeft;
                Waterlogged = false;
            } else if(state == 10097) {
                Facing = Face.South;
                Half = Half.Top;
                Shape = Shape.InnerRight;
                Waterlogged = true;
            } else if(state == 10098) {
                Facing = Face.South;
                Half = Half.Top;
                Shape = Shape.InnerRight;
                Waterlogged = false;
            } else if(state == 10099) {
                Facing = Face.South;
                Half = Half.Top;
                Shape = Shape.OuterLeft;
                Waterlogged = true;
            } else if(state == 10100) {
                Facing = Face.South;
                Half = Half.Top;
                Shape = Shape.OuterLeft;
                Waterlogged = false;
            } else if(state == 10101) {
                Facing = Face.South;
                Half = Half.Top;
                Shape = Shape.OuterRight;
                Waterlogged = true;
            } else if(state == 10102) {
                Facing = Face.South;
                Half = Half.Top;
                Shape = Shape.OuterRight;
                Waterlogged = false;
            } else if(state == 10103) {
                Facing = Face.South;
                Half = Half.Bottom;
                Shape = Shape.Straight;
                Waterlogged = true;
            } else if(state == 10104) {
                Facing = Face.South;
                Half = Half.Bottom;
                Shape = Shape.Straight;
                Waterlogged = false;
            } else if(state == 10105) {
                Facing = Face.South;
                Half = Half.Bottom;
                Shape = Shape.InnerLeft;
                Waterlogged = true;
            } else if(state == 10106) {
                Facing = Face.South;
                Half = Half.Bottom;
                Shape = Shape.InnerLeft;
                Waterlogged = false;
            } else if(state == 10107) {
                Facing = Face.South;
                Half = Half.Bottom;
                Shape = Shape.InnerRight;
                Waterlogged = true;
            } else if(state == 10108) {
                Facing = Face.South;
                Half = Half.Bottom;
                Shape = Shape.InnerRight;
                Waterlogged = false;
            } else if(state == 10109) {
                Facing = Face.South;
                Half = Half.Bottom;
                Shape = Shape.OuterLeft;
                Waterlogged = true;
            } else if(state == 10110) {
                Facing = Face.South;
                Half = Half.Bottom;
                Shape = Shape.OuterLeft;
                Waterlogged = false;
            } else if(state == 10111) {
                Facing = Face.South;
                Half = Half.Bottom;
                Shape = Shape.OuterRight;
                Waterlogged = true;
            } else if(state == 10112) {
                Facing = Face.South;
                Half = Half.Bottom;
                Shape = Shape.OuterRight;
                Waterlogged = false;
            } else if(state == 10113) {
                Facing = Face.West;
                Half = Half.Top;
                Shape = Shape.Straight;
                Waterlogged = true;
            } else if(state == 10114) {
                Facing = Face.West;
                Half = Half.Top;
                Shape = Shape.Straight;
                Waterlogged = false;
            } else if(state == 10115) {
                Facing = Face.West;
                Half = Half.Top;
                Shape = Shape.InnerLeft;
                Waterlogged = true;
            } else if(state == 10116) {
                Facing = Face.West;
                Half = Half.Top;
                Shape = Shape.InnerLeft;
                Waterlogged = false;
            } else if(state == 10117) {
                Facing = Face.West;
                Half = Half.Top;
                Shape = Shape.InnerRight;
                Waterlogged = true;
            } else if(state == 10118) {
                Facing = Face.West;
                Half = Half.Top;
                Shape = Shape.InnerRight;
                Waterlogged = false;
            } else if(state == 10119) {
                Facing = Face.West;
                Half = Half.Top;
                Shape = Shape.OuterLeft;
                Waterlogged = true;
            } else if(state == 10120) {
                Facing = Face.West;
                Half = Half.Top;
                Shape = Shape.OuterLeft;
                Waterlogged = false;
            } else if(state == 10121) {
                Facing = Face.West;
                Half = Half.Top;
                Shape = Shape.OuterRight;
                Waterlogged = true;
            } else if(state == 10122) {
                Facing = Face.West;
                Half = Half.Top;
                Shape = Shape.OuterRight;
                Waterlogged = false;
            } else if(state == 10123) {
                Facing = Face.West;
                Half = Half.Bottom;
                Shape = Shape.Straight;
                Waterlogged = true;
            } else if(state == 10124) {
                Facing = Face.West;
                Half = Half.Bottom;
                Shape = Shape.Straight;
                Waterlogged = false;
            } else if(state == 10125) {
                Facing = Face.West;
                Half = Half.Bottom;
                Shape = Shape.InnerLeft;
                Waterlogged = true;
            } else if(state == 10126) {
                Facing = Face.West;
                Half = Half.Bottom;
                Shape = Shape.InnerLeft;
                Waterlogged = false;
            } else if(state == 10127) {
                Facing = Face.West;
                Half = Half.Bottom;
                Shape = Shape.InnerRight;
                Waterlogged = true;
            } else if(state == 10128) {
                Facing = Face.West;
                Half = Half.Bottom;
                Shape = Shape.InnerRight;
                Waterlogged = false;
            } else if(state == 10129) {
                Facing = Face.West;
                Half = Half.Bottom;
                Shape = Shape.OuterLeft;
                Waterlogged = true;
            } else if(state == 10130) {
                Facing = Face.West;
                Half = Half.Bottom;
                Shape = Shape.OuterLeft;
                Waterlogged = false;
            } else if(state == 10131) {
                Facing = Face.West;
                Half = Half.Bottom;
                Shape = Shape.OuterRight;
                Waterlogged = true;
            } else if(state == 10132) {
                Facing = Face.West;
                Half = Half.Bottom;
                Shape = Shape.OuterRight;
                Waterlogged = false;
            } else if(state == 10133) {
                Facing = Face.East;
                Half = Half.Top;
                Shape = Shape.Straight;
                Waterlogged = true;
            } else if(state == 10134) {
                Facing = Face.East;
                Half = Half.Top;
                Shape = Shape.Straight;
                Waterlogged = false;
            } else if(state == 10135) {
                Facing = Face.East;
                Half = Half.Top;
                Shape = Shape.InnerLeft;
                Waterlogged = true;
            } else if(state == 10136) {
                Facing = Face.East;
                Half = Half.Top;
                Shape = Shape.InnerLeft;
                Waterlogged = false;
            } else if(state == 10137) {
                Facing = Face.East;
                Half = Half.Top;
                Shape = Shape.InnerRight;
                Waterlogged = true;
            } else if(state == 10138) {
                Facing = Face.East;
                Half = Half.Top;
                Shape = Shape.InnerRight;
                Waterlogged = false;
            } else if(state == 10139) {
                Facing = Face.East;
                Half = Half.Top;
                Shape = Shape.OuterLeft;
                Waterlogged = true;
            } else if(state == 10140) {
                Facing = Face.East;
                Half = Half.Top;
                Shape = Shape.OuterLeft;
                Waterlogged = false;
            } else if(state == 10141) {
                Facing = Face.East;
                Half = Half.Top;
                Shape = Shape.OuterRight;
                Waterlogged = true;
            } else if(state == 10142) {
                Facing = Face.East;
                Half = Half.Top;
                Shape = Shape.OuterRight;
                Waterlogged = false;
            } else if(state == 10143) {
                Facing = Face.East;
                Half = Half.Bottom;
                Shape = Shape.Straight;
                Waterlogged = true;
            } else if(state == 10144) {
                Facing = Face.East;
                Half = Half.Bottom;
                Shape = Shape.Straight;
                Waterlogged = false;
            } else if(state == 10145) {
                Facing = Face.East;
                Half = Half.Bottom;
                Shape = Shape.InnerLeft;
                Waterlogged = true;
            } else if(state == 10146) {
                Facing = Face.East;
                Half = Half.Bottom;
                Shape = Shape.InnerLeft;
                Waterlogged = false;
            } else if(state == 10147) {
                Facing = Face.East;
                Half = Half.Bottom;
                Shape = Shape.InnerRight;
                Waterlogged = true;
            } else if(state == 10148) {
                Facing = Face.East;
                Half = Half.Bottom;
                Shape = Shape.InnerRight;
                Waterlogged = false;
            } else if(state == 10149) {
                Facing = Face.East;
                Half = Half.Bottom;
                Shape = Shape.OuterLeft;
                Waterlogged = true;
            } else if(state == 10150) {
                Facing = Face.East;
                Half = Half.Bottom;
                Shape = Shape.OuterLeft;
                Waterlogged = false;
            } else if(state == 10151) {
                Facing = Face.East;
                Half = Half.Bottom;
                Shape = Shape.OuterRight;
                Waterlogged = true;
            } else if(state == 10152) {
                Facing = Face.East;
                Half = Half.Bottom;
                Shape = Shape.OuterRight;
                Waterlogged = false;
            }
        }

        public EndStoneBrickStairsBlock(Chunk chunk, int x, int y, int z, Face facing, Half half, Shape shape, bool waterlogged) : base(chunk, x, y, z, 632, 10084) {
if(facing == Face.North && half == Half.Top && shape == Shape.Straight && waterlogged == true) {
                State = 10073;
            } else if(facing == Face.North && half == Half.Top && shape == Shape.Straight && waterlogged == false) {
                State = 10074;
            } else if(facing == Face.North && half == Half.Top && shape == Shape.InnerLeft && waterlogged == true) {
                State = 10075;
            } else if(facing == Face.North && half == Half.Top && shape == Shape.InnerLeft && waterlogged == false) {
                State = 10076;
            } else if(facing == Face.North && half == Half.Top && shape == Shape.InnerRight && waterlogged == true) {
                State = 10077;
            } else if(facing == Face.North && half == Half.Top && shape == Shape.InnerRight && waterlogged == false) {
                State = 10078;
            } else if(facing == Face.North && half == Half.Top && shape == Shape.OuterLeft && waterlogged == true) {
                State = 10079;
            } else if(facing == Face.North && half == Half.Top && shape == Shape.OuterLeft && waterlogged == false) {
                State = 10080;
            } else if(facing == Face.North && half == Half.Top && shape == Shape.OuterRight && waterlogged == true) {
                State = 10081;
            } else if(facing == Face.North && half == Half.Top && shape == Shape.OuterRight && waterlogged == false) {
                State = 10082;
            } else if(facing == Face.North && half == Half.Bottom && shape == Shape.Straight && waterlogged == true) {
                State = 10083;
            } else if(facing == Face.North && half == Half.Bottom && shape == Shape.Straight && waterlogged == false) {
                State = 10084;
            } else if(facing == Face.North && half == Half.Bottom && shape == Shape.InnerLeft && waterlogged == true) {
                State = 10085;
            } else if(facing == Face.North && half == Half.Bottom && shape == Shape.InnerLeft && waterlogged == false) {
                State = 10086;
            } else if(facing == Face.North && half == Half.Bottom && shape == Shape.InnerRight && waterlogged == true) {
                State = 10087;
            } else if(facing == Face.North && half == Half.Bottom && shape == Shape.InnerRight && waterlogged == false) {
                State = 10088;
            } else if(facing == Face.North && half == Half.Bottom && shape == Shape.OuterLeft && waterlogged == true) {
                State = 10089;
            } else if(facing == Face.North && half == Half.Bottom && shape == Shape.OuterLeft && waterlogged == false) {
                State = 10090;
            } else if(facing == Face.North && half == Half.Bottom && shape == Shape.OuterRight && waterlogged == true) {
                State = 10091;
            } else if(facing == Face.North && half == Half.Bottom && shape == Shape.OuterRight && waterlogged == false) {
                State = 10092;
            } else if(facing == Face.South && half == Half.Top && shape == Shape.Straight && waterlogged == true) {
                State = 10093;
            } else if(facing == Face.South && half == Half.Top && shape == Shape.Straight && waterlogged == false) {
                State = 10094;
            } else if(facing == Face.South && half == Half.Top && shape == Shape.InnerLeft && waterlogged == true) {
                State = 10095;
            } else if(facing == Face.South && half == Half.Top && shape == Shape.InnerLeft && waterlogged == false) {
                State = 10096;
            } else if(facing == Face.South && half == Half.Top && shape == Shape.InnerRight && waterlogged == true) {
                State = 10097;
            } else if(facing == Face.South && half == Half.Top && shape == Shape.InnerRight && waterlogged == false) {
                State = 10098;
            } else if(facing == Face.South && half == Half.Top && shape == Shape.OuterLeft && waterlogged == true) {
                State = 10099;
            } else if(facing == Face.South && half == Half.Top && shape == Shape.OuterLeft && waterlogged == false) {
                State = 10100;
            } else if(facing == Face.South && half == Half.Top && shape == Shape.OuterRight && waterlogged == true) {
                State = 10101;
            } else if(facing == Face.South && half == Half.Top && shape == Shape.OuterRight && waterlogged == false) {
                State = 10102;
            } else if(facing == Face.South && half == Half.Bottom && shape == Shape.Straight && waterlogged == true) {
                State = 10103;
            } else if(facing == Face.South && half == Half.Bottom && shape == Shape.Straight && waterlogged == false) {
                State = 10104;
            } else if(facing == Face.South && half == Half.Bottom && shape == Shape.InnerLeft && waterlogged == true) {
                State = 10105;
            } else if(facing == Face.South && half == Half.Bottom && shape == Shape.InnerLeft && waterlogged == false) {
                State = 10106;
            } else if(facing == Face.South && half == Half.Bottom && shape == Shape.InnerRight && waterlogged == true) {
                State = 10107;
            } else if(facing == Face.South && half == Half.Bottom && shape == Shape.InnerRight && waterlogged == false) {
                State = 10108;
            } else if(facing == Face.South && half == Half.Bottom && shape == Shape.OuterLeft && waterlogged == true) {
                State = 10109;
            } else if(facing == Face.South && half == Half.Bottom && shape == Shape.OuterLeft && waterlogged == false) {
                State = 10110;
            } else if(facing == Face.South && half == Half.Bottom && shape == Shape.OuterRight && waterlogged == true) {
                State = 10111;
            } else if(facing == Face.South && half == Half.Bottom && shape == Shape.OuterRight && waterlogged == false) {
                State = 10112;
            } else if(facing == Face.West && half == Half.Top && shape == Shape.Straight && waterlogged == true) {
                State = 10113;
            } else if(facing == Face.West && half == Half.Top && shape == Shape.Straight && waterlogged == false) {
                State = 10114;
            } else if(facing == Face.West && half == Half.Top && shape == Shape.InnerLeft && waterlogged == true) {
                State = 10115;
            } else if(facing == Face.West && half == Half.Top && shape == Shape.InnerLeft && waterlogged == false) {
                State = 10116;
            } else if(facing == Face.West && half == Half.Top && shape == Shape.InnerRight && waterlogged == true) {
                State = 10117;
            } else if(facing == Face.West && half == Half.Top && shape == Shape.InnerRight && waterlogged == false) {
                State = 10118;
            } else if(facing == Face.West && half == Half.Top && shape == Shape.OuterLeft && waterlogged == true) {
                State = 10119;
            } else if(facing == Face.West && half == Half.Top && shape == Shape.OuterLeft && waterlogged == false) {
                State = 10120;
            } else if(facing == Face.West && half == Half.Top && shape == Shape.OuterRight && waterlogged == true) {
                State = 10121;
            } else if(facing == Face.West && half == Half.Top && shape == Shape.OuterRight && waterlogged == false) {
                State = 10122;
            } else if(facing == Face.West && half == Half.Bottom && shape == Shape.Straight && waterlogged == true) {
                State = 10123;
            } else if(facing == Face.West && half == Half.Bottom && shape == Shape.Straight && waterlogged == false) {
                State = 10124;
            } else if(facing == Face.West && half == Half.Bottom && shape == Shape.InnerLeft && waterlogged == true) {
                State = 10125;
            } else if(facing == Face.West && half == Half.Bottom && shape == Shape.InnerLeft && waterlogged == false) {
                State = 10126;
            } else if(facing == Face.West && half == Half.Bottom && shape == Shape.InnerRight && waterlogged == true) {
                State = 10127;
            } else if(facing == Face.West && half == Half.Bottom && shape == Shape.InnerRight && waterlogged == false) {
                State = 10128;
            } else if(facing == Face.West && half == Half.Bottom && shape == Shape.OuterLeft && waterlogged == true) {
                State = 10129;
            } else if(facing == Face.West && half == Half.Bottom && shape == Shape.OuterLeft && waterlogged == false) {
                State = 10130;
            } else if(facing == Face.West && half == Half.Bottom && shape == Shape.OuterRight && waterlogged == true) {
                State = 10131;
            } else if(facing == Face.West && half == Half.Bottom && shape == Shape.OuterRight && waterlogged == false) {
                State = 10132;
            } else if(facing == Face.East && half == Half.Top && shape == Shape.Straight && waterlogged == true) {
                State = 10133;
            } else if(facing == Face.East && half == Half.Top && shape == Shape.Straight && waterlogged == false) {
                State = 10134;
            } else if(facing == Face.East && half == Half.Top && shape == Shape.InnerLeft && waterlogged == true) {
                State = 10135;
            } else if(facing == Face.East && half == Half.Top && shape == Shape.InnerLeft && waterlogged == false) {
                State = 10136;
            } else if(facing == Face.East && half == Half.Top && shape == Shape.InnerRight && waterlogged == true) {
                State = 10137;
            } else if(facing == Face.East && half == Half.Top && shape == Shape.InnerRight && waterlogged == false) {
                State = 10138;
            } else if(facing == Face.East && half == Half.Top && shape == Shape.OuterLeft && waterlogged == true) {
                State = 10139;
            } else if(facing == Face.East && half == Half.Top && shape == Shape.OuterLeft && waterlogged == false) {
                State = 10140;
            } else if(facing == Face.East && half == Half.Top && shape == Shape.OuterRight && waterlogged == true) {
                State = 10141;
            } else if(facing == Face.East && half == Half.Top && shape == Shape.OuterRight && waterlogged == false) {
                State = 10142;
            } else if(facing == Face.East && half == Half.Bottom && shape == Shape.Straight && waterlogged == true) {
                State = 10143;
            } else if(facing == Face.East && half == Half.Bottom && shape == Shape.Straight && waterlogged == false) {
                State = 10144;
            } else if(facing == Face.East && half == Half.Bottom && shape == Shape.InnerLeft && waterlogged == true) {
                State = 10145;
            } else if(facing == Face.East && half == Half.Bottom && shape == Shape.InnerLeft && waterlogged == false) {
                State = 10146;
            } else if(facing == Face.East && half == Half.Bottom && shape == Shape.InnerRight && waterlogged == true) {
                State = 10147;
            } else if(facing == Face.East && half == Half.Bottom && shape == Shape.InnerRight && waterlogged == false) {
                State = 10148;
            } else if(facing == Face.East && half == Half.Bottom && shape == Shape.OuterLeft && waterlogged == true) {
                State = 10149;
            } else if(facing == Face.East && half == Half.Bottom && shape == Shape.OuterLeft && waterlogged == false) {
                State = 10150;
            } else if(facing == Face.East && half == Half.Bottom && shape == Shape.OuterRight && waterlogged == true) {
                State = 10151;
            } else if(facing == Face.East && half == Half.Bottom && shape == Shape.OuterRight && waterlogged == false) {
                State = 10152;
            }
        }
    }
}