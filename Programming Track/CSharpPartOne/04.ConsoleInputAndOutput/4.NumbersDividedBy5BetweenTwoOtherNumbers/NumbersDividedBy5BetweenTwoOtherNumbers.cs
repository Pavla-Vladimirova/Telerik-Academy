using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.NumbersDividedBy5BetweenTwoOtherNumbers
{
    class NumbersDividedBy5BetweenTwoOtherNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write the first number");
            int firstNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Write the second number");
            int secondNum = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int p=0;
            for (int i=firstNum; i<=secondNum; i++)
            {
                if ((i % 5) == 0)
                {
                    p += 1 ;
                }
            }
            Console.WriteLine(p);
        }
    }
}
