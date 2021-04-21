// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class CarrotsBlock : BaseBlock {

        public int Age { get; }

        public CarrotsBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 306, 6334) { }

        public CarrotsBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z, 306, state) {
            if(state == 6334) {
                Age = 0;
            } else if(state == 6335) {
                Age = 1;
            } else if(state == 6336) {
                Age = 2;
            } else if(state == 6337) {
                Age = 3;
            } else if(state == 6338) {
                Age = 4;
            } else if(state == 6339) {
                Age = 5;
            } else if(state == 6340) {
                Age = 6;
            } else if(state == 6341) {
                Age = 7;
            }
        }

        public CarrotsBlock(Chunk chunk, int x, int y, int z, int age) : base(chunk, x, y, z, 306, 6334) {
if(age == 0) {
                State = 6334;
            } else if(age == 1) {
                State = 6335;
            } else if(age == 2) {
                State = 6336;
            } else if(age == 3) {
                State = 6337;
            } else if(age == 4) {
                State = 6338;
            } else if(age == 5) {
                State = 6339;
            } else if(age == 6) {
                State = 6340;
            } else if(age == 7) {
                State = 6341;
            }
        }
    }
}