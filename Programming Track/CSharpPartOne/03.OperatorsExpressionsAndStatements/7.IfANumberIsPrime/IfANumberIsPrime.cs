using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.IfANumberIsPrime
{
    class IfANumberIsPrime
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Write a number <= 100");
           int number=int.Parse(Console.ReadLine());
           bool check = true;
           for (int i = 2; i <= Math.Sqrt(number); i++)
           {
               check = true;
               if (number == 2)
               {
                   Console.WriteLine("The number is prime");
                   check = false;
                   break;
               }
               else if ((number % i) == 0)
               {
                   Console.WriteLine("the number is  NOT prime");
                   check = false;
                   break;
               }
           }
           if (check==true)
           {
               Console.WriteLine("The number is prime");
           }
        }
    }
}
