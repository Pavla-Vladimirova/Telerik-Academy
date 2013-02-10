using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _15.MinMaxSumAverageProductFoAnyNumeralType
{
    class MinMaxSumAverageProductFoAnyNumeralType
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

        static T GetMin<T>(params T[] numbers)
        {
            dynamic min = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }
            return min;
        }

        static T GetMax<T>(params T[] numbers)
        {
            dynamic max = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            return max;
        }

        static T AverageSum<T>(params T[] numbers)
        {
            dynamic sum = 0;
            dynamic counter = 0;
            foreach (dynamic element in numbers)
            {
                sum = sum + element;
                counter++;

            }
            dynamic average = sum / counter;
            return average;
        }

        static T Sum<T>(params T[] numbers)
        {
            dynamic sum = 0;
            foreach (dynamic element in numbers)
            {
                sum = sum + element;

            }
            return sum;
        }

        static T Product<T>(params T[] numbers)
        {
            dynamic product = 1;
            foreach (dynamic element in numbers)
            {
                product = product * element;
            }
            return product;
        }
    }
}
