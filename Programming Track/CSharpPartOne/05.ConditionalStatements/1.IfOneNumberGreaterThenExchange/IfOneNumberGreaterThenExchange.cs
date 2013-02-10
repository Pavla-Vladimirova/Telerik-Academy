using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.IfOneNumberGreaterThenExchange
{
    class IfOneNumberGreaterThenExchange
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wrtie two numbers to compare");
            Console.WriteLine("Write the first one:");
            int firstNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Write the second one:");
            int secondNum = int.Parse(Console.ReadLine());
            int exchange;
            if (firstNum>secondNum)
            {
                exchange = firstNum;
                firstNum = secondNum;
                secondNum = exchange;
                Console.WriteLine("The first number now has value {0}",firstNum);
                Console.WriteLine("The second number now has value {0}",secondNum);
            }
            else
            {
                Console.WriteLine("The first number is not grater than the second one so they will not be exchanged");
            }
        }
    }
}
