using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _09.CatalanNumbers
{
    class CatalanNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write N");
            int n = int.Parse(Console.ReadLine());
            BigInteger factorialN = 1;
            BigInteger factorial2N = 1;
            BigInteger factorialNPlus1 = 1;
            int TwoN = 2 * n;
            int NPlusOne = n + 1;

            while (n >= 1)
            {
                factorialN = factorialN * n;
                n--;
            }
            while (TwoN >= 1)
            {
                factorial2N = factorial2N * TwoN;
                (TwoN)--;
            }
            while (NPlusOne >= 1)
            {
                factorialN = factorialN *NPlusOne;
                NPlusOne--;
            }

            BigInteger CatalanNumber = factorial2N / (factorialNPlus1 * factorialN);
            Console.WriteLine("Catalan N number is {0}",CatalanNumber);
        }
    }
}
