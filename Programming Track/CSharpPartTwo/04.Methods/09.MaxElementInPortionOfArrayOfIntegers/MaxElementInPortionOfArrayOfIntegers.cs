using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.MaxElementInPortionOfArrayOfIntegers
{
    class MaxElementInPortionOfArrayOfIntegers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write length of the array");
            int N = int.Parse(Console.ReadLine());
            int[] numbers = new int[N];
            Console.WriteLine("write numbers");
            InputNumbersInArray(numbers);
            Console.WriteLine("The array is");
            PrintArray(numbers);
            DescendingSort(numbers);
            Console.WriteLine("After the sort in descending order is");
            PrintArray(numbers);
            AscendingSort(numbers);
            Console.WriteLine("After the sort in ascending order is");
            PrintArray(numbers);           

        }

        static void InputNumbersInArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            return;
        }

        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(" " + array[i]);
            }
            Console.WriteLine();
            return;
        }

        static int GetMaxFromSpecificPosition(int[] array, int firstPosition)
        {
            int maxPosition = firstPosition;
            for (int i = firstPosition; i < array.Length; i++)
            {
                if (array[i] > array[maxPosition])
                {
                    maxPosition = i;
                }
            }
            return maxPosition;
        }

        static void DescendingSort(int[] array)
        {
            int currentMaxPosition = 0;
            int swap = 0;
            for (int i = 0; i < array.Length; i++)
            {
                currentMaxPosition = GetMaxFromSpecificPosition(array, i);
                swap = array[i];
                array[i] = array[currentMaxPosition];
                array[currentMaxPosition] = swap;
            }
        }

        static void AscendingSort(int[] array)
        {
            int swap = 0;
            for (int i = 0; i < array.Length/2; i++)
            {
                swap = array[i];
                array[i] = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = swap;
            }
        }
    }
}
