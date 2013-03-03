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
            bool inCircle =(Math.Sqrt((x - 1) * (x - 1) + (y - 1) * (y - 1))) <= 3;
            Console.WriteLine(inCircle ? "Your point is in the circle K( (1,1), 3)" : "Your point is out of the circle K( (1,1), 3)");

            bool inRectangle = ((x <= 7) && (x >= 1)) && ((y <= -1) && (y >= -3));
            Console.WriteLine(inRectangle ? "Your point is in  the rectangle R(top=1, left=-1, width=6, height=2)" : "Your point is out of the rectangle R(top=1, left=-1, width=6, height=2)");
            
            bool inAndOut=((inCircle==true)&&(inRectangle==false));
            Console.WriteLine(inAndOut ? "Your point is at the same time IN the circle K( (1,1), 3) and OUT of the rectangle R(top=1, left=-1, width=6, height=2)" : "Your point IS NOT at the same time in the circle K( (1,1), 3) and OUT of the rectangle R(top=1, left=-1, width=6, height=2)");
        }
    }
}
