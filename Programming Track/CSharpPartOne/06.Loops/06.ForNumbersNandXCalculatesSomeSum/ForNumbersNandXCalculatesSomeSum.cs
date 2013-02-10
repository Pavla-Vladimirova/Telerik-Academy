using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _06.ForNumbersNandXCalculatesSomeSum
{
    class ForNumbersNandXCalculatesSomeSum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write N");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Write X");
            int x = int.Parse(Console.ReadLine());

            decimal sum = 1;
            for (int i = 1; i <= n; i++)
            {
                int k = i;
                decimal factorialN = 1;
                while (k>=1)
                {
                    factorialN *= k;
                    k--;
                }
                sum = sum + factorialN / (decimal)Math.Pow(x, i);
            }
            Console.WriteLine("The sum is {0}",sum);
        }
    }
}
