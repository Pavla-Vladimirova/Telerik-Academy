using System;
using System.Linq;

//03.Write a static class with a static method to calculate the distance between two points in the 3D space.

namespace _01._3DSpace
{
    public static class DistanceIn3DSpace
    {
        private static double distance;

        public static double CalculateDistance(Point3D firstPoint, Point3D secondPoint)
        {
            distance = Math.Sqrt(Math.Pow((secondPoint.X - firstPoint.X), 2) + Math.Pow((secondPoint.Y - firstPoint.Y), 2) + Math.Pow((secondPoint.Z - firstPoint.Z), 2));
            return distance;
        }
    }
}
