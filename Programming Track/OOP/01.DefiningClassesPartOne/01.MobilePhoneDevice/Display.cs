using System;
using System.Linq;

//01.define class Display
//02.Define several constructors for the defined classes that take different sets of arguments (the full information for the class or part of it).
//All unknown data fill with null.
//05.Use properties to encapsulate the data fields inside the Display class.Ensure all fields hold correct data at any given time.

namespace _01.MobilePhoneDevice
{
    public class Display
    {
        private float displaySize;
        private int numberOfDisplayColors;

        public Display()
            :this(0,0)
        { 
        }

        public Display(float displaySize,int numberOfDisplayColors)
        {
            this.DisplaySize = displaySize;
            this.NumberOfDisplayColors = numberOfDisplayColors;
        }

        public float DisplaySize
        {
            get { return this.displaySize; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid display size! Write bigger than zero!");
                }
                else
                {
                    this.displaySize = value; 
                }
            }
        }

        public int NumberOfDisplayColors
        {
            get { return this.numberOfDisplayColors; }
            set 
            { 
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid number of colors! Write bigger than zero!");
                }
                else
                {
                    this.numberOfDisplayColors = value;
                }
            }
        }

        public override string ToString()
        {
            return string.Format("\n -Display size: {0}\"; \n -Number of display colors: {1};",
                this.DisplaySize,this.NumberOfDisplayColors);
        }
    }
}
