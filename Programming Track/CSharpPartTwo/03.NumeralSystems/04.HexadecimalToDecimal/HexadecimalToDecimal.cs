using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.HexadecimalToDecimal
{
    class HexadecimalToDecimal
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write number in hexadecimal");
            string numberInHexadecimal = Console.ReadLine();
            int numberInDecimal = 0;

            for (int i = numberInHexadecimal.Length - 1; i >= 0; i--)
            {
                switch (numberInHexadecimal[i])
                {
                    case 'A': numberInDecimal += 10 * (int)Math.Pow(16, (numberInHexadecimal.Length - 1 - i)); break;
                    case 'B': numberInDecimal += 11 * (int)Math.Pow(16, (numberInHexadecimal.Length - 1 - i)); break;
                    case 'C': numberInDecimal += 12 * (int)Math.Pow(16, (numberInHexadecimal.Length - 1 - i)); break;
                    case 'D': numberInDecimal += 13 * (int)Math.Pow(16, (numberInHexadecimal.Length - 1 - i)); break;
                    case 'E': numberInDecimal += 14 * (int)Math.Pow(16, (numberInHexadecimal.Length - 1 - i)); break;
                    case 'F': numberInDecimal += 15 * (int)Math.Pow(16, (numberInHexadecimal.Length - 1 - i)); break;
                    default: numberInDecimal += Convert.ToInt32(numberInHexadecimal[i].ToString()) * (int)Math.Pow(16, (numberInHexadecimal.Length - 1 - i)); break;
                }
            }
            Console.WriteLine(numberInDecimal);
        }
    }
}
