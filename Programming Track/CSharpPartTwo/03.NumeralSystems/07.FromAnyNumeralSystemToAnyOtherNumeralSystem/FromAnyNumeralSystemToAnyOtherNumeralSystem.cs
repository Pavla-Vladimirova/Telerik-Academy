using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.FromAnyNumeralSystemToAnyOtherNumeralSystem
{
    class FromAnyNumeralSystemToAnyOtherNumeralSystem
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write first base S");
            int S = int.Parse(Console.ReadLine());
            Console.WriteLine("Write the other base D");
            int D = int.Parse(Console.ReadLine());
            Console.WriteLine("Write number N");
            string number = Console.ReadLine();
            int numberInDecimal = 0;

            //form first numeral system to 10
            for (int i = number.Length - 1; i >= 0; i--)
            {
                if (Char.IsLetter(number[i])==true)
                {
                    numberInDecimal+=((int)number[i] - (int)'0' - 7)*(int)Math.Pow(S, (number.Length - 1 - i));
                }
                else
                {
                    numberInDecimal += Convert.ToInt32(number[i].ToString()) * (int)Math.Pow(S, (number.Length - 1 - i));
                }
            }
         
            //form 10 to second numeral  system
            List<char> numberInSecondBase = new List<char>();
            int currentDigit = 0;
            while (numberInDecimal > 0)
            {
                currentDigit = numberInDecimal % D;
                if (currentDigit>=10)
                {
                    int asciiCode = currentDigit + (int)'0' + 7;
                    numberInSecondBase.Add((char)asciiCode);
                }
                else
                {
                    numberInSecondBase.Add(Convert.ToChar(Convert.ToString(currentDigit)));
                }            
                numberInDecimal /= D;
            }        
            numberInSecondBase.Reverse();            
            for (int i = 0; i < numberInSecondBase.Count; i++)
            {
                Console.Write(numberInSecondBase[i]);
            }
            Console.WriteLine();
        }
    }
}
