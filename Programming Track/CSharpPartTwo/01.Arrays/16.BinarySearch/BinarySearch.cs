using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.BinarySearch
{
    class BinarySearch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write length of the array");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Write the number you want to find");
            int searchedNum = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            Console.WriteLine("Write the elements of the array");
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("The array is");
            for (int i = 0; i < n; i++)
            {
                Console.Write(" " + numbers[i]);
            }
            Console.WriteLine();

            Array.Sort(numbers);
            int firstIndex = 0;
            int lastIndex = numbers.Length-1;
            while (firstIndex<=lastIndex)
            {
                int middle = (firstIndex + lastIndex) / 2;
                if (searchedNum==numbers[middle])
                {
                    searchedNum = numbers[middle];
                    Console.WriteLine("The searched number is {0} and is at position {1} ",searchedNum,middle);
                    break;
                }
                else if (searchedNum < numbers[middle])
                {
                    lastIndex = middle - 1;
                }
                else if (searchedNum>numbers[middle])
                {
                    firstIndex = middle + 1;
                }     
            }
        }
    }
}
