using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.ExchangeBitPositionsQwithP
{
    class SwapBitsExchangeBitsPwithQ
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a positive integer: ");
            uint number = uint.Parse(Console.ReadLine());
            Console.WriteLine("{0} in binary: {1}", number, Convert.ToString(number, 2).PadLeft(32, '0'));
            Console.WriteLine("write p-bit:");
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine("write q-bit:");
            int q = int.Parse(Console.ReadLine());
            Console.WriteLine("write how many k-bits you want to swap:");
            int k = int.Parse(Console.ReadLine());
            uint numberWithSwappedBits = number;
            uint mask = 0;
            uint firstBit = 0;
            int position = q; //24

            for (int i = p; i <= (p + k - 1); i++)
            {
                mask = (uint)(1 << i);
                firstBit = (number & mask) >> i;
                if (firstBit == 0)
                {
                    mask = (uint)~(1 << position);
                    numberWithSwappedBits = numberWithSwappedBits & mask;
                }
                else
                {
                    mask = (uint)(1 << position);
                    numberWithSwappedBits = numberWithSwappedBits | mask;
                }
                position++;
            }

            int otherPosition = p; //3
            for (int i = q; i <= (q + k - 1); i++)
            {
                mask = (uint)(1 << i);
                firstBit = (number & mask) >> i;
                if (firstBit == 0)
                {
                    mask = (uint)~(1 << otherPosition);
                    numberWithSwappedBits = numberWithSwappedBits & mask;
                }
                else
                {
                    mask = (uint)(1 << otherPosition);
                    numberWithSwappedBits = numberWithSwappedBits | mask;
                }
                otherPosition++;
            }

            Console.WriteLine("The swapping: {0}", Convert.ToString(numberWithSwappedBits, 2).PadLeft(32, '0'));
        }
    }
}
