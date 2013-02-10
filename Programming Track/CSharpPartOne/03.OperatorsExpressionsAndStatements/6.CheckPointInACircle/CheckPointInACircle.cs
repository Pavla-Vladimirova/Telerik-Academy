using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.CheckPointInACircle
{
    class CheckPointInACircle
    {
        static void Main(string[] args)
        {
            // Our cicrle is with cordinates K((0,0),5) so it's center is (x=0,y=0) and it's radius is 5
            Console.WriteLine("Write the \"x\" cordinate of your pont");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Write the \"y\" cordinate of your pont");
            int y = int.Parse(Console.ReadLine());
            bool check2 = ((Math.Sqrt(x*x+y*y))<=5);
            Console.WriteLine(check2 ? "Your point is in the circle" : "Your point is out of the circle");
        }
    }
}
