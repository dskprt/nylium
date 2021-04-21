// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class LimeBannerBlock : BaseBlock {

        public int Rotation { get; }

        public LimeBannerBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 421, 7981) { }

        public LimeBannerBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z, 421, state) {
            if(state == 7981) {
                Rotation = 0;
            } else if(state == 7982) {
                Rotation = 1;
            } else if(state == 7983) {
                Rotation = 2;
            } else if(state == 7984) {
                Rotation = 3;
            } else if(state == 7985) {
                Rotation = 4;
            } else if(state == 7986) {
                Rotation = 5;
            } else if(state == 7987) {
                Rotation = 6;
            } else if(state == 7988) {
                Rotation = 7;
            } else if(state == 7989) {
                Rotation = 8;
            } else if(state == 7990) {
                Rotation = 9;
            } else if(state == 7991) {
                Rotation = 10;
            } else if(state == 7992) {
                Rotation = 11;
            } else if(state == 7993) {
                Rotation = 12;
            } else if(state == 7994) {
                Rotation = 13;
            } else if(state == 7995) {
                Rotation = 14;
            } else if(state == 7996) {
                Rotation = 15;
            }
        }

        public LimeBannerBlock(Chunk chunk, int x, int y, int z, int rotation) : base(chunk, x, y, z, 421, 7981) {
if(rotation == 0) {
                State = 7981;
            } else if(rotation == 1) {
                State = 7982;
            } else if(rotation == 2) {
                State = 7983;
            } else if(rotation == 3) {
                State = 7984;
            } else if(rotation == 4) {
                State = 7985;
            } else if(rotation == 5) {
                State = 7986;
            } else if(rotation == 6) {
                State = 7987;
            } else if(rotation == 7) {
                State = 7988;
            } else if(rotation == 8) {
                State = 7989;
            } else if(rotation == 9) {
                State = 7990;
            } else if(rotation == 10) {
                State = 7991;
            } else if(rotation == 11) {
                State = 7992;
            } else if(rotation == 12) {
                State = 7993;
            } else if(rotation == 13) {
                State = 7994;
            } else if(rotation == 14) {
                State = 7995;
            } else if(rotation == 15) {
                State = 7996;
            }
        }
    }
}