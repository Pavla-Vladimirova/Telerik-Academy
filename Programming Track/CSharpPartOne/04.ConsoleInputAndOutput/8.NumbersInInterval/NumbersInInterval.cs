using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.NumbersInInterval
{
    class NumbersInInterval
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a number for n");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("The numbers from 1 to n are:");
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
