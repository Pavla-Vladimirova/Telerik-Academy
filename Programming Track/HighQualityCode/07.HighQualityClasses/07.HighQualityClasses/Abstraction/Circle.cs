﻿using System;

namespace Abstraction
{
    class Circle : Figure
    {
        public Circle(double radius) : base(radius, radius)
        {
        }

        public override double CalcPerimeter()
        {
            double perimeter = 2 * Math.PI * this.Width;
            return perimeter;
        }

        public override double CalcSurface()
        {
            double surface = Math.PI * this.Width * this.Width;
            return surface;
        }
    }
}
