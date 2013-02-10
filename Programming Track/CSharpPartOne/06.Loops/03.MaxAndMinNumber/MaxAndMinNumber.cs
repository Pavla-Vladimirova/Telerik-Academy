using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MaxAndMinNumber
{
    class MaxAndMinNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wrtie N");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Write the first number");
            int firstNumber = int.Parse(Console.ReadLine());
           
            int minNumber=firstNumber;
            int maxNumber=firstNumber;
            for (int i = 1; i <= n-1; i++)
            {
                Console.WriteLine("Write a number");
                int number = int.Parse(Console.ReadLine());
                if (number<minNumber)
                {
                    minNumber = number;
                }
                if (number>maxNumber)
                {
                    maxNumber = number;
                }
            }
            Console.WriteLine("The minimum number is {0} and the maximum number is {1} ",minNumber,maxNumber);
        }
    }
}
