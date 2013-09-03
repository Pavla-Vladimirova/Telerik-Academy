using System;
using System.Linq;

namespace ComparePerformanceOfMethods
{
    public static class SubtractMethod
    {
        public static decimal SubtractDecimal(decimal firstNumber, decimal secondNumber)
        {
            return firstNumber - secondNumber;
        }

        public static double SubtractDouble(double firstNumber, double secondNumber)
        {
            return firstNumber - secondNumber;
        }

        public static float SubtractFloat(float firstNumber, float secondNumber)
        {
            return firstNumber - secondNumber;
        }

        public static long SubtractInteger64(long firstNumber, long secondNumber)
        {
            return firstNumber - secondNumber;
        }

        public static int SubtractInteger32(int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;
        }
    }
}
