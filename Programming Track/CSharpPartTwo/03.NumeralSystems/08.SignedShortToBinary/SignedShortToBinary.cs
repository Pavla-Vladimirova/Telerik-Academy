using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.SignedShortToBinary
{
    class SignedShortToBinary
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a number in decimal");
            int numberInDecimal = int.Parse(Console.ReadLine());
            int negativeNumberInDecimal = 0;
            List<int> numberInBinary = new List<int>();

            if (numberInDecimal < 0)
            {
                negativeNumberInDecimal = numberInDecimal;
                numberInDecimal = (short.MaxValue + numberInDecimal) + 1;
            }

            while (numberInDecimal > 0)
            {
                numberInBinary.Add(numberInDecimal % 2);
                numberInDecimal = numberInDecimal / 2;
            }           
           
            if (negativeNumberInDecimal < 0)
            {
                for (int i = numberInBinary.Count; i < 16; i++)
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
