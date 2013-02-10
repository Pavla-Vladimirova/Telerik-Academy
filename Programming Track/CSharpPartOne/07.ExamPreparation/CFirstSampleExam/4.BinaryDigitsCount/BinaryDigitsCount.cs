using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.BinaryDigitsCount
{
    class BinaryDigitsCount
    {
        static void Main(string[] args)
        {
            byte binaryDigit = byte.Parse(Console.ReadLine());
            ushort N = ushort.Parse(Console.ReadLine());
                                  
            for (int i = 1; i <= N; i++)
            {
                uint number = uint.Parse(Console.ReadLine());
                int sum0 = 0;
                int sum1 = 0;
                while (number > 0)
                {
                    if (0 != (number & 1))
                    {
                        sum1++;
                    }
                    if (0 == (number & 1))
                    {
                        sum0++;
                    }
                    number >>= 1;
                }

                if (binaryDigit == 1)
                {
                    Console.WriteLine(sum1);
                }
                else
                {
                    Console.WriteLine(sum0);
                }
            }
        }
    }
}
