using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.PerimeterAndAreaOfCircle
{
    class PerimeterAndAreaOfCircle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write radius of a circle");
            double radius = double.Parse(Console.ReadLine());
            double perimeter = 2 * Math.PI * radius;   
            double area = Math.PI * radius * radius;
            Console.WriteLine("The perimeter of the circle is {0} and the area is {1}",perimeter,area);
        }
    }
}
