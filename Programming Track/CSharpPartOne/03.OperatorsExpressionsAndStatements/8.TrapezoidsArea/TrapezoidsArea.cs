using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.TrapezoidsArea
{
    class TrapezoidsArea
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a number for the small base of the trapezoid");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Write a number for the big base of the trapezoid");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Write a number for the height of the trapezoid");
            float h = float.Parse(Console.ReadLine());
            float area = (a + b) / (2 * h);
            Console.WriteLine("The area of the trapezoid is: {0}",area);
        }
    }
}
