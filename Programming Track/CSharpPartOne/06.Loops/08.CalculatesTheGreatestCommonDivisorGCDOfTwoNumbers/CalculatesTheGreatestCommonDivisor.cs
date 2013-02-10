using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CalculatesTheGreatestCommonDivisorGCDOfTwoNumbers
{
    class CalculatesTheGreatestCommonDivisor
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wrtie first number");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Wrtie second number");
            int secondNumber = int.Parse(Console.ReadLine());
            int mod = firstNumber;
            int mod2 = secondNumber;
            int gcd = 0;

            if (secondNumber == 0)
            {
                gcd = firstNumber;
                Console.WriteLine("The GCD is {0}", gcd);
            }
            while ((mod2>0)&&(mod>0))
            {
                gcd = mod2;
                mod = mod % mod2;
                if (mod == 0)
                {
                    Console.WriteLine("The GCD is {0}", gcd);  
                }
                else
                {
                    gcd = mod;
                    mod2 = mod2 % mod;
                    if (mod2==0)
                    {
                        Console.WriteLine("The GCD is {0}", gcd);
                    }
                }    
            }
        }
    }
}
