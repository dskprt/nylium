﻿using System.IO;
using Jil;

namespace nylium.Core.DataTypes {

    public class Chat : DataType<dynamic> {

        public Chat() : base(null) { }
        public Chat(dynamic json) : base(null) { Value = json; }
        public Chat(Stream stream) : base(null) { Read(stream); }

        public override int Read(Stream stream) {
            String @string = new();
            int bytesRead = @string.Read(stream);

            Value = JSON.DeserializeDynamic(@string.Value);
            return bytesRead;
        }

        public override void Write(Stream stream) {
            String @string = new(JSON.SerializeDynamic(Value));
            @string.Write(stream);
        }
    }
}