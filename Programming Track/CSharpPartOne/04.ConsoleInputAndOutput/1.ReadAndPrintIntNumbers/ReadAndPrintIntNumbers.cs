using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.ReadAndPrintIntNumbers
{
    class ReadAndPrintIntNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write the first number");
            int firstNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Write the second number");
            int secondNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Write the third number");
            int thirdNum = int.Parse(Console.ReadLine());
            int sum = firstNum + secondNum + thirdNum;
            Console.WriteLine("The sum of the numbers is {0}",sum);
        }
    }
}
