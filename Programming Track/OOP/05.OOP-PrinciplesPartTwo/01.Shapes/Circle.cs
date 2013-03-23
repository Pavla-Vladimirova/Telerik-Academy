using System;
using System.Linq;

namespace _01.Shapes
{
    public class Circle : Shape
    {
        public Circle(int radius)
        {
            this.Width = radius;
            this.Height = radius;
        }

        public override double CalculateSurface()
        {
            return this.Width * this.Height * Math.PI;
        }
    }
}
