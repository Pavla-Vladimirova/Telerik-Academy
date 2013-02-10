using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.QuadraticEquation
{
    class QuadraticEquation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write \"a\" ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Write \"b\" ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Write \"c\"");
            double c = double.Parse(Console.ReadLine());
            double d = (b * b) - (4 * a * c);
            double x1;
            double x2;

            if (d == 0)
            {
                x1 = -b / (2 * a);
                Console.WriteLine("There is one double root x1=x2= {0}", x1);
            }
            else
            {
                if (d > 0)
                {
                    x1 = (-b + Math.Sqrt(d)) / (2 * a);
                    x2 = (-b - Math.Sqrt(d)) / (2 * a);
                    Console.WriteLine("The first root x1={0}", x1);
                    Console.WriteLine("The first root x2={0}", x2);
                }
                else
                {
                    Console.WriteLine("There is no real roots");
                }
            }
        }
    }
}
