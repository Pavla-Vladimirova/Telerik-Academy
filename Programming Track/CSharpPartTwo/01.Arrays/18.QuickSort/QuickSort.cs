using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.QuickSort
{
    class QuickSort
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
            DoQuickSort(numbers, 0, numbers.Length - 1);
            Console.WriteLine("The array after is");
            PrintArray(numbers);
        }

        static void DoQuickSort(int[] array, int left, int right)
        {
            if (left >= right)
	        {
                return;
	        }
            int i = left;
            int j = right;
            int pivot = array[right];
            int swap = 0;
            while (i<j)
            {
                while ((i < j) && (array[i] <= pivot))
                {
                    i++;
                }
                while ((i < j) && (array[j] >= pivot))
                {
                    j--;
                }
                if (i<j)
                {
                    swap = array[i];
                    array[i] = array[j];
                    array[j] = swap;
                }
            }
            swap = array[i];
            array[i] = array[right];
            array[right] = swap;

            DoQuickSort(array, left, i - 1);
            DoQuickSort(array, i + 1, right);
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
    }
}
