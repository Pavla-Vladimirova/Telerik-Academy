using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.nNumbers
{
    class nNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a number");
            int number = int.Parse(Console.ReadLine());
            int sum=number;
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine("Write another number");
                int anotherNum = int.Parse(Console.ReadLine());
                sum = sum + anotherNum;
            }
            Console.WriteLine("The sum of the n-numbers(including first number) is {0}",sum);
        }
    }
}
