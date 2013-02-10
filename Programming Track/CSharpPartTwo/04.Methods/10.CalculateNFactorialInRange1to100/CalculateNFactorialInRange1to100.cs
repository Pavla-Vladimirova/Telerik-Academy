using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _10.CalculateNFactorialInRange1to100
{
    class CalculateNFactorialInRange1to100
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write N");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine(CalculateFactorial(N));
        }

        static BigInteger CalculateFactorial(int number)
        {
            BigInteger factorial = 1;
            if (number==0)
            {
                factorial = 0;
            }
            else
            {
                while (number > 0)
                {
                    factorial *= number;
                    number--;
                }
            }           
            return factorial;
        }
    }
}
