using System;
using System.Linq;

namespace _01.Shapes
{
    public class Triangle : Shape
    {
        public Triangle(int width,int height)
        {
            this.Width = width;
            this.Height = height;
        }

        public override double CalculateSurface()
        {
            return (this.Width * this.Height)/2;
        }
    }
}
