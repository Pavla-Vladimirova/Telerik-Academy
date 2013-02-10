using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CalculateTheSurfaceOfATriangleInThreeWays
{
    class CalculateTheSurfaceOfATriangleInThreeWays
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press");
            Console.WriteLine("1 for finding surface by three sides sides");
            Console.WriteLine("2 for finding surface by one side and an altitude to it");
            Console.WriteLine("3 for finding surface by two sides and an angle beetwen them");
            int choice = int.Parse(Console.ReadLine());

            if (choice==1)
            {
                Console.WriteLine("Write the three sides");
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int c = int.Parse(Console.ReadLine());
                Console.WriteLine("The surface is {0}",FindSurfaceByThreeSides(a,b,c));
            }
            else if (choice==2)
            {
                Console.WriteLine("Write one side");
                int anySide = int.Parse(Console.ReadLine());
                Console.WriteLine("Write the altitude to it");
                int altitude = int.Parse(Console.ReadLine());
                Console.WriteLine("The surface is {0}", FindSurfaceByOneSideAndAltitudeToIt(anySide,altitude));
            }
            else
            {
                Console.WriteLine("Write the first side");
                int firstSide = int.Parse(Console.ReadLine());
                Console.WriteLine("Write the other side");
                int secondSide = int.Parse(Console.ReadLine());
                Console.WriteLine("Write the angle between(in degrees) them");
                int angle = int.Parse(Console.ReadLine());
                Console.WriteLine("The surface is {0}", FindSurfaceByTwoSidesAndAnAngleBetweenThem(firstSide,secondSide,angle));
            }
        }
   
        static double FindSurfaceByThreeSides(double a,double b,double c)
        {
            double S = 0;
            double p = (a + b + c) / 2;
            S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return S;
        }

        static double FindSurfaceByOneSideAndAltitudeToIt(double a,double ha)
        {
            double S = 0;
            S = (a * ha) / 2;
            return S;
        }

        static double FindSurfaceByTwoSidesAndAnAngleBetweenThem(double a, double b,double angle)
        {
            double S = 0;
            S = (a * b * Math.Sin(angle * Math.PI / 180)) / 2;
            return S;
        }
    }
}
