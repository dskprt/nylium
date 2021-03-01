﻿using System;
using System.IO;
using nylium.Extensions;

namespace nylium.Networking.DataTypes {

    class UShort : DataType<ushort> {

        public UShort() : base(0) { }
        public UShort(ushort value) : base(value) { }

        public override void Read(Stream stream, out int bytesRead) {
            bytesRead = 0;
            byte[] read = new byte[2];

            stream.Read(read, 0, 2);
            bytesRead += 2;

            Value = read.ReverseUShort();
        }

        public override void Write(Stream stream) {
            byte[] bytes = BitConverter.GetBytes(Value);
            Array.Reverse(bytes);

            stream.Write(bytes);
        }
    }
}
