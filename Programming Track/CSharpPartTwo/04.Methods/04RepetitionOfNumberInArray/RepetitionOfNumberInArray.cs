using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04RepetitionOfNumberInArray
{
    public class RepetitionOfNumberInArray
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Write your number");
            int inputNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Write the length of the array");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Write elements of the array");
            int[] numbers=new int[N];
            InputNumbersInArray(numbers);
            PrintArray(numbers);
            Console.WriteLine("The number {0} repeats {1} ",inputNumber,FindRepetitionOfNumber(inputNumber, numbers)); 
        }

       public static int FindRepetitionOfNumber(int number, int[] array)
        {
            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]==number)
                {
                    counter++;
                }
            }
            return counter;
        }

        public static void InputNumbersInArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
        }

        public static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(" " + array[i]);
            }
            Console.WriteLine();
        }
    }
}
