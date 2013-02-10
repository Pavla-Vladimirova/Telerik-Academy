using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _04.FindsNFactorielDividedByKFactoriel
{
    class FindsNFactorialDividedByKFactorial
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write N");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Write K");
            int k = int.Parse(Console.ReadLine());
            BigInteger factorialN = 1;
            BigInteger factorialK = 1;

            while ((k >= 1) && (k < n))
            {
                factorialK = factorialK * k;
                k--;
            }
            while (n>=1)
            {
                factorialN = factorialN * n;
                n--;
            }

            BigInteger result = factorialN / factorialK;
            Console.WriteLine("The result form N!/K! is {0}",result);
        }
    }
}
