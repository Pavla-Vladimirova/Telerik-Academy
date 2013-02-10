using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

namespace _01.MathExpression
{
    class MathExpression
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            double N = double.Parse(Console.ReadLine());
            double M = double.Parse(Console.ReadLine());
            double P = double.Parse(Console.ReadLine());
            double sin = Math.Truncate(M % 180);
            double mathExpression = (N * N + 1 / (M *P) + 1337) / (N - (128.523123123 * P)) + Math.Sin(sin);
            Console.WriteLine("{0:F6}",mathExpression);
        }
    }
}
