using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.ReverseTheDigitsOfDecimalNumber
{
    class ReverseTheDigitsOfDecimalNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write number to reverse");
            int inputNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("The reversed number is {0} ",ReverseNumber(inputNumber));
        }

        static int ReverseNumber(int number)
        {           
            int currentDigit=0;
            int reversed = 0;
            while (number > 0)
            {
                currentDigit = number % 10;
                reversed = reversed * 10 + currentDigit;
                number = number / 10;  
            }
            return reversed;
        }
    }
}
