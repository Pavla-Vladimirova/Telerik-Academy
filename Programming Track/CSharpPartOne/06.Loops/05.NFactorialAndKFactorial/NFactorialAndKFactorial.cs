using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _05.NFactorialAndKFactorial
{
    class NFactorialAndKFactorial
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write N");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Write K");
            int k = int.Parse(Console.ReadLine());
            BigInteger factorialN = 1;
            BigInteger factorialK = 1;
            BigInteger factorialNMinusK = 1;
            int NMinusK = n - k;

            while ((n >= 1)&&(k >= 1) && (k < n)&&(NMinusK>=1))
            {
                factorialNMinusK = factorialNMinusK * NMinusK;
                NMinusK--;
            }
            while ((k >= 1) && (k < n))
            {
                factorialK = factorialK * k;
                k--;
            }
            while (n >= 1)
            {
                factorialN = factorialN * n;
                n--;
            }

            BigInteger finalResult = (factorialN * factorialK) / factorialNMinusK;
            Console.WriteLine("The result form N!*K!/(N-K)! is {0}", finalResult);
        }
    }
}
