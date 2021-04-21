// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class BlackstoneStairsBlock : BaseBlock {

        public Face Facing { get; }
        public Half Half { get; }
        public Shape Shape { get; }
        public bool Waterlogged { get; }

        public BlackstoneStairsBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 744, 15859) { }

        public BlackstoneStairsBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z, 744, state) {
            if(state == 15848) {
                Facing = Face.North;
                Half = Half.Top;
                Shape = Shape.Straight;
                Waterlogged = true;
            } else if(state == 15849) {
                Facing = Face.North;
                Half = Half.Top;
                Shape = Shape.Straight;
                Waterlogged = false;
            } else if(state == 15850) {
                Facing = Face.North;
                Half = Half.Top;
                Shape = Shape.InnerLeft;
                Waterlogged = true;
            } else if(state == 15851) {
                Facing = Face.North;
                Half = Half.Top;
                Shape = Shape.InnerLeft;
                Waterlogged = false;
            } else if(state == 15852) {
                Facing = Face.North;
                Half = Half.Top;
                Shape = Shape.InnerRight;
                Waterlogged = true;
            } else if(state == 15853) {
                Facing = Face.North;
                Half = Half.Top;
                Shape = Shape.InnerRight;
                Waterlogged = false;
            } else if(state == 15854) {
                Facing = Face.North;
                Half = Half.Top;
                Shape = Shape.OuterLeft;
                Waterlogged = true;
            } else if(state == 15855) {
                Facing = Face.North;
                Half = Half.Top;
                Shape = Shape.OuterLeft;
                Waterlogged = false;
            } else if(state == 15856) {
                Facing = Face.North;
                Half = Half.Top;
                Shape = Shape.OuterRight;
                Waterlogged = true;
            } else if(state == 15857) {
                Facing = Face.North;
                Half = Half.Top;
                Shape = Shape.OuterRight;
                Waterlogged = false;
            } else if(state == 15858) {
                Facing = Face.North;
                Half = Half.Bottom;
                Shape = Shape.Straight;
                Waterlogged = true;
            } else if(state == 15859) {
                Facing = Face.North;
                Half = Half.Bottom;
                Shape = Shape.Straight;
                Waterlogged = false;
            } else if(state == 15860) {
                Facing = Face.North;
                Half = Half.Bottom;
                Shape = Shape.InnerLeft;
                Waterlogged = true;
            } else if(state == 15861) {
                Facing = Face.North;
                Half = Half.Bottom;
                Shape = Shape.InnerLeft;
                Waterlogged = false;
            } else if(state == 15862) {
                Facing = Face.North;
                Half = Half.Bottom;
                Shape = Shape.InnerRight;
                Waterlogged = true;
            } else if(state == 15863) {
                Facing = Face.North;
                Half = Half.Bottom;
                Shape = Shape.InnerRight;
                Waterlogged = false;
            } else if(state == 15864) {
                Facing = Face.North;
                Half = Half.Bottom;
                Shape = Shape.OuterLeft;
                Waterlogged = true;
            } else if(state == 15865) {
                Facing = Face.North;
                Half = Half.Bottom;
                Shape = Shape.OuterLeft;
                Waterlogged = false;
            } else if(state == 15866) {
                Facing = Face.North;
                Half = Half.Bottom;
                Shape = Shape.OuterRight;
                Waterlogged = true;
            } else if(state == 15867) {
                Facing = Face.North;
                Half = Half.Bottom;
                Shape = Shape.OuterRight;
                Waterlogged = false;
            } else if(state == 15868) {
                Facing = Face.South;
                Half = Half.Top;
                Shape = Shape.Straight;
                Waterlogged = true;
            } else if(state == 15869) {
                Facing = Face.South;
                Half = Half.Top;
                Shape = Shape.Straight;
                Waterlogged = false;
            } else if(state == 15870) {
                Facing = Face.South;
                Half = Half.Top;
                Shape = Shape.InnerLeft;
                Waterlogged = true;
            } else if(state == 15871) {
                Facing = Face.South;
                Half = Half.Top;
                Shape = Shape.InnerLeft;
                Waterlogged = false;
            } else if(state == 15872) {
                Facing = Face.South;
                Half = Half.Top;
                Shape = Shape.InnerRight;
                Waterlogged = true;
            } else if(state == 15873) {
                Facing = Face.South;
                Half = Half.Top;
                Shape = Shape.InnerRight;
                Waterlogged = false;
            } else if(state == 15874) {
                Facing = Face.South;
                Half = Half.Top;
                Shape = Shape.OuterLeft;
                Waterlogged = true;
            } else if(state == 15875) {
                Facing = Face.South;
                Half = Half.Top;
                Shape = Shape.OuterLeft;
                Waterlogged = false;
            } else if(state == 15876) {
                Facing = Face.South;
                Half = Half.Top;
                Shape = Shape.OuterRight;
                Waterlogged = true;
            } else if(state == 15877) {
                Facing = Face.South;
                Half = Half.Top;
                Shape = Shape.OuterRight;
                Waterlogged = false;
            } else if(state == 15878) {
                Facing = Face.South;
                Half = Half.Bottom;
                Shape = Shape.Straight;
                Waterlogged = true;
            } else if(state == 15879) {
                Facing = Face.South;
                Half = Half.Bottom;
                Shape = Shape.Straight;
                Waterlogged = false;
            } else if(state == 15880) {
                Facing = Face.South;
                Half = Half.Bottom;
                Shape = Shape.InnerLeft;
                Waterlogged = true;
            } else if(state == 15881) {
                Facing = Face.South;
                Half = Half.Bottom;
                Shape = Shape.InnerLeft;
                Waterlogged = false;
            } else if(state == 15882) {
                Facing = Face.South;
                Half = Half.Bottom;
                Shape = Shape.InnerRight;
                Waterlogged = true;
            } else if(state == 15883) {
                Facing = Face.South;
                Half = Half.Bottom;
                Shape = Shape.InnerRight;
                Waterlogged = false;
            } else if(state == 15884) {
                Facing = Face.South;
                Half = Half.Bottom;
                Shape = Shape.OuterLeft;
                Waterlogged = true;
            } else if(state == 15885) {
                Facing = Face.South;
                Half = Half.Bottom;
                Shape = Shape.OuterLeft;
                Waterlogged = false;
            } else if(state == 15886) {
                Facing = Face.South;
                Half = Half.Bottom;
                Shape = Shape.OuterRight;
                Waterlogged = true;
            } else if(state == 15887) {
                Facing = Face.South;
                Half = Half.Bottom;
                Shape = Shape.OuterRight;
                Waterlogged = false;
            } else if(state == 15888) {
                Facing = Face.West;
                Half = Half.Top;
                Shape = Shape.Straight;
                Waterlogged = true;
            } else if(state == 15889) {
                Facing = Face.West;
                Half = Half.Top;
                Shape = Shape.Straight;
                Waterlogged = false;
            } else if(state == 15890) {
                Facing = Face.West;
                Half = Half.Top;
                Shape = Shape.InnerLeft;
                Waterlogged = true;
            } else if(state == 15891) {
                Facing = Face.West;
                Half = Half.Top;
                Shape = Shape.InnerLeft;
                Waterlogged = false;
            } else if(state == 15892) {
                Facing = Face.West;
                Half = Half.Top;
                Shape = Shape.InnerRight;
                Waterlogged = true;
            } else if(state == 15893) {
                Facing = Face.West;
                Half = Half.Top;
                Shape = Shape.InnerRight;
                Waterlogged = false;
            } else if(state == 15894) {
                Facing = Face.West;
                Half = Half.Top;
                Shape = Shape.OuterLeft;
                Waterlogged = true;
            } else if(state == 15895) {
                Facing = Face.West;
                Half = Half.Top;
                Shape = Shape.OuterLeft;
                Waterlogged = false;
            } else if(state == 15896) {
                Facing = Face.West;
                Half = Half.Top;
                Shape = Shape.OuterRight;
                Waterlogged = true;
            } else if(state == 15897) {
                Facing = Face.West;
                Half = Half.Top;
                Shape = Shape.OuterRight;
                Waterlogged = false;
            } else if(state == 15898) {
                Facing = Face.West;
                Half = Half.Bottom;
                Shape = Shape.Straight;
                Waterlogged = true;
            } else if(state == 15899) {
                Facing = Face.West;
                Half = Half.Bottom;
                Shape = Shape.Straight;
                Waterlogged = false;
            } else if(state == 15900) {
                Facing = Face.West;
                Half = Half.Bottom;
                Shape = Shape.InnerLeft;
                Waterlogged = true;
            } else if(state == 15901) {
                Facing = Face.West;
                Half = Half.Bottom;
                Shape = Shape.InnerLeft;
                Waterlogged = false;
            } else if(state == 15902) {
                Facing = Face.West;
                Half = Half.Bottom;
                Shape = Shape.InnerRight;
                Waterlogged = true;
            } else if(state == 15903) {
                Facing = Face.West;
                Half = Half.Bottom;
                Shape = Shape.InnerRight;
                Waterlogged = false;
            } else if(state == 15904) {
                Facing = Face.West;
                Half = Half.Bottom;
                Shape = Shape.OuterLeft;
                Waterlogged = true;
            } else if(state == 15905) {
                Facing = Face.West;
                Half = Half.Bottom;
                Shape = Shape.OuterLeft;
                Waterlogged = false;
            } else if(state == 15906) {
                Facing = Face.West;
                Half = Half.Bottom;
                Shape = Shape.OuterRight;
                Waterlogged = true;
            } else if(state == 15907) {
                Facing = Face.West;
                Half = Half.Bottom;
                Shape = Shape.OuterRight;
                Waterlogged = false;
            } else if(state == 15908) {
                Facing = Face.East;
                Half = Half.Top;
                Shape = Shape.Straight;
                Waterlogged = true;
            } else if(state == 15909) {
                Facing = Face.East;
                Half = Half.Top;
                Shape = Shape.Straight;
                Waterlogged = false;
            } else if(state == 15910) {
                Facing = Face.East;
                Half = Half.Top;
                Shape = Shape.InnerLeft;
                Waterlogged = true;
            } else if(state == 15911) {
                Facing = Face.East;
                Half = Half.Top;
                Shape = Shape.InnerLeft;
                Waterlogged = false;
            } else if(state == 15912) {
                Facing = Face.East;
                Half = Half.Top;
                Shape = Shape.InnerRight;
                Waterlogged = true;
            } else if(state == 15913) {
                Facing = Face.East;
                Half = Half.Top;
                Shape = Shape.InnerRight;
                Waterlogged = false;
            } else if(state == 15914) {
                Facing = Face.East;
                Half = Half.Top;
                Shape = Shape.OuterLeft;
                Waterlogged = true;
            } else if(state == 15915) {
                Facing = Face.East;
                Half = Half.Top;
                Shape = Shape.OuterLeft;
                Waterlogged = false;
            } else if(state == 15916) {
                Facing = Face.East;
                Half = Half.Top;
                Shape = Shape.OuterRight;
                Waterlogged = true;
            } else if(state == 15917) {
                Facing = Face.East;
                Half = Half.Top;
                Shape = Shape.OuterRight;
                Waterlogged = false;
            } else if(state == 15918) {
                Facing = Face.East;
                Half = Half.Bottom;
                Shape = Shape.Straight;
                Waterlogged = true;
            } else if(state == 15919) {
                Facing = Face.East;
                Half = Half.Bottom;
                Shape = Shape.Straight;
                Waterlogged = false;
            } else if(state == 15920) {
                Facing = Face.East;
                Half = Half.Bottom;
                Shape = Shape.InnerLeft;
                Waterlogged = true;
            } else if(state == 15921) {
                Facing = Face.East;
                Half = Half.Bottom;
                Shape = Shape.InnerLeft;
                Waterlogged = false;
            } else if(state == 15922) {
                Facing = Face.East;
                Half = Half.Bottom;
                Shape = Shape.InnerRight;
                Waterlogged = true;
            } else if(state == 15923) {
                Facing = Face.East;
                Half = Half.Bottom;
                Shape = Shape.InnerRight;
                Waterlogged = false;
            } else if(state == 15924) {
                Facing = Face.East;
                Half = Half.Bottom;
                Shape = Shape.OuterLeft;
                Waterlogged = true;
            } else if(state == 15925) {
                Facing = Face.East;
                Half = Half.Bottom;
                Shape = Shape.OuterLeft;
                Waterlogged = false;
            } else if(state == 15926) {
                Facing = Face.East;
                Half = Half.Bottom;
                Shape = Shape.OuterRight;
                Waterlogged = true;
            } else if(state == 15927) {
                Facing = Face.East;
                Half = Half.Bottom;
                Shape = Shape.OuterRight;
                Waterlogged = false;
            }
        }

        public BlackstoneStairsBlock(Chunk chunk, int x, int y, int z, Face facing, Half half, Shape shape, bool waterlogged) : base(chunk, x, y, z, 744, 15859) {
if(facing == Face.North && half == Half.Top && shape == Shape.Straight && waterlogged == true) {
                State = 15848;
            } else if(facing == Face.North && half == Half.Top && shape == Shape.Straight && waterlogged == false) {
                State = 15849;
            } else if(facing == Face.North && half == Half.Top && shape == Shape.InnerLeft && waterlogged == true) {
                State = 15850;
            } else if(facing == Face.North && half == Half.Top && shape == Shape.InnerLeft && waterlogged == false) {
                State = 15851;
            } else if(facing == Face.North && half == Half.Top && shape == Shape.InnerRight && waterlogged == true) {
                State = 15852;
            } else if(facing == Face.North && half == Half.Top && shape == Shape.InnerRight && waterlogged == false) {
                State = 15853;
            } else if(facing == Face.North && half == Half.Top && shape == Shape.OuterLeft && waterlogged == true) {
                State = 15854;
            } else if(facing == Face.North && half == Half.Top && shape == Shape.OuterLeft && waterlogged == false) {
                State = 15855;
            } else if(facing == Face.North && half == Half.Top && shape == Shape.OuterRight && waterlogged == true) {
                State = 15856;
            } else if(facing == Face.North && half == Half.Top && shape == Shape.OuterRight && waterlogged == false) {
                State = 15857;
            } else if(facing == Face.North && half == Half.Bottom && shape == Shape.Straight && waterlogged == true) {
                State = 15858;
            } else if(facing == Face.North && half == Half.Bottom && shape == Shape.Straight && waterlogged == false) {
                State = 15859;
            } else if(facing == Face.North && half == Half.Bottom && shape == Shape.InnerLeft && waterlogged == true) {
                State = 15860;
            } else if(facing == Face.North && half == Half.Bottom && shape == Shape.InnerLeft && waterlogged == false) {
                State = 15861;
            } else if(facing == Face.North && half == Half.Bottom && shape == Shape.InnerRight && waterlogged == true) {
                State = 15862;
            } else if(facing == Face.North && half == Half.Bottom && shape == Shape.InnerRight && waterlogged == false) {
                State = 15863;
            } else if(facing == Face.North && half == Half.Bottom && shape == Shape.OuterLeft && waterlogged == true) {
                State = 15864;
            } else if(facing == Face.North && half == Half.Bottom && shape == Shape.OuterLeft && waterlogged == false) {
                State = 15865;
            } else if(facing == Face.North && half == Half.Bottom && shape == Shape.OuterRight && waterlogged == true) {
                State = 15866;
            } else if(facing == Face.North && half == Half.Bottom && shape == Shape.OuterRight && waterlogged == false) {
                State = 15867;
            } else if(facing == Face.South && half == Half.Top && shape == Shape.Straight && waterlogged == true) {
                State = 15868;
            } else if(facing == Face.South && half == Half.Top && shape == Shape.Straight && waterlogged == false) {
                State = 15869;
            } else if(facing == Face.South && half == Half.Top && shape == Shape.InnerLeft && waterlogged == true) {
                State = 15870;
            } else if(facing == Face.South && half == Half.Top && shape == Shape.InnerLeft && waterlogged == false) {
                State = 15871;
            } else if(facing == Face.South && half == Half.Top && shape == Shape.InnerRight && waterlogged == true) {
                State = 15872;
            } else if(facing == Face.South && half == Half.Top && shape == Shape.InnerRight && waterlogged == false) {
                State = 15873;
            } else if(facing == Face.South && half == Half.Top && shape == Shape.OuterLeft && waterlogged == true) {
                State = 15874;
            } else if(facing == Face.South && half == Half.Top && shape == Shape.OuterLeft && waterlogged == false) {
                State = 15875;
            } else if(facing == Face.South && half == Half.Top && shape == Shape.OuterRight && waterlogged == true) {
                State = 15876;
            } else if(facing == Face.South && half == Half.Top && shape == Shape.OuterRight && waterlogged == false) {
                State = 15877;
            } else if(facing == Face.South && half == Half.Bottom && shape == Shape.Straight && waterlogged == true) {
                State = 15878;
            } else if(facing == Face.South && half == Half.Bottom && shape == Shape.Straight && waterlogged == false) {
                State = 15879;
            } else if(facing == Face.South && half == Half.Bottom && shape == Shape.InnerLeft && waterlogged == true) {
                State = 15880;
            } else if(facing == Face.South && half == Half.Bottom && shape == Shape.InnerLeft && waterlogged == false) {
                State = 15881;
            } else if(facing == Face.South && half == Half.Bottom && shape == Shape.InnerRight && waterlogged == true) {
                State = 15882;
            } else if(facing == Face.South && half == Half.Bottom && shape == Shape.InnerRight && waterlogged == false) {
                State = 15883;
            } else if(facing == Face.South && half == Half.Bottom && shape == Shape.OuterLeft && waterlogged == true) {
                State = 15884;
            } else if(facing == Face.South && half == Half.Bottom && shape == Shape.OuterLeft && waterlogged == false) {
                State = 15885;
            } else if(facing == Face.South && half == Half.Bottom && shape == Shape.OuterRight && waterlogged == true) {
                State = 15886;
            } else if(facing == Face.South && half == Half.Bottom && shape == Shape.OuterRight && waterlogged == false) {
                State = 15887;
            } else if(facing == Face.West && half == Half.Top && shape == Shape.Straight && waterlogged == true) {
                State = 15888;
            } else if(facing == Face.West && half == Half.Top && shape == Shape.Straight && waterlogged == false) {
                State = 15889;
            } else if(facing == Face.West && half == Half.Top && shape == Shape.InnerLeft && waterlogged == true) {
                State = 15890;
            } else if(facing == Face.West && half == Half.Top && shape == Shape.InnerLeft && waterlogged == false) {
                State = 15891;
            } else if(facing == Face.West && half == Half.Top && shape == Shape.InnerRight && waterlogged == true) {
                State = 15892;
            } else if(facing == Face.West && half == Half.Top && shape == Shape.InnerRight && waterlogged == false) {
                State = 15893;
            } else if(facing == Face.West && half == Half.Top && shape == Shape.OuterLeft && waterlogged == true) {
                State = 15894;
            } else if(facing == Face.West && half == Half.Top && shape == Shape.OuterLeft && waterlogged == false) {
                State = 15895;
            } else if(facing == Face.West && half == Half.Top && shape == Shape.OuterRight && waterlogged == true) {
                State = 15896;
            } else if(facing == Face.West && half == Half.Top && shape == Shape.OuterRight && waterlogged == false) {
                State = 15897;
            } else if(facing == Face.West && half == Half.Bottom && shape == Shape.Straight && waterlogged == true) {
                State = 15898;
            } else if(facing == Face.West && half == Half.Bottom && shape == Shape.Straight && waterlogged == false) {
                State = 15899;
            } else if(facing == Face.West && half == Half.Bottom && shape == Shape.InnerLeft && waterlogged == true) {
                State = 15900;
            } else if(facing == Face.West && half == Half.Bottom && shape == Shape.InnerLeft && waterlogged == false) {
                State = 15901;
            } else if(facing == Face.West && half == Half.Bottom && shape == Shape.InnerRight && waterlogged == true) {
                State = 15902;
            } else if(facing == Face.West && half == Half.Bottom && shape == Shape.InnerRight && waterlogged == false) {
                State = 15903;
            } else if(facing == Face.West && half == Half.Bottom && shape == Shape.OuterLeft && waterlogged == true) {
                State = 15904;
            } else if(facing == Face.West && half == Half.Bottom && shape == Shape.OuterLeft && waterlogged == false) {
                State = 15905;
            } else if(facing == Face.West && half == Half.Bottom && shape == Shape.OuterRight && waterlogged == true) {
                State = 15906;
            } else if(facing == Face.West && half == Half.Bottom && shape == Shape.OuterRight && waterlogged == false) {
                State = 15907;
            } else if(facing == Face.East && half == Half.Top && shape == Shape.Straight && waterlogged == true) {
                State = 15908;
            } else if(facing == Face.East && half == Half.Top && shape == Shape.Straight && waterlogged == false) {
                State = 15909;
            } else if(facing == Face.East && half == Half.Top && shape == Shape.InnerLeft && waterlogged == true) {
                State = 15910;
            } else if(facing == Face.East && half == Half.Top && shape == Shape.InnerLeft && waterlogged == false) {
                State = 15911;
            } else if(facing == Face.East && half == Half.Top && shape == Shape.InnerRight && waterlogged == true) {
                State = 15912;
            } else if(facing == Face.East && half == Half.Top && shape == Shape.InnerRight && waterlogged == false) {
                State = 15913;
            } else if(facing == Face.East && half == Half.Top && shape == Shape.OuterLeft && waterlogged == true) {
                State = 15914;
            } else if(facing == Face.East && half == Half.Top && shape == Shape.OuterLeft && waterlogged == false) {
                State = 15915;
            } else if(facing == Face.East && half == Half.Top && shape == Shape.OuterRight && waterlogged == true) {
                State = 15916;
            } else if(facing == Face.East && half == Half.Top && shape == Shape.OuterRight && waterlogged == false) {
                State = 15917;
            } else if(facing == Face.East && half == Half.Bottom && shape == Shape.Straight && waterlogged == true) {
                State = 15918;
            } else if(facing == Face.East && half == Half.Bottom && shape == Shape.Straight && waterlogged == false) {
                State = 15919;
            } else if(facing == Face.East && half == Half.Bottom && shape == Shape.InnerLeft && waterlogged == true) {
                State = 15920;
            } else if(facing == Face.East && half == Half.Bottom && shape == Shape.InnerLeft && waterlogged == false) {
                State = 15921;
            } else if(facing == Face.East && half == Half.Bottom && shape == Shape.InnerRight && waterlogged == true) {
                State = 15922;
            } else if(facing == Face.East && half == Half.Bottom && shape == Shape.InnerRight && waterlogged == false) {
                State = 15923;
            } else if(facing == Face.East && half == Half.Bottom && shape == Shape.OuterLeft && waterlogged == true) {
                State = 15924;
            } else if(facing == Face.East && half == Half.Bottom && shape == Shape.OuterLeft && waterlogged == false) {
                State = 15925;
            } else if(facing == Face.East && half == Half.Bottom && shape == Shape.OuterRight && waterlogged == true) {
                State = 15926;
            } else if(facing == Face.East && half == Half.Bottom && shape == Shape.OuterRight && waterlogged == false) {
                State = 15927;
            }
        }
    }
}