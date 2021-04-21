// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class LimeStainedGlassPaneBlock : BaseBlock {

        public bool East { get; }
        public bool North { get; }
        public bool South { get; }
        public bool Waterlogged { get; }
        public bool West { get; }

        public LimeStainedGlassPaneBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 364, 7058) { }

        public LimeStainedGlassPaneBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z, 364, state) {
            if(state == 7027) {
                East = true;
                North = true;
                South = true;
                Waterlogged = true;
                West = true;
            } else if(state == 7028) {
                East = true;
                North = true;
                South = true;
                Waterlogged = true;
                West = false;
            } else if(state == 7029) {
                East = true;
                North = true;
                South = true;
                Waterlogged = false;
                West = true;
            } else if(state == 7030) {
                East = true;
                North = true;
                South = true;
                Waterlogged = false;
                West = false;
            } else if(state == 7031) {
                East = true;
                North = true;
                South = false;
                Waterlogged = true;
                West = true;
            } else if(state == 7032) {
                East = true;
                North = true;
                South = false;
                Waterlogged = true;
                West = false;
            } else if(state == 7033) {
                East = true;
                North = true;
                South = false;
                Waterlogged = false;
                West = true;
            } else if(state == 7034) {
                East = true;
                North = true;
                South = false;
                Waterlogged = false;
                West = false;
            } else if(state == 7035) {
                East = true;
                North = false;
                South = true;
                Waterlogged = true;
                West = true;
            } else if(state == 7036) {
                East = true;
                North = false;
                South = true;
                Waterlogged = true;
                West = false;
            } else if(state == 7037) {
                East = true;
                North = false;
                South = true;
                Waterlogged = false;
                West = true;
            } else if(state == 7038) {
                East = true;
                North = false;
                South = true;
                Waterlogged = false;
                West = false;
            } else if(state == 7039) {
                East = true;
                North = false;
                South = false;
                Waterlogged = true;
                West = true;
            } else if(state == 7040) {
                East = true;
                North = false;
                South = false;
                Waterlogged = true;
                West = false;
            } else if(state == 7041) {
                East = true;
                North = false;
                South = false;
                Waterlogged = false;
                West = true;
            } else if(state == 7042) {
                East = true;
                North = false;
                South = false;
                Waterlogged = false;
                West = false;
            } else if(state == 7043) {
                East = false;
                North = true;
                South = true;
                Waterlogged = true;
                West = true;
            } else if(state == 7044) {
                East = false;
                North = true;
                South = true;
                Waterlogged = true;
                West = false;
            } else if(state == 7045) {
                East = false;
                North = true;
                South = true;
                Waterlogged = false;
                West = true;
            } else if(state == 7046) {
                East = false;
                North = true;
                South = true;
                Waterlogged = false;
                West = false;
            } else if(state == 7047) {
                East = false;
                North = true;
                South = false;
                Waterlogged = true;
                West = true;
            } else if(state == 7048) {
                East = false;
                North = true;
                South = false;
                Waterlogged = true;
                West = false;
            } else if(state == 7049) {
                East = false;
                North = true;
                South = false;
                Waterlogged = false;
                West = true;
            } else if(state == 7050) {
                East = false;
                North = true;
                South = false;
                Waterlogged = false;
                West = false;
            } else if(state == 7051) {
                East = false;
                North = false;
                South = true;
                Waterlogged = true;
                West = true;
            } else if(state == 7052) {
                East = false;
                North = false;
                South = true;
                Waterlogged = true;
                West = false;
            } else if(state == 7053) {
                East = false;
                North = false;
                South = true;
                Waterlogged = false;
                West = true;
            } else if(state == 7054) {
                East = false;
                North = false;
                South = true;
                Waterlogged = false;
                West = false;
            } else if(state == 7055) {
                East = false;
                North = false;
                South = false;
                Waterlogged = true;
                West = true;
            } else if(state == 7056) {
                East = false;
                North = false;
                South = false;
                Waterlogged = true;
                West = false;
            } else if(state == 7057) {
                East = false;
                North = false;
                South = false;
                Waterlogged = false;
                West = true;
            } else if(state == 7058) {
                East = false;
                North = false;
                South = false;
                Waterlogged = false;
                West = false;
            }
        }

        public LimeStainedGlassPaneBlock(Chunk chunk, int x, int y, int z, bool east, bool north, bool south, bool waterlogged, bool west) : base(chunk, x, y, z, 364, 7058) {
if(east == true && north == true && south == true && waterlogged == true && west == true) {
                State = 7027;
            } else if(east == true && north == true && south == true && waterlogged == true && west == false) {
                State = 7028;
            } else if(east == true && north == true && south == true && waterlogged == false && west == true) {
                State = 7029;
            } else if(east == true && north == true && south == true && waterlogged == false && west == false) {
                State = 7030;
            } else if(east == true && north == true && south == false && waterlogged == true && west == true) {
                State = 7031;
            } else if(east == true && north == true && south == false && waterlogged == true && west == false) {
                State = 7032;
            } else if(east == true && north == true && south == false && waterlogged == false && west == true) {
                State = 7033;
            } else if(east == true && north == true && south == false && waterlogged == false && west == false) {
                State = 7034;
            } else if(east == true && north == false && south == true && waterlogged == true && west == true) {
                State = 7035;
            } else if(east == true && north == false && south == true && waterlogged == true && west == false) {
                State = 7036;
            } else if(east == true && north == false && south == true && waterlogged == false && west == true) {
                State = 7037;
            } else if(east == true && north == false && south == true && waterlogged == false && west == false) {
                State = 7038;
            } else if(east == true && north == false && south == false && waterlogged == true && west == true) {
                State = 7039;
            } else if(east == true && north == false && south == false && waterlogged == true && west == false) {
                State = 7040;
            } else if(east == true && north == false && south == false && waterlogged == false && west == true) {
                State = 7041;
            } else if(east == true && north == false && south == false && waterlogged == false && west == false) {
                State = 7042;
            } else if(east == false && north == true && south == true && waterlogged == true && west == true) {
                State = 7043;
            } else if(east == false && north == true && south == true && waterlogged == true && west == false) {
                State = 7044;
            } else if(east == false && north == true && south == true && waterlogged == false && west == true) {
                State = 7045;
            } else if(east == false && north == true && south == true && waterlogged == false && west == false) {
                State = 7046;
            } else if(east == false && north == true && south == false && waterlogged == true && west == true) {
                State = 7047;
            } else if(east == false && north == true && south == false && waterlogged == true && west == false) {
                State = 7048;
            } else if(east == false && north == true && south == false && waterlogged == false && west == true) {
                State = 7049;
            } else if(east == false && north == true && south == false && waterlogged == false && west == false) {
                State = 7050;
            } else if(east == false && north == false && south == true && waterlogged == true && west == true) {
                State = 7051;
            } else if(east == false && north == false && south == true && waterlogged == true && west == false) {
                State = 7052;
            } else if(east == false && north == false && south == true && waterlogged == false && west == true) {
                State = 7053;
            } else if(east == false && north == false && south == true && waterlogged == false && west == false) {
                State = 7054;
            } else if(east == false && north == false && south == false && waterlogged == true && west == true) {
                State = 7055;
            } else if(east == false && north == false && south == false && waterlogged == true && west == false) {
                State = 7056;
            } else if(east == false && north == false && south == false && waterlogged == false && west == true) {
                State = 7057;
            } else if(east == false && north == false && south == false && waterlogged == false && west == false) {
                State = 7058;
            }
        }
    }
}