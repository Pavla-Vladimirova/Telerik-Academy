using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _9.FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            BigInteger a = new BigInteger(0);
            BigInteger b = new BigInteger(1);
            BigInteger n = new BigInteger();
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(a);
                n = a + b;
                b = a;
                a = n;
            }
        }
    }
}
