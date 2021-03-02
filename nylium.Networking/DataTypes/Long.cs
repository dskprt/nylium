﻿using System;
using System.IO;
using nylium.Extensions;

namespace nylium.Networking.DataTypes {

    public class Long : DataType<long> {

        public Long() : base(0) { }
        public Long(long value) : base(value) { }

        public override void Read(Stream stream, out int bytesRead) {
            bytesRead = 0;
            byte[] read = new byte[8];

            stream.Read(read, 0, 8);
            bytesRead += 8;

            Value = read.ReadBigEndianL();
        }

        public override void Write(Stream stream) {
            byte[] bytes = Value.WriteBigEndian();
            stream.Write(bytes);
        }
    }
}
