using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.SortArrayBySelectionSort
{
    class SortArrayBySelectionSort
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write length of the array");
            int n = int.Parse(Console.ReadLine());

            int[] numberArray = new int[n];
            Console.WriteLine("Write the elements of the array");
            for (int i = 0; i < n; i++)
            {
                numberArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Before sort");
            for (int i = 0; i < n; i++)
            {
                Console.Write(" "+numberArray[i]);
            }
            Console.WriteLine();

            //Sorting,finds the minValue on position minIndex,then change the element where the minValue is with the first element
            int reverse = 0;
            int minValue = int.MaxValue;
            int minIndex = 0;
            for (int i = 0; i < numberArray.Length; i++)
            {
                minValue = int.MaxValue; //To find the minValue corectly,every time initializing the minValue 
                for (int j = i; j < numberArray.Length; j++)
                {
                    if (numberArray[j] < minValue)
                    {
                        minValue = numberArray[j];
                        minIndex = j;
                    }
                }
                Console.WriteLine("The min value right now is {0} on position {1}",minValue,minIndex);
                reverse = numberArray[minIndex];
                numberArray[minIndex] = numberArray[i];
                numberArray[i] = reverse;
            }

            Console.WriteLine("After sort");
            for (int i = 0; i < n; i++)
            {
                Console.Write(" " + numberArray[i]);
            }
            Console.WriteLine();
        }
    }
}
