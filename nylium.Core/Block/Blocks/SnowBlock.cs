// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class SnowBlock : BaseBlock {

        public int Layers { get; }

        public SnowBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 184, 3921) { }

        public SnowBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z, 184, state) {
            if(state == 3921) {
                Layers = 1;
            } else if(state == 3922) {
                Layers = 2;
            } else if(state == 3923) {
                Layers = 3;
            } else if(state == 3924) {
                Layers = 4;
            } else if(state == 3925) {
                Layers = 5;
            } else if(state == 3926) {
                Layers = 6;
            } else if(state == 3927) {
                Layers = 7;
            } else if(state == 3928) {
                Layers = 8;
            }
        }

        public SnowBlock(Chunk chunk, int x, int y, int z, int layers) : base(chunk, x, y, z, 184, 3921) {
if(layers == 1) {
                State = 3921;
            } else if(layers == 2) {
                State = 3922;
            } else if(layers == 3) {
                State = 3923;
            } else if(layers == 4) {
                State = 3924;
            } else if(layers == 5) {
                State = 3925;
            } else if(layers == 6) {
                State = 3926;
            } else if(layers == 7) {
                State = 3927;
            } else if(layers == 8) {
                State = 3928;
            }
        }
    }
}