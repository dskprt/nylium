﻿using System;
using System.Buffers.Binary;
using System.Reflection;
using System.Runtime.InteropServices;

namespace nylium.Extensions {

    unsafe delegate void MemCpyImpl(byte* src, byte* dest, int len);

    public static class BigEndianExtensions {

        static MemCpyImpl memcpyimpl = (MemCpyImpl) Delegate.CreateDelegate(
            typeof(MemCpyImpl), typeof(Buffer).GetMethod("memcpyimpl",
                BindingFlags.Static | BindingFlags.NonPublic));

        unsafe private static void UnsafeCopy(byte[] _in, byte[] _out) {
            fixed(byte* pSrc = _in)
            fixed(byte* pDest = _out)
                memcpyimpl(pSrc, pDest, _in.Length);
        }

        unsafe public static float ReadBigEndianF(this byte[] x) {
            if(BitConverter.IsLittleEndian) {
                byte[] buffer = new byte[4];

                UnsafeCopy(x, buffer);

                x[0] = buffer[3];
                x[1] = buffer[2];
                x[2] = buffer[1];
                x[3] = buffer[0];
            }

            int val = x[0] | (x[1] << 8) | (x[2] << 16) | (x[3] << 24);
            return *(float*) &val;
        }

        unsafe public static byte[] WriteBigEndian(this float x) {
            byte* value = (byte*) &x;
            byte[] buffer = new byte[4];

            if(BitConverter.IsLittleEndian) {
                buffer[0] = value[3];
                buffer[1] = value[2];
                buffer[2] = value[1];
                buffer[3] = value[0];
            } else {
                buffer[0] = value[0];
                buffer[1] = value[1];
                buffer[2] = value[2];
                buffer[3] = value[3];
            }

            return buffer;
        }

        unsafe public static double ReadBigEndianD(this byte[] x) {
            if(BitConverter.IsLittleEndian) {
                byte[] buffer = new byte[8];

                UnsafeCopy(x, buffer);

                x[0] = buffer[7];
                x[1] = buffer[6];
                x[2] = buffer[5];
                x[3] = buffer[4];
                x[4] = buffer[3];
                x[5] = buffer[2];
                x[6] = buffer[1];
                x[7] = buffer[0];
            }

            // TODO faster way to do this
            return BitConverter.ToDouble(x);
        }

        unsafe public static byte[] WriteBigEndian(this double x) {
            byte* value = (byte*) &x;
            byte[] buffer = new byte[8];

            if(BitConverter.IsLittleEndian) {
                buffer[0] = value[7];
                buffer[1] = value[6];
                buffer[2] = value[5];
                buffer[3] = value[4];
                buffer[4] = value[3];
                buffer[5] = value[2];
                buffer[6] = value[1];
                buffer[7] = value[0];
            } else {
                buffer[0] = value[0];
                buffer[1] = value[1];
                buffer[2] = value[2];
                buffer[3] = value[3];
                buffer[4] = value[4];
                buffer[5] = value[5];
                buffer[6] = value[6];
                buffer[7] = value[7];
            }

            return buffer;
        }

        public static ushort ReadBigEndianUS(this byte[] x) {
            return BinaryPrimitives.ReadUInt16BigEndian(x);
        }

        public static uint ReadBigEndianUI(this byte[] x) {
            return BinaryPrimitives.ReadUInt16BigEndian(x);
        }

        public static ulong ReadBigEndianUL(this byte[] x) {
            return BinaryPrimitives.ReadUInt64BigEndian(x);
        }

        public static short ReadBigEndianS(this byte[] x) {
            return BinaryPrimitives.ReadInt16BigEndian(x);
        }

        public static int ReadBigEndianI(this byte[] x) {
            return BinaryPrimitives.ReadInt16BigEndian(x);
        }

        public static long ReadBigEndianL(this byte[] x) {
            return BinaryPrimitives.ReadInt64BigEndian(x);
        }

        public static byte[] WriteBigEndianU(this ushort x) {
            byte[] b = new byte[2];
            BinaryPrimitives.WriteUInt16BigEndian(b, x);

            return b;
        }

        public static byte[] WriteBigEndianU(this uint x) {
            byte[] b = new byte[4];
            BinaryPrimitives.WriteUInt32BigEndian(b, x);

            return b;
        }

        public static byte[] WriteBigEndianU(this ulong x) {
            byte[] b = new byte[8];
            BinaryPrimitives.WriteUInt64BigEndian(b, x);

            return b;
        }

        public static byte[] WriteBigEndian(this short x) {
            byte[] b = new byte[2];
            BinaryPrimitives.WriteInt16BigEndian(b, x);

            return b;
        }

        public static byte[] WriteBigEndian(this int x) {
            byte[] b = new byte[4];
            BinaryPrimitives.WriteInt32BigEndian(b, x);

            return b;
        }

        public static byte[] WriteBigEndian(this long x) {
            byte[] b = new byte[8];
            BinaryPrimitives.WriteInt64BigEndian(b, x);

            return b;
        }
    }
}