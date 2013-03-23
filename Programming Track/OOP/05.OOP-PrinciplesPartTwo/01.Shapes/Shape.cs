using System;
using System.Linq;

namespace _01.Shapes
{
    public abstract class Shape
    {
        private int width;
        private int height;

        public int Width
        {
            get
            {
                return this.width;
            }
            set
            {
                this.width = value;
            }
        }

        public int Height
        {
            get
            {
                return this.height;
            }
            set
            {
                this.height = value;
            }
        }

        public abstract double CalculateSurface();
    }
}
