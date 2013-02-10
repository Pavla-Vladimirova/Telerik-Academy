using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.HexadecimalToBinaryDirectly
{
    class HexadecimalToBinaryDirectly
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write number in hexadecimal");
            string numberInHexadecimal = Console.ReadLine();
            List<int> numberInBinary = new List<int>();
            int number = 0;

            for (int i = numberInHexadecimal.Length - 1; i >= 0; i--)
            {
                switch (numberInHexadecimal[i])
                {
                    case 'A': number = 10; break;
                    case 'B': number = 11; break;
                    case 'C': number = 12; break;
                    case 'D': number = 13; break;
                    case 'E': number = 14; break;
                    case 'F': number = 15; break;
                    default: number = Convert.ToInt32(numberInHexadecimal[i].ToString()); break;
                }
                for (int j = 0; j < 4; j++)
                {
                    numberInBinary.Add(number % 2);
                    number /= 2;
                }               
            }
            numberInBinary.Reverse();
            for (int i = 0; i < numberInBinary.Count; i++)
            {
                Console.Write(numberInBinary[i]);
            }
            Console.WriteLine();
        }
    }
}
