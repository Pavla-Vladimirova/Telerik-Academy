using System;
using System.Diagnostics;
using System.Linq;

namespace ComparePerformanceOfMethodsFromMathClass
{
    class ComparePerformance
    {
        static void Main(string[] args)
        {
            decimal decimalNumber= 5000m;
            double doubleNumber = 5000d;
            float floatNumber = 5000f;

            #region TestSquareRoot

            Console.WriteLine("Square root");
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Math.Sqrt((double)decimalNumber);
            stopwatch.Stop();
            Console.WriteLine("Time elapsed(decimal): {0}", stopwatch.Elapsed);

            stopwatch = new Stopwatch();
            stopwatch.Start();
            Math.Sqrt(doubleNumber);
            stopwatch.Stop();
            Console.WriteLine("Time elapsed(double): {0}", stopwatch.Elapsed);

            stopwatch = new Stopwatch();
            stopwatch.Start();
            Math.Sqrt(floatNumber);
            stopwatch.Stop();
            Console.WriteLine("Time elapsed(float): {0}", stopwatch.Elapsed);

            #endregion

            #region TestNaturalLogarithm

            Console.WriteLine("Logarithm");
            stopwatch = new Stopwatch();
            stopwatch.Start();
            Math.Log((double)decimalNumber);
            stopwatch.Stop();
            Console.WriteLine("Time elapsed(decimal): {0}", stopwatch.Elapsed);

            stopwatch = new Stopwatch();
            stopwatch.Start();
            Math.Log(doubleNumber);
            stopwatch.Stop();
            Console.WriteLine("Time elapsed(double): {0}", stopwatch.Elapsed);

            stopwatch = new Stopwatch();
            stopwatch.Start();
            Math.Log(floatNumber);
            stopwatch.Stop();
            Console.WriteLine("Time elapsed(float): {0}", stopwatch.Elapsed);

            #endregion

            #region TestSinus

            Console.WriteLine("Sinus");
            stopwatch = new Stopwatch();
            stopwatch.Start();
            Math.Sin((double)decimalNumber);
            stopwatch.Stop();
            Console.WriteLine("Time elapsed(decimal): {0}", stopwatch.Elapsed);

            stopwatch = new Stopwatch();
            stopwatch.Start();
            Math.Sin(doubleNumber);
            stopwatch.Stop();
            Console.WriteLine("Time elapsed(double): {0}", stopwatch.Elapsed);

            stopwatch = new Stopwatch();
            stopwatch.Start();
            Math.Sin(floatNumber);
            stopwatch.Stop();
            Console.WriteLine("Time elapsed(float): {0}", stopwatch.Elapsed);

            #endregion
        }
    }
}
