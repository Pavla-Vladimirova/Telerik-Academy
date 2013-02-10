using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.CheckPointInACircleAndOutRectangle
{
    class CheckPointInACircleAndOutOfRectangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write the \"x\" cordinate of your pont");
            sbyte x = sbyte.Parse(Console.ReadLine());
            Console.WriteLine("Write the \"y\" cordinate of your pont");
            sbyte y = sbyte.Parse(Console.ReadLine());
            bool inCircle = ((Math.Sqrt(x * x + y * y)) <= 5);
            Console.WriteLine(inCircle ? "Your point is in the circle" : "Your point is out of the circle");
            bool outOfRectangle=((x<=-1)||(x>=5))&&((y<=1)||(y>=5));
            Console.WriteLine(outOfRectangle ? "Your point is out of the rectangle" : "Your point is in  the rectangle");
            bool inAndOut=(inCircle&&outOfRectangle);
            Console.WriteLine(inAndOut ? "Your point is at the same time IN the circle and OUT of the rectangle" : "Your point IS NOT at the same time in the circle and OUT of the rectangle");
        }
    }
}
