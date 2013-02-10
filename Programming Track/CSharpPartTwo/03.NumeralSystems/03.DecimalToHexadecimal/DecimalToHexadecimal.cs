using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.DecimalToHexadecimal
{
    class DecimalToHexadecimal
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write number in decimal");
            long numberInDecimal = long.Parse(Console.ReadLine());
            List<char> numberInHexadecimal = new List<char>();
            long currentDigit = 0;

            while (numberInDecimal > 0)
            {
                currentDigit = numberInDecimal % 16;
                switch (currentDigit)
                {
                    case 10: numberInHexadecimal.Add('A'); break;
                    case 11: numberInHexadecimal.Add('B'); break;
                    case 12: numberInHexadecimal.Add('C'); break;
                    case 13: numberInHexadecimal.Add('D'); break;
                    case 14: numberInHexadecimal.Add('E'); break;
                    case 15: numberInHexadecimal.Add('F'); break;
                    default: numberInHexadecimal.Add(Convert.ToChar(Convert.ToString(currentDigit))); break;

                }
                numberInDecimal /= 16;
            }
            numberInHexadecimal.Reverse();
            for (int i = 0; i < numberInHexadecimal.Count; i++)
            {
                Console.Write(numberInHexadecimal[i]);
            }
            Console.WriteLine();
        }
    }
}
