using System.IO;

namespace WEMSharp
{
    internal class BitStream
    {
        private Stream _stream;
        private byte _bitBuffer;
        private int _bitsLeft;
        internal ulong TotalBitsRead { get; private set; }

        public BitStream(Stream stream)
        {
            this._stream = stream;
        }

        internal byte GetBit()
        {
            if (this._bitsLeft == 0)
            {
                this._bitBuffer = (byte)this._stream.ReadByte();
                this._bitsLeft = 8;
            }

            this.TotalBitsRead++;
            this._bitsLeft--;

            return (this._bitBuffer & (0x80 >> this._bitsLeft)) != 0 ? (byte)1 : (byte)0;
        }

        internal uint Read(int bitCount)
        {
            uint result = 0;

            for (int i = 0; i < bitCount; i++)
            {
                if (GetBit() == 1)
                {
                    result |= (1U << i);
                }
            }

            return result;
        }
    }
}
