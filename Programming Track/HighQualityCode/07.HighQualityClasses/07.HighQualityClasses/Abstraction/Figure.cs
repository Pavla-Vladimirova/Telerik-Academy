using System;

namespace Abstraction
{
    abstract class Figure
    {
        private double width;
        private double height;

        public Figure(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get 
            { 
                return width;
            }
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Input values of the figure cannot be equal to or smaller than zero");
                }
                width = value;
            }
        }

        public double Height
        {
            get 
            {
                return height;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Input values of the figure cannot be equal to or smaller than zero");
                }
                height = value;
            }
        }

        public abstract double CalcPerimeter();
        public abstract double CalcSurface();
    }
}
