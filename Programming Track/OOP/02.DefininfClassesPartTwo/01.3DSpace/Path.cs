using System;
using System.Collections.Generic;
using System.Linq;

//04.Create a class Path to hold a sequence of points in the 3D space. 

namespace _01._3DSpace
{
    public class Path
    {
        private List<Point3D> pathOfPoints=new List<Point3D>();
        private Random randomNumber = new Random();

        public Path()
        {
        }

        public List<Point3D> PathOfPoints
        {
            get{ return this.pathOfPoints; }
            set{ this.pathOfPoints = value; }
        }

        public void AddPoint()
        {
            int X = randomNumber.Next(1, 100);
            int Y = randomNumber.Next(1, 100);
            int Z = randomNumber.Next(1, 100);
            Point3D newPoint = new Point3D(X,Y,Z);
            this.PathOfPoints.Add(newPoint);
        }

        public void AddPointWithGivenCoordinates(int x,int y,int z)
        {
            Point3D newPoint = new Point3D(x, y, z);
            this.PathOfPoints.Add(newPoint);
        }

        public void PrintPath()
        {
            Console.WriteLine("Path:");
            foreach (var item in this.PathOfPoints)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
        }
    }
}
