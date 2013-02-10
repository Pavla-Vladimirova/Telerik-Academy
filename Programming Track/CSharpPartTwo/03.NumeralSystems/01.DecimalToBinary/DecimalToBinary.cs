using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DecimalToBinary
{
    class DecimalToBinary
    {
        static void Main(string[] args)
        {
            //for both positive and negative numbers for Int64
            Console.WriteLine("Write a number in decimal");
            long numberInDecimal = long.Parse(Console.ReadLine());
            long negativeNumberInDecimal = 0;
            List<long> numberInBinary = new List<long>();

            if (numberInDecimal<0)
            {
                negativeNumberInDecimal = numberInDecimal;
                numberInDecimal = (long.MaxValue + numberInDecimal) + 1;
            }

            while (numberInDecimal > 0)
            {
                numberInBinary.Add(numberInDecimal % 2);
                numberInDecimal = numberInDecimal / 2;
            }

            if (negativeNumberInDecimal < 0)
            {
                for (int i = numberInBinary.Count; i < 64; i++)
                {
                    numberInBinary.Add(0);
                }
                numberInBinary.Reverse();
                numberInBinary[0] = 1;
            }
            else
            {
                numberInBinary.Reverse();
            }

            for (int i = 0; i < numberInBinary.Count; i++)
            {
                Console.Write(numberInBinary[i]);
            }
            Console.WriteLine();
        }
    }
}
