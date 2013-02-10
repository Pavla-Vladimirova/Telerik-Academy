using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.OddOrEven
{
    class OddOrEven
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a number");
            int numToCheck = int.Parse(Console.ReadLine());
            if (numToCheck % 2 == 0)
            {
                Console.WriteLine("The number is even");
            }
            else
            {
                Console.WriteLine("The number is odd");
            }
        }
    }
}
