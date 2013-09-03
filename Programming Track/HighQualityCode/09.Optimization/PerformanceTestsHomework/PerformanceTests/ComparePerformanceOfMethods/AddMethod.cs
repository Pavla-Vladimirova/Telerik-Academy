using System;
using System.Linq;

namespace ComparePerformanceOfMethods
{
    public static class AddMethod
    {
        public static decimal AddDecimal(decimal firstNumber, decimal secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public static double AddDouble(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public static float AddFloat(float firstNumber, float secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public static long AddInteger64(long firstNumber, long secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public static int AddInteger32(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
    }
}
