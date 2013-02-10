using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.GreaterNumberOfTwoNumbers
{
    class GreaterNumberOfTwoNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("Write the firs number to compare: ");
            int firstNum = int.Parse(Console.ReadLine());
            Console.Write("Write the second number: ");
            int secondNum = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Max(firstNum, secondNum));
        }
    }
}
