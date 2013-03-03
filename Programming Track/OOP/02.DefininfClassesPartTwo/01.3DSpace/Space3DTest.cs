using System;
using System.Linq;

//01.Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space. Implement the ToString() to enable printing a 3D point.
//02.Add a private static read-only field to hold the start of the coordinate system – the point O{0, 0, 0}. Add a static property to return the point O.
//03.Write a static class with a static method to calculate the distance between two points in the 3D space.
//04.Create a class Path to hold a sequence of points in the 3D space.
//Create a static class PathStorage with static methods to save and load paths from a text file. Use a file format of your choice.

namespace _01._3DSpace
{
    public class Space3DTest
    {
        static void Main(string[] args)
        {
           // point form class Point3D
            Point3D newPoint = new Point3D(3, 4, 5);
            Console.WriteLine(newPoint);

            //static point with starting coordinates
            Console.WriteLine(Point3D.StartCoordinates);

            //3D distance between 2 points
            Point3D newPoint1 = new Point3D(3, 4, 5);
            Point3D newPoint2 = new Point3D(2, 1, 3);
            Console.WriteLine("The distance between the two points is {0}", DistanceIn3DSpace.CalculateDistance(newPoint1, newPoint2));

           // path ot points
            Path newPath = new Path();
            newPath.AddPoint();
            newPath.AddPoint();
            newPath.AddPoint();
            newPath.PrintPath();

           // Load,save and print Path Storage
            PathStorage.SaveAndLoadFromFile();
            PathStorage.PrintStorage();
        }
    }
}
