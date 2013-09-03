using System;

namespace CohesionAndCoupling
{
    static class Plane3DUtils
    {
        public static double Width { get; set; }
        public static double Height { get; set; }
        public static double Depth { get; set; }

        public static double CalcDistance3D(double x1, double y1, double z1, double x2, double y2, double z2)
        {
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
            return distance;
        }

        public static double CalcVolume()
        {
            double volume = Width * Height * Depth;
            return volume;
        }

        public static double CalcDiagonal(double x,double y, double z)
        {
            double distance = Math.Sqrt(x * x + y * y + z * z);
            return distance;
        }

        public static double CalcDiagonalXYZ()
        {
            double distance = CalcDiagonal(Width, Height, Depth);
            return distance;
        }

        public static double CalcDiagonalXY()
        {
            double distance = CalcDiagonal(Width, Height,0);
            return distance;
        }

        public static double CalcDiagonalXZ()
        {
            double distance = CalcDiagonal(Width, Depth,0);
            return distance;
        }

        public static double CalcDiagonalYZ()
        {
            double distance = CalcDiagonal(Height, Depth,0);
            return distance;
        }
    }
}
