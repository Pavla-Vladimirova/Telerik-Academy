using System;
using System.Linq;

namespace ComparePerformanceOfMethods
{
    public static class DivideMethod
    {
         public static decimal DivideDecimal(decimal firstNumber, decimal secondNumber)
        {
            return firstNumber / secondNumber;
        }

        public static double DivideDouble(double firstNumber, double secondNumber)
        {
            return firstNumber / secondNumber;
        }

        public static float DivideFloat(float firstNumber, float secondNumber)
        {
            return firstNumber / secondNumber;
        }

        public static long DivideInteger64(long firstNumber, long secondNumber)
        {
            return firstNumber / secondNumber;
        }

        public static int DivideInteger32(int firstNumber, int secondNumber)
        {
            return firstNumber / secondNumber;
        }
    }
}
