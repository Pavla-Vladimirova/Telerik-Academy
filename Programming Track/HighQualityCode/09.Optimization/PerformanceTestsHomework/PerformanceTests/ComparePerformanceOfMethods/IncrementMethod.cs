using System;
using System.Linq;

namespace ComparePerformanceOfMethods
{
    public static class IncrementMethod
    {
        public static decimal IncrementDecimal(decimal number)
        {
            return ++number;
        }

        public static double IncrementDouble(double number)
        {
            return ++number;
        }

        public static float IncrementFloat(float number)
        {
            return ++number;
        }

        public static long IncrementInteger64(long number)
        {
            return ++number;
        }

        public static int IncrementInteger32(int number)
        {
            return ++number;
        }
    }
}
