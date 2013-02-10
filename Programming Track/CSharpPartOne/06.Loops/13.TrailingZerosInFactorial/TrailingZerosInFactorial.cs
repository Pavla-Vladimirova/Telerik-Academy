using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _13.TrailingZerosInFactorial
{
    class TrailingZerosInFactorial
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write N");
            int n = int.Parse(Console.ReadLine());
            BigInteger factorial = 1;
            int k = n;

            while (n >= 1)
            {
                factorial = factorial * n;
                n--;
            }
            int trailingZeros = k / 5;
            Console.WriteLine("{0}! is {1} ",k,factorial);
            Console.WriteLine("The trailing zeros in {0}! is {1}",k,trailingZeros );
        }
    }
}
