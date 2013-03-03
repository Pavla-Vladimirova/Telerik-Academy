using System;
using System.Linq;

//01.Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space. Implement the ToString() to enable printing a 3D point.
//02.Add a private static read-only field to hold the start of the coordinate system – the point O{0, 0, 0}. Add a static property to return the point O.

namespace _01._3DSpace
{
    public struct Point3D
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        private static Point3D startCoordinates = new Point3D(0, 0, 0);

        public Point3D(int x,int y,int z)
            :this() 
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public static Point3D StartCoordinates
        {
            get { return startCoordinates; }
            set { startCoordinates = value; }
        }

        public override string ToString()
        {
            return string.Format("Point: {0} {1} {2} ",this.X,this.Y,this.Z);
        }
    }
}
