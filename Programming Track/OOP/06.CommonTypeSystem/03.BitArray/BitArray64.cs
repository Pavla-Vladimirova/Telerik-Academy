using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.BitArray
{
    public class BitArray64 : IEnumerable<int>
    {
        public const int BitsCount = 64;
        private ulong number;
        private int[] bits;

        public BitArray64(ulong number)
        {
            this.Number = number;
            ulong mask=1;
            this.Bits = new int[BitsCount];
            for (int i = 0; i < BitsCount; i++)
            {
                this.Bits[i] = (int)(this.Number & (mask<< i))>>i;
            }
        }

        public ulong Number
        {
            get
            {
                return this.number;
            }
            set
            {
                this.number = value;
            }
        }

        public int[] Bits
        {
            get
            {
                return this.bits;
            }
            set
            {
                this.bits = value;
            }
        }

        public int this[int index]
        {
            get 
            {
                if ((index > BitsCount-1) || (index < 0))
                {
                    throw new IndexOutOfRangeException(String.Format(
                     "The Array capacity of {0} elements  was exceeded.", this.Bits.Length));
                }
                return this.Bits[index];
            }
            set 
            {
                if ((index > BitsCount-1) || (index < 0))
                {
                    throw new IndexOutOfRangeException(String.Format(
                     "The Array capacity of {0} elements  was exceeded.", this.Bits.Length));
                }
                this.Bits[index]=value;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public IEnumerator<int> GetEnumerator()
        {
            foreach (var bit in this.Bits)
            {
                yield return bit;
            }
        }

        public override bool Equals(object obj)
        {
            BitArray64 bitsToEqual = obj as BitArray64;
            for (int i = 0; i < BitsCount; i++)
            {
                if (this.Bits[i]!=bitsToEqual.Bits[i])
                {
                    return false;
                }
            }
            return true;
        }

        public static bool operator ==(BitArray64 bits1,BitArray64 bits2)
        {
            return BitArray64.Equals(bits1, bits2);
        }

        public static bool operator !=(BitArray64 bits1, BitArray64 bits2)
        {
            return !(BitArray64.Equals(bits1, bits2));
        }

        public override int GetHashCode()
        {
            return (this.Number.GetHashCode()^123928172);
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            for (int i = 0; i < BitsCount; i++)
            {
                str.Append(this.Bits[BitsCount - 1 - i]);
            }
            return str.ToString();
        }
    }
}
