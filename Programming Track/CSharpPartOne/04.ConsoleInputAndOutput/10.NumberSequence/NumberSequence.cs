using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.NumberSequence
{
    class NumberSequence
    {
        static void Main(string[] args)
        {
            decimal n = 1m;
            decimal a = 2m;
            decimal s = 1m;
            decimal sum = n;
            decimal oldSum = 1m;
            do
            {                
                oldSum = sum;
                n = 1 / a;
                a = a + 1;
                n = n * s;
                s = s * (-1);
                sum = sum + n;              
                
            } while (Math.Abs(sum - oldSum) >=0.001m);
            Console.WriteLine("The sum of the numbers is {0}",sum);           
        }
    }
}
