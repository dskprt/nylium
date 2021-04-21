// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class CrimsonDoorBlock : BaseBlock {

        public Face Facing { get; }
        public Half Half { get; }
        public HingeType Hinge { get; }
        public bool Open { get; }
        public bool Powered { get; }

        public CrimsonDoorBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 720, 15546) { }

        public CrimsonDoorBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z, 720, state) {if(state == 15535) {
                Facing = Face.North;
                Half = Half.Upper;
                Hinge = HingeType.Left;
                Open = true;
                Powered = true;
            } else if(state == 15536) {
                Facing = Face.North;
                Half = Half.Upper;
                Hinge = HingeType.Left;
                Open = true;
                Powered = false;
            } else if(state == 15537) {
                Facing = Face.North;
                Half = Half.Upper;
                Hinge = HingeType.Left;
                Open = false;
                Powered = true;
            } else if(state == 15538) {
                Facing = Face.North;
                Half = Half.Upper;
                Hinge = HingeType.Left;
                Open = false;
                Powered = false;
            } else if(state == 15539) {
                Facing = Face.North;
                Half = Half.Upper;
                Hinge = HingeType.Right;
                Open = true;
                Powered = true;
            } else if(state == 15540) {
                Facing = Face.North;
                Half = Half.Upper;
                Hinge = HingeType.Right;
                Open = true;
                Powered = false;
            } else if(state == 15541) {
                Facing = Face.North;
                Half = Half.Upper;
                Hinge = HingeType.Right;
                Open = false;
                Powered = true;
            } else if(state == 15542) {
                Facing = Face.North;
                Half = Half.Upper;
                Hinge = HingeType.Right;
                Open = false;
                Powered = false;
            } else if(state == 15543) {
                Facing = Face.North;
                Half = Half.Lower;
                Hinge = HingeType.Left;
                Open = true;
                Powered = true;
            } else if(state == 15544) {
                Facing = Face.North;
                Half = Half.Lower;
                Hinge = HingeType.Left;
                Open = true;
                Powered = false;
            } else if(state == 15545) {
                Facing = Face.North;
                Half = Half.Lower;
                Hinge = HingeType.Left;
                Open = false;
                Powered = true;
            } else if(state == 15546) {
                Facing = Face.North;
                Half = Half.Lower;
                Hinge = HingeType.Left;
                Open = false;
                Powered = false;
            } else if(state == 15547) {
                Facing = Face.North;
                Half = Half.Lower;
                Hinge = HingeType.Right;
                Open = true;
                Powered = true;
            } else if(state == 15548) {
                Facing = Face.North;
                Half = Half.Lower;
                Hinge = HingeType.Right;
                Open = true;
                Powered = false;
            } else if(state == 15549) {
                Facing = Face.North;
                Half = Half.Lower;
                Hinge = HingeType.Right;
                Open = false;
                Powered = true;
            } else if(state == 15550) {
                Facing = Face.North;
                Half = Half.Lower;
                Hinge = HingeType.Right;
                Open = false;
                Powered = false;
            } else if(state == 15551) {
                Facing = Face.South;
                Half = Half.Upper;
                Hinge = HingeType.Left;
                Open = true;
                Powered = true;
            } else if(state == 15552) {
                Facing = Face.South;
                Half = Half.Upper;
                Hinge = HingeType.Left;
                Open = true;
                Powered = false;
            } else if(state == 15553) {
                Facing = Face.South;
                Half = Half.Upper;
                Hinge = HingeType.Left;
                Open = false;
                Powered = true;
            } else if(state == 15554) {
                Facing = Face.South;
                Half = Half.Upper;
                Hinge = HingeType.Left;
                Open = false;
                Powered = false;
            } else if(state == 15555) {
                Facing = Face.South;
                Half = Half.Upper;
                Hinge = HingeType.Right;
                Open = true;
                Powered = true;
            } else if(state == 15556) {
                Facing = Face.South;
                Half = Half.Upper;
                Hinge = HingeType.Right;
                Open = true;
                Powered = false;
            } else if(state == 15557) {
                Facing = Face.South;
                Half = Half.Upper;
                Hinge = HingeType.Right;
                Open = false;
                Powered = true;
            } else if(state == 15558) {
                Facing = Face.South;
                Half = Half.Upper;
                Hinge = HingeType.Right;
                Open = false;
                Powered = false;
            } else if(state == 15559) {
                Facing = Face.South;
                Half = Half.Lower;
                Hinge = HingeType.Left;
                Open = true;
                Powered = true;
            } else if(state == 15560) {
                Facing = Face.South;
                Half = Half.Lower;
                Hinge = HingeType.Left;
                Open = true;
                Powered = false;
            } else if(state == 15561) {
                Facing = Face.South;
                Half = Half.Lower;
                Hinge = HingeType.Left;
                Open = false;
                Powered = true;
            } else if(state == 15562) {
                Facing = Face.South;
                Half = Half.Lower;
                Hinge = HingeType.Left;
                Open = false;
                Powered = false;
            } else if(state == 15563) {
                Facing = Face.South;
                Half = Half.Lower;
                Hinge = HingeType.Right;
                Open = true;
                Powered = true;
            } else if(state == 15564) {
                Facing = Face.South;
                Half = Half.Lower;
                Hinge = HingeType.Right;
                Open = true;
                Powered = false;
            } else if(state == 15565) {
                Facing = Face.South;
                Half = Half.Lower;
                Hinge = HingeType.Right;
                Open = false;
                Powered = true;
            } else if(state == 15566) {
                Facing = Face.South;
                Half = Half.Lower;
                Hinge = HingeType.Right;
                Open = false;
                Powered = false;
            } else if(state == 15567) {
                Facing = Face.West;
                Half = Half.Upper;
                Hinge = HingeType.Left;
                Open = true;
                Powered = true;
            } else if(state == 15568) {
                Facing = Face.West;
                Half = Half.Upper;
                Hinge = HingeType.Left;
                Open = true;
                Powered = false;
            } else if(state == 15569) {
                Facing = Face.West;
                Half = Half.Upper;
                Hinge = HingeType.Left;
                Open = false;
                Powered = true;
            } else if(state == 15570) {
                Facing = Face.West;
                Half = Half.Upper;
                Hinge = HingeType.Left;
                Open = false;
                Powered = false;
            } else if(state == 15571) {
                Facing = Face.West;
                Half = Half.Upper;
                Hinge = HingeType.Right;
                Open = true;
                Powered = true;
            } else if(state == 15572) {
                Facing = Face.West;
                Half = Half.Upper;
                Hinge = HingeType.Right;
                Open = true;
                Powered = false;
            } else if(state == 15573) {
                Facing = Face.West;
                Half = Half.Upper;
                Hinge = HingeType.Right;
                Open = false;
                Powered = true;
            } else if(state == 15574) {
                Facing = Face.West;
                Half = Half.Upper;
                Hinge = HingeType.Right;
                Open = false;
                Powered = false;
            } else if(state == 15575) {
                Facing = Face.West;
                Half = Half.Lower;
                Hinge = HingeType.Left;
                Open = true;
                Powered = true;
            } else if(state == 15576) {
                Facing = Face.West;
                Half = Half.Lower;
                Hinge = HingeType.Left;
                Open = true;
                Powered = false;
            } else if(state == 15577) {
                Facing = Face.West;
                Half = Half.Lower;
                Hinge = HingeType.Left;
                Open = false;
                Powered = true;
            } else if(state == 15578) {
                Facing = Face.West;
                Half = Half.Lower;
                Hinge = HingeType.Left;
                Open = false;
                Powered = false;
            } else if(state == 15579) {
                Facing = Face.West;
                Half = Half.Lower;
                Hinge = HingeType.Right;
                Open = true;
                Powered = true;
            } else if(state == 15580) {
                Facing = Face.West;
                Half = Half.Lower;
                Hinge = HingeType.Right;
                Open = true;
                Powered = false;
            } else if(state == 15581) {
                Facing = Face.West;
                Half = Half.Lower;
                Hinge = HingeType.Right;
                Open = false;
                Powered = true;
            } else if(state == 15582) {
                Facing = Face.West;
                Half = Half.Lower;
                Hinge = HingeType.Right;
                Open = false;
                Powered = false;
            } else if(state == 15583) {
                Facing = Face.East;
                Half = Half.Upper;
                Hinge = HingeType.Left;
                Open = true;
                Powered = true;
            } else if(state == 15584) {
                Facing = Face.East;
                Half = Half.Upper;
                Hinge = HingeType.Left;
                Open = true;
                Powered = false;
            } else if(state == 15585) {
                Facing = Face.East;
                Half = Half.Upper;
                Hinge = HingeType.Left;
                Open = false;
                Powered = true;
            } else if(state == 15586) {
                Facing = Face.East;
                Half = Half.Upper;
                Hinge = HingeType.Left;
                Open = false;
                Powered = false;
            } else if(state == 15587) {
                Facing = Face.East;
                Half = Half.Upper;
                Hinge = HingeType.Right;
                Open = true;
                Powered = true;
            } else if(state == 15588) {
                Facing = Face.East;
                Half = Half.Upper;
                Hinge = HingeType.Right;
                Open = true;
                Powered = false;
            } else if(state == 15589) {
                Facing = Face.East;
                Half = Half.Upper;
                Hinge = HingeType.Right;
                Open = false;
                Powered = true;
            } else if(state == 15590) {
                Facing = Face.East;
                Half = Half.Upper;
                Hinge = HingeType.Right;
                Open = false;
                Powered = false;
            } else if(state == 15591) {
                Facing = Face.East;
                Half = Half.Lower;
                Hinge = HingeType.Left;
                Open = true;
                Powered = true;
            } else if(state == 15592) {
                Facing = Face.East;
                Half = Half.Lower;
                Hinge = HingeType.Left;
                Open = true;
                Powered = false;
            } else if(state == 15593) {
                Facing = Face.East;
                Half = Half.Lower;
                Hinge = HingeType.Left;
                Open = false;
                Powered = true;
            } else if(state == 15594) {
                Facing = Face.East;
                Half = Half.Lower;
                Hinge = HingeType.Left;
                Open = false;
                Powered = false;
            } else if(state == 15595) {
                Facing = Face.East;
                Half = Half.Lower;
                Hinge = HingeType.Right;
                Open = true;
                Powered = true;
            } else if(state == 15596) {
                Facing = Face.East;
                Half = Half.Lower;
                Hinge = HingeType.Right;
                Open = true;
                Powered = false;
            } else if(state == 15597) {
                Facing = Face.East;
                Half = Half.Lower;
                Hinge = HingeType.Right;
                Open = false;
                Powered = true;
            } else if(state == 15598) {
                Facing = Face.East;
                Half = Half.Lower;
                Hinge = HingeType.Right;
                Open = false;
                Powered = false;
            }
        }

        public CrimsonDoorBlock(Chunk chunk, int x, int y, int z, Face facing, Half half, HingeType hinge, bool open, bool powered) : base(chunk, x, y, z, 720, 15546) {
if(facing == Face.North && half == Half.Upper && hinge == HingeType.Left && open == true && powered == true) {
                State = 15535;
            } else if(facing == Face.North && half == Half.Upper && hinge == HingeType.Left && open == true && powered == false) {
                State = 15536;
            } else if(facing == Face.North && half == Half.Upper && hinge == HingeType.Left && open == false && powered == true) {
                State = 15537;
            } else if(facing == Face.North && half == Half.Upper && hinge == HingeType.Left && open == false && powered == false) {
                State = 15538;
            } else if(facing == Face.North && half == Half.Upper && hinge == HingeType.Right && open == true && powered == true) {
                State = 15539;
            } else if(facing == Face.North && half == Half.Upper && hinge == HingeType.Right && open == true && powered == false) {
                State = 15540;
            } else if(facing == Face.North && half == Half.Upper && hinge == HingeType.Right && open == false && powered == true) {
                State = 15541;
            } else if(facing == Face.North && half == Half.Upper && hinge == HingeType.Right && open == false && powered == false) {
                State = 15542;
            } else if(facing == Face.North && half == Half.Lower && hinge == HingeType.Left && open == true && powered == true) {
                State = 15543;
            } else if(facing == Face.North && half == Half.Lower && hinge == HingeType.Left && open == true && powered == false) {
                State = 15544;
            } else if(facing == Face.North && half == Half.Lower && hinge == HingeType.Left && open == false && powered == true) {
                State = 15545;
            } else if(facing == Face.North && half == Half.Lower && hinge == HingeType.Left && open == false && powered == false) {
                State = 15546;
            } else if(facing == Face.North && half == Half.Lower && hinge == HingeType.Right && open == true && powered == true) {
                State = 15547;
            } else if(facing == Face.North && half == Half.Lower && hinge == HingeType.Right && open == true && powered == false) {
                State = 15548;
            } else if(facing == Face.North && half == Half.Lower && hinge == HingeType.Right && open == false && powered == true) {
                State = 15549;
            } else if(facing == Face.North && half == Half.Lower && hinge == HingeType.Right && open == false && powered == false) {
                State = 15550;
            } else if(facing == Face.South && half == Half.Upper && hinge == HingeType.Left && open == true && powered == true) {
                State = 15551;
            } else if(facing == Face.South && half == Half.Upper && hinge == HingeType.Left && open == true && powered == false) {
                State = 15552;
            } else if(facing == Face.South && half == Half.Upper && hinge == HingeType.Left && open == false && powered == true) {
                State = 15553;
            } else if(facing == Face.South && half == Half.Upper && hinge == HingeType.Left && open == false && powered == false) {
                State = 15554;
            } else if(facing == Face.South && half == Half.Upper && hinge == HingeType.Right && open == true && powered == true) {
                State = 15555;
            } else if(facing == Face.South && half == Half.Upper && hinge == HingeType.Right && open == true && powered == false) {
                State = 15556;
            } else if(facing == Face.South && half == Half.Upper && hinge == HingeType.Right && open == false && powered == true) {
                State = 15557;
            } else if(facing == Face.South && half == Half.Upper && hinge == HingeType.Right && open == false && powered == false) {
                State = 15558;
            } else if(facing == Face.South && half == Half.Lower && hinge == HingeType.Left && open == true && powered == true) {
                State = 15559;
            } else if(facing == Face.South && half == Half.Lower && hinge == HingeType.Left && open == true && powered == false) {
                State = 15560;
            } else if(facing == Face.South && half == Half.Lower && hinge == HingeType.Left && open == false && powered == true) {
                State = 15561;
            } else if(facing == Face.South && half == Half.Lower && hinge == HingeType.Left && open == false && powered == false) {
                State = 15562;
            } else if(facing == Face.South && half == Half.Lower && hinge == HingeType.Right && open == true && powered == true) {
                State = 15563;
            } else if(facing == Face.South && half == Half.Lower && hinge == HingeType.Right && open == true && powered == false) {
                State = 15564;
            } else if(facing == Face.South && half == Half.Lower && hinge == HingeType.Right && open == false && powered == true) {
                State = 15565;
            } else if(facing == Face.South && half == Half.Lower && hinge == HingeType.Right && open == false && powered == false) {
                State = 15566;
            } else if(facing == Face.West && half == Half.Upper && hinge == HingeType.Left && open == true && powered == true) {
                State = 15567;
            } else if(facing == Face.West && half == Half.Upper && hinge == HingeType.Left && open == true && powered == false) {
                State = 15568;
            } else if(facing == Face.West && half == Half.Upper && hinge == HingeType.Left && open == false && powered == true) {
                State = 15569;
            } else if(facing == Face.West && half == Half.Upper && hinge == HingeType.Left && open == false && powered == false) {
                State = 15570;
            } else if(facing == Face.West && half == Half.Upper && hinge == HingeType.Right && open == true && powered == true) {
                State = 15571;
            } else if(facing == Face.West && half == Half.Upper && hinge == HingeType.Right && open == true && powered == false) {
                State = 15572;
            } else if(facing == Face.West && half == Half.Upper && hinge == HingeType.Right && open == false && powered == true) {
                State = 15573;
            } else if(facing == Face.West && half == Half.Upper && hinge == HingeType.Right && open == false && powered == false) {
                State = 15574;
            } else if(facing == Face.West && half == Half.Lower && hinge == HingeType.Left && open == true && powered == true) {
                State = 15575;
            } else if(facing == Face.West && half == Half.Lower && hinge == HingeType.Left && open == true && powered == false) {
                State = 15576;
            } else if(facing == Face.West && half == Half.Lower && hinge == HingeType.Left && open == false && powered == true) {
                State = 15577;
            } else if(facing == Face.West && half == Half.Lower && hinge == HingeType.Left && open == false && powered == false) {
                State = 15578;
            } else if(facing == Face.West && half == Half.Lower && hinge == HingeType.Right && open == true && powered == true) {
                State = 15579;
            } else if(facing == Face.West && half == Half.Lower && hinge == HingeType.Right && open == true && powered == false) {
                State = 15580;
            } else if(facing == Face.West && half == Half.Lower && hinge == HingeType.Right && open == false && powered == true) {
                State = 15581;
            } else if(facing == Face.West && half == Half.Lower && hinge == HingeType.Right && open == false && powered == false) {
                State = 15582;
            } else if(facing == Face.East && half == Half.Upper && hinge == HingeType.Left && open == true && powered == true) {
                State = 15583;
            } else if(facing == Face.East && half == Half.Upper && hinge == HingeType.Left && open == true && powered == false) {
                State = 15584;
            } else if(facing == Face.East && half == Half.Upper && hinge == HingeType.Left && open == false && powered == true) {
                State = 15585;
            } else if(facing == Face.East && half == Half.Upper && hinge == HingeType.Left && open == false && powered == false) {
                State = 15586;
            } else if(facing == Face.East && half == Half.Upper && hinge == HingeType.Right && open == true && powered == true) {
                State = 15587;
            } else if(facing == Face.East && half == Half.Upper && hinge == HingeType.Right && open == true && powered == false) {
                State = 15588;
            } else if(facing == Face.East && half == Half.Upper && hinge == HingeType.Right && open == false && powered == true) {
                State = 15589;
            } else if(facing == Face.East && half == Half.Upper && hinge == HingeType.Right && open == false && powered == false) {
                State = 15590;
            } else if(facing == Face.East && half == Half.Lower && hinge == HingeType.Left && open == true && powered == true) {
                State = 15591;
            } else if(facing == Face.East && half == Half.Lower && hinge == HingeType.Left && open == true && powered == false) {
                State = 15592;
            } else if(facing == Face.East && half == Half.Lower && hinge == HingeType.Left && open == false && powered == true) {
                State = 15593;
            } else if(facing == Face.East && half == Half.Lower && hinge == HingeType.Left && open == false && powered == false) {
                State = 15594;
            } else if(facing == Face.East && half == Half.Lower && hinge == HingeType.Right && open == true && powered == true) {
                State = 15595;
            } else if(facing == Face.East && half == Half.Lower && hinge == HingeType.Right && open == true && powered == false) {
                State = 15596;
            } else if(facing == Face.East && half == Half.Lower && hinge == HingeType.Right && open == false && powered == true) {
                State = 15597;
            } else if(facing == Face.East && half == Half.Lower && hinge == HingeType.Right && open == false && powered == false) {
                State = 15598;
            }
        }

        public enum HingeType {
            
            Left,
            Right
        }
    }
}