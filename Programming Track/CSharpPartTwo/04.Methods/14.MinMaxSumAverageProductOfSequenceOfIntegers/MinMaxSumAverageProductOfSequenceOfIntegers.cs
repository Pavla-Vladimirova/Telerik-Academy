using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _14.MinMaxSumAverageProductOfSequenceOfIntegers
{
    class MinMaxSumAverageProductOfSequenceOfIntegers
    {
        static void Main(string[] args)
        {
            Console.Write("The minimal element is ");
            Console.WriteLine(GetMin(2, 3, 4, -1, 2, 3, 4));
            Console.Write("The maximal element is ");
            Console.WriteLine(GetMax(2, 3, 14, -1, 32, 53, 4));
            Console.Write("The average sum is ");
            Console.WriteLine(AverageSum(2, 3, 14, -1, 32, 53, 4));
            Console.Write("The sum is ");
            Console.WriteLine(Sum(2, 3, 14, -1, 32, 53, 4));
            Console.Write("The product is ");
            Console.WriteLine(Product(2, 3, 14, -1, 32, 53, 4));
        }

        static int GetMin(params int[] numbers)
        {
            int min = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i]<min)
                {
                    min = numbers[i];
                }
            }
            return min;
        }

        static int GetMax(params int[] numbers)
        {
            int max = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            return max;
        }

        static double AverageSum(params int[] numbers)
        {
            long sum = 0;
            int counter = 0;
            foreach (int element in numbers)
            {
                sum = sum + element;
                counter++;
            }
            double average = (double)sum / counter;
            return average;
        }

        static BigInteger Sum(params int[] numbers)
        {
            BigInteger sum = 0;
            foreach (int element in numbers)
            {
                sum = sum + element;
                
            }
            return sum;
        }

        static BigInteger Product(params int[] numbers)
        {
            BigInteger product = 1;
            foreach (int element in numbers)
            {
                product=product*element;
            }
            return product;
        }

    }
}
