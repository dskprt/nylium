// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class ChorusFlowerBlock : BaseBlock {

        public int Age { get; }

        public ChorusFlowerBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 492, 9132) { }

        public ChorusFlowerBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z, 492, state) {
            if(state == 9132) {
                Age = 0;
            } else if(state == 9133) {
                Age = 1;
            } else if(state == 9134) {
                Age = 2;
            } else if(state == 9135) {
                Age = 3;
            } else if(state == 9136) {
                Age = 4;
            } else if(state == 9137) {
                Age = 5;
            }
        }

        public ChorusFlowerBlock(Chunk chunk, int x, int y, int z, int age) : base(chunk, x, y, z, 492, 9132) {
if(age == 0) {
                State = 9132;
            } else if(age == 1) {
                State = 9133;
            } else if(age == 2) {
                State = 9134;
            } else if(age == 3) {
                State = 9135;
            } else if(age == 4) {
                State = 9136;
            } else if(age == 5) {
                State = 9137;
            }
        }
    }
}