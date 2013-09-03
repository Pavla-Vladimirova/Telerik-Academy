using System;
using System.Linq;

namespace ComparePerformanceOfMethods
{
    public static class MultiplyMethod
    {
        public static decimal MultiplyDecimal(decimal firstNumber, decimal secondNumber)
        {
            return firstNumber * secondNumber;
        }

        public static double MultiplyDouble(double firstNumber, double secondNumber)
        {
            return firstNumber * secondNumber;
        }

        public static float MultiplyFloat(float firstNumber, float secondNumber)
        {
            return firstNumber * secondNumber;
        }

        public static long MultiplyInteger64(long firstNumber, long secondNumber)
        {
            return firstNumber * secondNumber;
        }

        public static int MultiplyInteger32(int firstNumber, int secondNumber)
        {
            return firstNumber * secondNumber;
        }
    }
}
