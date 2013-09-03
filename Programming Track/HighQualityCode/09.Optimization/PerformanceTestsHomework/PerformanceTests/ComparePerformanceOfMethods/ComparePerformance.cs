using System;
using System.Diagnostics;
using System.Linq;

namespace ComparePerformanceOfMethods
{
    class ComparePerformance
    {
        static void Main(string[] args)
        {
            #region TestAddMethods

            Console.WriteLine("ADD");
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            AddMethod.AddDecimal(10000m, 10000m);
            stopwatch.Stop();
            Console.WriteLine("Time elapsed(decimal): {0}", stopwatch.Elapsed);

            stopwatch = new Stopwatch();
            stopwatch.Start();
            AddMethod.AddDouble(10000d, 10000d);
            stopwatch.Stop();
            Console.WriteLine("Time elapsed(double): {0}", stopwatch.Elapsed);

            stopwatch = new Stopwatch();
            stopwatch.Start();
            AddMethod.AddFloat(10000f, 10000f);
            stopwatch.Stop();
            Console.WriteLine("Time elapsed(float): {0}", stopwatch.Elapsed);

            stopwatch = new Stopwatch();
            stopwatch.Start();
            AddMethod.AddInteger64(10000L, 10000L);
            stopwatch.Stop();
            Console.WriteLine("Time elapsed(long): {0}", stopwatch.Elapsed);

            stopwatch = new Stopwatch();
            stopwatch.Start();
            AddMethod.AddInteger32(10000, 10000);
            stopwatch.Stop();
            Console.WriteLine("Time elapsed(int): {0}", stopwatch.Elapsed);

            #endregion

            #region TestSubtractMethods

            Console.WriteLine("SUBTRACT");
            stopwatch = new Stopwatch();
            stopwatch.Start();
            SubtractMethod.SubtractDecimal(50000m, 10000m);
            stopwatch.Stop();
            Console.WriteLine("Time elapsed(decimal): {0}", stopwatch.Elapsed);

            stopwatch = new Stopwatch();
            stopwatch.Start();
            SubtractMethod.SubtractDouble(50000d, 10000d);
            stopwatch.Stop();
            Console.WriteLine("Time elapsed(double): {0}", stopwatch.Elapsed);

            stopwatch = new Stopwatch();
            stopwatch.Start();
            SubtractMethod.SubtractFloat(50000f, 10000f);
            stopwatch.Stop();
            Console.WriteLine("Time elapsed(float): {0}", stopwatch.Elapsed);

            stopwatch = new Stopwatch();
            stopwatch.Start();
            SubtractMethod.SubtractInteger64(50000L, 10000L);
            stopwatch.Stop();
            Console.WriteLine("Time elapsed(long): {0}", stopwatch.Elapsed);

            stopwatch = new Stopwatch();
            stopwatch.Start();
            SubtractMethod.SubtractInteger32(50000, 10000);
            stopwatch.Stop();
            Console.WriteLine("Time elapsed(int): {0}", stopwatch.Elapsed);

            #endregion

            #region TestIncrementtMethods

            Console.WriteLine("INCREMENT");
            stopwatch = new Stopwatch();
            stopwatch.Start();
            IncrementMethod.IncrementDecimal(50000m);
            stopwatch.Stop();
            Console.WriteLine("Time elapsed(decimal): {0}", stopwatch.Elapsed);

            stopwatch = new Stopwatch();
            stopwatch.Start();
            IncrementMethod.IncrementDouble(50000d);
            stopwatch.Stop();
            Console.WriteLine("Time elapsed(double): {0}", stopwatch.Elapsed);

            stopwatch = new Stopwatch();
            stopwatch.Start();
            IncrementMethod.IncrementFloat(50000f);
            stopwatch.Stop();
            Console.WriteLine("Time elapsed(float): {0}", stopwatch.Elapsed);

            stopwatch = new Stopwatch();
            stopwatch.Start();
            IncrementMethod.IncrementInteger64(50000L);
            stopwatch.Stop();
            Console.WriteLine("Time elapsed(long): {0}", stopwatch.Elapsed);

            stopwatch = new Stopwatch();
            stopwatch.Start();
            IncrementMethod.IncrementInteger32(50000);
            stopwatch.Stop();
            Console.WriteLine("Time elapsed(int): {0}", stopwatch.Elapsed);

            #endregion

            #region TestMultiplyMethods

            Console.WriteLine("MULTIPLY");
            stopwatch = new Stopwatch();
            stopwatch.Start();
            MultiplyMethod.MultiplyDecimal(10000m, 10000m);
            stopwatch.Stop();
            Console.WriteLine("Time elapsed(decimal): {0}", stopwatch.Elapsed);

            stopwatch = new Stopwatch();
            stopwatch.Start();
            MultiplyMethod.MultiplyDouble(10000d, 10000d);
            stopwatch.Stop();
            Console.WriteLine("Time elapsed(double): {0}", stopwatch.Elapsed);

            stopwatch = new Stopwatch();
            stopwatch.Start();
            MultiplyMethod.MultiplyFloat(10000f, 10000f);
            stopwatch.Stop();
            Console.WriteLine("Time elapsed(float): {0}", stopwatch.Elapsed);

            stopwatch = new Stopwatch();
            stopwatch.Start();
            MultiplyMethod.MultiplyInteger64(10000L, 10000L);
            stopwatch.Stop();
            Console.WriteLine("Time elapsed(long): {0}", stopwatch.Elapsed);

            stopwatch = new Stopwatch();
            stopwatch.Start();
            MultiplyMethod.MultiplyInteger32(10000, 10000);
            stopwatch.Stop();
            Console.WriteLine("Time elapsed(int): {0}", stopwatch.Elapsed);

            #endregion

            #region TestDivideMethods

            Console.WriteLine("DIVIDE");
            stopwatch = new Stopwatch();
            stopwatch.Start();
            DivideMethod.DivideDecimal(50000m, 10000m);
            stopwatch.Stop();
            Console.WriteLine("Time elapsed(decimal): {0}", stopwatch.Elapsed);

            stopwatch = new Stopwatch();
            stopwatch.Start();
            DivideMethod.DivideDouble(50000d, 10000d);
            stopwatch.Stop();
            Console.WriteLine("Time elapsed(double): {0}", stopwatch.Elapsed);

            stopwatch = new Stopwatch();
            stopwatch.Start();
            DivideMethod.DivideFloat(50000f, 10000f);
            stopwatch.Stop();
            Console.WriteLine("Time elapsed(float): {0}", stopwatch.Elapsed);

            stopwatch = new Stopwatch();
            stopwatch.Start();
            DivideMethod.DivideInteger64(50000L, 10000L);
            stopwatch.Stop();
            Console.WriteLine("Time elapsed(long): {0}", stopwatch.Elapsed);

            stopwatch = new Stopwatch();
            stopwatch.Start();
            DivideMethod.DivideInteger32(50000, 10000);
            stopwatch.Stop();
            Console.WriteLine("Time elapsed(int): {0}", stopwatch.Elapsed);

            #endregion
        }

    }
}
