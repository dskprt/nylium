// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class RedNetherBrickStairsBlock : BaseBlock {

        public Face Facing { get; }
        public Half Half { get; }
        public Shape Shape { get; }
        public bool Waterlogged { get; }

        public RedNetherBrickStairsBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 638, 10564) { }

        public RedNetherBrickStairsBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z, 638, state) {
            if(state == 10553) {
                Facing = Face.North;
                Half = Half.Top;
                Shape = Shape.Straight;
                Waterlogged = true;
            } else if(state == 10554) {
                Facing = Face.North;
                Half = Half.Top;
                Shape = Shape.Straight;
                Waterlogged = false;
            } else if(state == 10555) {
                Facing = Face.North;
                Half = Half.Top;
                Shape = Shape.InnerLeft;
                Waterlogged = true;
            } else if(state == 10556) {
                Facing = Face.North;
                Half = Half.Top;
                Shape = Shape.InnerLeft;
                Waterlogged = false;
            } else if(state == 10557) {
                Facing = Face.North;
                Half = Half.Top;
                Shape = Shape.InnerRight;
                Waterlogged = true;
            } else if(state == 10558) {
                Facing = Face.North;
                Half = Half.Top;
                Shape = Shape.InnerRight;
                Waterlogged = false;
            } else if(state == 10559) {
                Facing = Face.North;
                Half = Half.Top;
                Shape = Shape.OuterLeft;
                Waterlogged = true;
            } else if(state == 10560) {
                Facing = Face.North;
                Half = Half.Top;
                Shape = Shape.OuterLeft;
                Waterlogged = false;
            } else if(state == 10561) {
                Facing = Face.North;
                Half = Half.Top;
                Shape = Shape.OuterRight;
                Waterlogged = true;
            } else if(state == 10562) {
                Facing = Face.North;
                Half = Half.Top;
                Shape = Shape.OuterRight;
                Waterlogged = false;
            } else if(state == 10563) {
                Facing = Face.North;
                Half = Half.Bottom;
                Shape = Shape.Straight;
                Waterlogged = true;
            } else if(state == 10564) {
                Facing = Face.North;
                Half = Half.Bottom;
                Shape = Shape.Straight;
                Waterlogged = false;
            } else if(state == 10565) {
                Facing = Face.North;
                Half = Half.Bottom;
                Shape = Shape.InnerLeft;
                Waterlogged = true;
            } else if(state == 10566) {
                Facing = Face.North;
                Half = Half.Bottom;
                Shape = Shape.InnerLeft;
                Waterlogged = false;
            } else if(state == 10567) {
                Facing = Face.North;
                Half = Half.Bottom;
                Shape = Shape.InnerRight;
                Waterlogged = true;
            } else if(state == 10568) {
                Facing = Face.North;
                Half = Half.Bottom;
                Shape = Shape.InnerRight;
                Waterlogged = false;
            } else if(state == 10569) {
                Facing = Face.North;
                Half = Half.Bottom;
                Shape = Shape.OuterLeft;
                Waterlogged = true;
            } else if(state == 10570) {
                Facing = Face.North;
                Half = Half.Bottom;
                Shape = Shape.OuterLeft;
                Waterlogged = false;
            } else if(state == 10571) {
                Facing = Face.North;
                Half = Half.Bottom;
                Shape = Shape.OuterRight;
                Waterlogged = true;
            } else if(state == 10572) {
                Facing = Face.North;
                Half = Half.Bottom;
                Shape = Shape.OuterRight;
                Waterlogged = false;
            } else if(state == 10573) {
                Facing = Face.South;
                Half = Half.Top;
                Shape = Shape.Straight;
                Waterlogged = true;
            } else if(state == 10574) {
                Facing = Face.South;
                Half = Half.Top;
                Shape = Shape.Straight;
                Waterlogged = false;
            } else if(state == 10575) {
                Facing = Face.South;
                Half = Half.Top;
                Shape = Shape.InnerLeft;
                Waterlogged = true;
            } else if(state == 10576) {
                Facing = Face.South;
                Half = Half.Top;
                Shape = Shape.InnerLeft;
                Waterlogged = false;
            } else if(state == 10577) {
                Facing = Face.South;
                Half = Half.Top;
                Shape = Shape.InnerRight;
                Waterlogged = true;
            } else if(state == 10578) {
                Facing = Face.South;
                Half = Half.Top;
                Shape = Shape.InnerRight;
                Waterlogged = false;
            } else if(state == 10579) {
                Facing = Face.South;
                Half = Half.Top;
                Shape = Shape.OuterLeft;
                Waterlogged = true;
            } else if(state == 10580) {
                Facing = Face.South;
                Half = Half.Top;
                Shape = Shape.OuterLeft;
                Waterlogged = false;
            } else if(state == 10581) {
                Facing = Face.South;
                Half = Half.Top;
                Shape = Shape.OuterRight;
                Waterlogged = true;
            } else if(state == 10582) {
                Facing = Face.South;
                Half = Half.Top;
                Shape = Shape.OuterRight;
                Waterlogged = false;
            } else if(state == 10583) {
                Facing = Face.South;
                Half = Half.Bottom;
                Shape = Shape.Straight;
                Waterlogged = true;
            } else if(state == 10584) {
                Facing = Face.South;
                Half = Half.Bottom;
                Shape = Shape.Straight;
                Waterlogged = false;
            } else if(state == 10585) {
                Facing = Face.South;
                Half = Half.Bottom;
                Shape = Shape.InnerLeft;
                Waterlogged = true;
            } else if(state == 10586) {
                Facing = Face.South;
                Half = Half.Bottom;
                Shape = Shape.InnerLeft;
                Waterlogged = false;
            } else if(state == 10587) {
                Facing = Face.South;
                Half = Half.Bottom;
                Shape = Shape.InnerRight;
                Waterlogged = true;
            } else if(state == 10588) {
                Facing = Face.South;
                Half = Half.Bottom;
                Shape = Shape.InnerRight;
                Waterlogged = false;
            } else if(state == 10589) {
                Facing = Face.South;
                Half = Half.Bottom;
                Shape = Shape.OuterLeft;
                Waterlogged = true;
            } else if(state == 10590) {
                Facing = Face.South;
                Half = Half.Bottom;
                Shape = Shape.OuterLeft;
                Waterlogged = false;
            } else if(state == 10591) {
                Facing = Face.South;
                Half = Half.Bottom;
                Shape = Shape.OuterRight;
                Waterlogged = true;
            } else if(state == 10592) {
                Facing = Face.South;
                Half = Half.Bottom;
                Shape = Shape.OuterRight;
                Waterlogged = false;
            } else if(state == 10593) {
                Facing = Face.West;
                Half = Half.Top;
                Shape = Shape.Straight;
                Waterlogged = true;
            } else if(state == 10594) {
                Facing = Face.West;
                Half = Half.Top;
                Shape = Shape.Straight;
                Waterlogged = false;
            } else if(state == 10595) {
                Facing = Face.West;
                Half = Half.Top;
                Shape = Shape.InnerLeft;
                Waterlogged = true;
            } else if(state == 10596) {
                Facing = Face.West;
                Half = Half.Top;
                Shape = Shape.InnerLeft;
                Waterlogged = false;
            } else if(state == 10597) {
                Facing = Face.West;
                Half = Half.Top;
                Shape = Shape.InnerRight;
                Waterlogged = true;
            } else if(state == 10598) {
                Facing = Face.West;
                Half = Half.Top;
                Shape = Shape.InnerRight;
                Waterlogged = false;
            } else if(state == 10599) {
                Facing = Face.West;
                Half = Half.Top;
                Shape = Shape.OuterLeft;
                Waterlogged = true;
            } else if(state == 10600) {
                Facing = Face.West;
                Half = Half.Top;
                Shape = Shape.OuterLeft;
                Waterlogged = false;
            } else if(state == 10601) {
                Facing = Face.West;
                Half = Half.Top;
                Shape = Shape.OuterRight;
                Waterlogged = true;
            } else if(state == 10602) {
                Facing = Face.West;
                Half = Half.Top;
                Shape = Shape.OuterRight;
                Waterlogged = false;
            } else if(state == 10603) {
                Facing = Face.West;
                Half = Half.Bottom;
                Shape = Shape.Straight;
                Waterlogged = true;
            } else if(state == 10604) {
                Facing = Face.West;
                Half = Half.Bottom;
                Shape = Shape.Straight;
                Waterlogged = false;
            } else if(state == 10605) {
                Facing = Face.West;
                Half = Half.Bottom;
                Shape = Shape.InnerLeft;
                Waterlogged = true;
            } else if(state == 10606) {
                Facing = Face.West;
                Half = Half.Bottom;
                Shape = Shape.InnerLeft;
                Waterlogged = false;
            } else if(state == 10607) {
                Facing = Face.West;
                Half = Half.Bottom;
                Shape = Shape.InnerRight;
                Waterlogged = true;
            } else if(state == 10608) {
                Facing = Face.West;
                Half = Half.Bottom;
                Shape = Shape.InnerRight;
                Waterlogged = false;
            } else if(state == 10609) {
                Facing = Face.West;
                Half = Half.Bottom;
                Shape = Shape.OuterLeft;
                Waterlogged = true;
            } else if(state == 10610) {
                Facing = Face.West;
                Half = Half.Bottom;
                Shape = Shape.OuterLeft;
                Waterlogged = false;
            } else if(state == 10611) {
                Facing = Face.West;
                Half = Half.Bottom;
                Shape = Shape.OuterRight;
                Waterlogged = true;
            } else if(state == 10612) {
                Facing = Face.West;
                Half = Half.Bottom;
                Shape = Shape.OuterRight;
                Waterlogged = false;
            } else if(state == 10613) {
                Facing = Face.East;
                Half = Half.Top;
                Shape = Shape.Straight;
                Waterlogged = true;
            } else if(state == 10614) {
                Facing = Face.East;
                Half = Half.Top;
                Shape = Shape.Straight;
                Waterlogged = false;
            } else if(state == 10615) {
                Facing = Face.East;
                Half = Half.Top;
                Shape = Shape.InnerLeft;
                Waterlogged = true;
            } else if(state == 10616) {
                Facing = Face.East;
                Half = Half.Top;
                Shape = Shape.InnerLeft;
                Waterlogged = false;
            } else if(state == 10617) {
                Facing = Face.East;
                Half = Half.Top;
                Shape = Shape.InnerRight;
                Waterlogged = true;
            } else if(state == 10618) {
                Facing = Face.East;
                Half = Half.Top;
                Shape = Shape.InnerRight;
                Waterlogged = false;
            } else if(state == 10619) {
                Facing = Face.East;
                Half = Half.Top;
                Shape = Shape.OuterLeft;
                Waterlogged = true;
            } else if(state == 10620) {
                Facing = Face.East;
                Half = Half.Top;
                Shape = Shape.OuterLeft;
                Waterlogged = false;
            } else if(state == 10621) {
                Facing = Face.East;
                Half = Half.Top;
                Shape = Shape.OuterRight;
                Waterlogged = true;
            } else if(state == 10622) {
                Facing = Face.East;
                Half = Half.Top;
                Shape = Shape.OuterRight;
                Waterlogged = false;
            } else if(state == 10623) {
                Facing = Face.East;
                Half = Half.Bottom;
                Shape = Shape.Straight;
                Waterlogged = true;
            } else if(state == 10624) {
                Facing = Face.East;
                Half = Half.Bottom;
                Shape = Shape.Straight;
                Waterlogged = false;
            } else if(state == 10625) {
                Facing = Face.East;
                Half = Half.Bottom;
                Shape = Shape.InnerLeft;
                Waterlogged = true;
            } else if(state == 10626) {
                Facing = Face.East;
                Half = Half.Bottom;
                Shape = Shape.InnerLeft;
                Waterlogged = false;
            } else if(state == 10627) {
                Facing = Face.East;
                Half = Half.Bottom;
                Shape = Shape.InnerRight;
                Waterlogged = true;
            } else if(state == 10628) {
                Facing = Face.East;
                Half = Half.Bottom;
                Shape = Shape.InnerRight;
                Waterlogged = false;
            } else if(state == 10629) {
                Facing = Face.East;
                Half = Half.Bottom;
                Shape = Shape.OuterLeft;
                Waterlogged = true;
            } else if(state == 10630) {
                Facing = Face.East;
                Half = Half.Bottom;
                Shape = Shape.OuterLeft;
                Waterlogged = false;
            } else if(state == 10631) {
                Facing = Face.East;
                Half = Half.Bottom;
                Shape = Shape.OuterRight;
                Waterlogged = true;
            } else if(state == 10632) {
                Facing = Face.East;
                Half = Half.Bottom;
                Shape = Shape.OuterRight;
                Waterlogged = false;
            }
        }

        public RedNetherBrickStairsBlock(Chunk chunk, int x, int y, int z, Face facing, Half half, Shape shape, bool waterlogged) : base(chunk, x, y, z, 638, 10564) {
if(facing == Face.North && half == Half.Top && shape == Shape.Straight && waterlogged == true) {
                State = 10553;
            } else if(facing == Face.North && half == Half.Top && shape == Shape.Straight && waterlogged == false) {
                State = 10554;
            } else if(facing == Face.North && half == Half.Top && shape == Shape.InnerLeft && waterlogged == true) {
                State = 10555;
            } else if(facing == Face.North && half == Half.Top && shape == Shape.InnerLeft && waterlogged == false) {
                State = 10556;
            } else if(facing == Face.North && half == Half.Top && shape == Shape.InnerRight && waterlogged == true) {
                State = 10557;
            } else if(facing == Face.North && half == Half.Top && shape == Shape.InnerRight && waterlogged == false) {
                State = 10558;
            } else if(facing == Face.North && half == Half.Top && shape == Shape.OuterLeft && waterlogged == true) {
                State = 10559;
            } else if(facing == Face.North && half == Half.Top && shape == Shape.OuterLeft && waterlogged == false) {
                State = 10560;
            } else if(facing == Face.North && half == Half.Top && shape == Shape.OuterRight && waterlogged == true) {
                State = 10561;
            } else if(facing == Face.North && half == Half.Top && shape == Shape.OuterRight && waterlogged == false) {
                State = 10562;
            } else if(facing == Face.North && half == Half.Bottom && shape == Shape.Straight && waterlogged == true) {
                State = 10563;
            } else if(facing == Face.North && half == Half.Bottom && shape == Shape.Straight && waterlogged == false) {
                State = 10564;
            } else if(facing == Face.North && half == Half.Bottom && shape == Shape.InnerLeft && waterlogged == true) {
                State = 10565;
            } else if(facing == Face.North && half == Half.Bottom && shape == Shape.InnerLeft && waterlogged == false) {
                State = 10566;
            } else if(facing == Face.North && half == Half.Bottom && shape == Shape.InnerRight && waterlogged == true) {
                State = 10567;
            } else if(facing == Face.North && half == Half.Bottom && shape == Shape.InnerRight && waterlogged == false) {
                State = 10568;
            } else if(facing == Face.North && half == Half.Bottom && shape == Shape.OuterLeft && waterlogged == true) {
                State = 10569;
            } else if(facing == Face.North && half == Half.Bottom && shape == Shape.OuterLeft && waterlogged == false) {
                State = 10570;
            } else if(facing == Face.North && half == Half.Bottom && shape == Shape.OuterRight && waterlogged == true) {
                State = 10571;
            } else if(facing == Face.North && half == Half.Bottom && shape == Shape.OuterRight && waterlogged == false) {
                State = 10572;
            } else if(facing == Face.South && half == Half.Top && shape == Shape.Straight && waterlogged == true) {
                State = 10573;
            } else if(facing == Face.South && half == Half.Top && shape == Shape.Straight && waterlogged == false) {
                State = 10574;
            } else if(facing == Face.South && half == Half.Top && shape == Shape.InnerLeft && waterlogged == true) {
                State = 10575;
            } else if(facing == Face.South && half == Half.Top && shape == Shape.InnerLeft && waterlogged == false) {
                State = 10576;
            } else if(facing == Face.South && half == Half.Top && shape == Shape.InnerRight && waterlogged == true) {
                State = 10577;
            } else if(facing == Face.South && half == Half.Top && shape == Shape.InnerRight && waterlogged == false) {
                State = 10578;
            } else if(facing == Face.South && half == Half.Top && shape == Shape.OuterLeft && waterlogged == true) {
                State = 10579;
            } else if(facing == Face.South && half == Half.Top && shape == Shape.OuterLeft && waterlogged == false) {
                State = 10580;
            } else if(facing == Face.South && half == Half.Top && shape == Shape.OuterRight && waterlogged == true) {
                State = 10581;
            } else if(facing == Face.South && half == Half.Top && shape == Shape.OuterRight && waterlogged == false) {
                State = 10582;
            } else if(facing == Face.South && half == Half.Bottom && shape == Shape.Straight && waterlogged == true) {
                State = 10583;
            } else if(facing == Face.South && half == Half.Bottom && shape == Shape.Straight && waterlogged == false) {
                State = 10584;
            } else if(facing == Face.South && half == Half.Bottom && shape == Shape.InnerLeft && waterlogged == true) {
                State = 10585;
            } else if(facing == Face.South && half == Half.Bottom && shape == Shape.InnerLeft && waterlogged == false) {
                State = 10586;
            } else if(facing == Face.South && half == Half.Bottom && shape == Shape.InnerRight && waterlogged == true) {
                State = 10587;
            } else if(facing == Face.South && half == Half.Bottom && shape == Shape.InnerRight && waterlogged == false) {
                State = 10588;
            } else if(facing == Face.South && half == Half.Bottom && shape == Shape.OuterLeft && waterlogged == true) {
                State = 10589;
            } else if(facing == Face.South && half == Half.Bottom && shape == Shape.OuterLeft && waterlogged == false) {
                State = 10590;
            } else if(facing == Face.South && half == Half.Bottom && shape == Shape.OuterRight && waterlogged == true) {
                State = 10591;
            } else if(facing == Face.South && half == Half.Bottom && shape == Shape.OuterRight && waterlogged == false) {
                State = 10592;
            } else if(facing == Face.West && half == Half.Top && shape == Shape.Straight && waterlogged == true) {
                State = 10593;
            } else if(facing == Face.West && half == Half.Top && shape == Shape.Straight && waterlogged == false) {
                State = 10594;
            } else if(facing == Face.West && half == Half.Top && shape == Shape.InnerLeft && waterlogged == true) {
                State = 10595;
            } else if(facing == Face.West && half == Half.Top && shape == Shape.InnerLeft && waterlogged == false) {
                State = 10596;
            } else if(facing == Face.West && half == Half.Top && shape == Shape.InnerRight && waterlogged == true) {
                State = 10597;
            } else if(facing == Face.West && half == Half.Top && shape == Shape.InnerRight && waterlogged == false) {
                State = 10598;
            } else if(facing == Face.West && half == Half.Top && shape == Shape.OuterLeft && waterlogged == true) {
                State = 10599;
            } else if(facing == Face.West && half == Half.Top && shape == Shape.OuterLeft && waterlogged == false) {
                State = 10600;
            } else if(facing == Face.West && half == Half.Top && shape == Shape.OuterRight && waterlogged == true) {
                State = 10601;
            } else if(facing == Face.West && half == Half.Top && shape == Shape.OuterRight && waterlogged == false) {
                State = 10602;
            } else if(facing == Face.West && half == Half.Bottom && shape == Shape.Straight && waterlogged == true) {
                State = 10603;
            } else if(facing == Face.West && half == Half.Bottom && shape == Shape.Straight && waterlogged == false) {
                State = 10604;
            } else if(facing == Face.West && half == Half.Bottom && shape == Shape.InnerLeft && waterlogged == true) {
                State = 10605;
            } else if(facing == Face.West && half == Half.Bottom && shape == Shape.InnerLeft && waterlogged == false) {
                State = 10606;
            } else if(facing == Face.West && half == Half.Bottom && shape == Shape.InnerRight && waterlogged == true) {
                State = 10607;
            } else if(facing == Face.West && half == Half.Bottom && shape == Shape.InnerRight && waterlogged == false) {
                State = 10608;
            } else if(facing == Face.West && half == Half.Bottom && shape == Shape.OuterLeft && waterlogged == true) {
                State = 10609;
            } else if(facing == Face.West && half == Half.Bottom && shape == Shape.OuterLeft && waterlogged == false) {
                State = 10610;
            } else if(facing == Face.West && half == Half.Bottom && shape == Shape.OuterRight && waterlogged == true) {
                State = 10611;
            } else if(facing == Face.West && half == Half.Bottom && shape == Shape.OuterRight && waterlogged == false) {
                State = 10612;
            } else if(facing == Face.East && half == Half.Top && shape == Shape.Straight && waterlogged == true) {
                State = 10613;
            } else if(facing == Face.East && half == Half.Top && shape == Shape.Straight && waterlogged == false) {
                State = 10614;
            } else if(facing == Face.East && half == Half.Top && shape == Shape.InnerLeft && waterlogged == true) {
                State = 10615;
            } else if(facing == Face.East && half == Half.Top && shape == Shape.InnerLeft && waterlogged == false) {
                State = 10616;
            } else if(facing == Face.East && half == Half.Top && shape == Shape.InnerRight && waterlogged == true) {
                State = 10617;
            } else if(facing == Face.East && half == Half.Top && shape == Shape.InnerRight && waterlogged == false) {
                State = 10618;
            } else if(facing == Face.East && half == Half.Top && shape == Shape.OuterLeft && waterlogged == true) {
                State = 10619;
            } else if(facing == Face.East && half == Half.Top && shape == Shape.OuterLeft && waterlogged == false) {
                State = 10620;
            } else if(facing == Face.East && half == Half.Top && shape == Shape.OuterRight && waterlogged == true) {
                State = 10621;
            } else if(facing == Face.East && half == Half.Top && shape == Shape.OuterRight && waterlogged == false) {
                State = 10622;
            } else if(facing == Face.East && half == Half.Bottom && shape == Shape.Straight && waterlogged == true) {
                State = 10623;
            } else if(facing == Face.East && half == Half.Bottom && shape == Shape.Straight && waterlogged == false) {
                State = 10624;
            } else if(facing == Face.East && half == Half.Bottom && shape == Shape.InnerLeft && waterlogged == true) {
                State = 10625;
            } else if(facing == Face.East && half == Half.Bottom && shape == Shape.InnerLeft && waterlogged == false) {
                State = 10626;
            } else if(facing == Face.East && half == Half.Bottom && shape == Shape.InnerRight && waterlogged == true) {
                State = 10627;
            } else if(facing == Face.East && half == Half.Bottom && shape == Shape.InnerRight && waterlogged == false) {
                State = 10628;
            } else if(facing == Face.East && half == Half.Bottom && shape == Shape.OuterLeft && waterlogged == true) {
                State = 10629;
            } else if(facing == Face.East && half == Half.Bottom && shape == Shape.OuterLeft && waterlogged == false) {
                State = 10630;
            } else if(facing == Face.East && half == Half.Bottom && shape == Shape.OuterRight && waterlogged == true) {
                State = 10631;
            } else if(facing == Face.East && half == Half.Bottom && shape == Shape.OuterRight && waterlogged == false) {
                State = 10632;
            }
        }
    }
}