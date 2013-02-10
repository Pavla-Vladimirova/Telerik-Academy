using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.TheFirstNumberInArrayBiggerThanItsTwoNeighbours
{
    class TheFirstNumberInArrayBiggerThanItsTwoNeighbours
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write the length of the array");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Write elements of the array");
            int[] numbers = new int[N];
            InputNumbersInArray(numbers);            
            PrintArray(numbers);
            Console.WriteLine(FirstBiggerThanItsNeighbours(numbers)); 
        }

        static int FirstBiggerThanItsNeighbours(int[] array)
        {
            if (array.Length==1)
            {
                Console.WriteLine("This is the only element");
                return -1;
            }
            int firstIndex = 0;
            for (int i = 1; i < array.Length-2; i++) //chek from the second to the last but one
            {
                if ((array[i]>array[i-1])&&(array[i]>array[i+1]))
                {
                    firstIndex = i;
                    return firstIndex;
                }
            }
            return -1;
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
