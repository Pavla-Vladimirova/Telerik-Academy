using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.WeAllLoveBits
{
    class WeAllLoveBits
    {
        static void Main(string[] args)
        {
            ushort N = ushort.Parse(Console.ReadLine());
            uint[] numbers = new uint[N];

            for (int i = 0; i < N; i++)
            {
                numbers[i] = uint.Parse(Console.ReadLine());
            }

            uint newP = 0;
            uint reverseP = 0;
            for (int i = 0; i < N; i++)
            {
                reverseP = numbers[i];
                char[] chars = Convert.ToString(reverseP, 2).ToCharArray();
                Array.Reverse(chars);
                reverseP = Convert.ToUInt32(new string(chars), 2);
                newP = (numbers[i] ^ (~numbers[i])) & reverseP;
                Console.WriteLine(newP);
            }
        }
    }
}
