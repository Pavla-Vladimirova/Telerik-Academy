using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.RectanglesArea
{
    class RectanglesArea
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write the height of the rectangle");
            float height = float.Parse(Console.ReadLine());
            Console.WriteLine("Write the width of the rectangle");
            float width = float.Parse(Console.ReadLine());
            float area = (height * width);
            Console.WriteLine("The area of the rectangle is: {0}",area);
        }
    }
}
