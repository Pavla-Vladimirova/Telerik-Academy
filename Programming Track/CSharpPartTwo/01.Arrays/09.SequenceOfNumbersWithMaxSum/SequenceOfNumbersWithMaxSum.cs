using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.SequenceOfNumbersWithMaxSum
{
    class SequenceOfNumbersWithMaxSum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write length of the array");
            int n = int.Parse(Console.ReadLine());

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

            int maxSum = 0;
            int indexOfLastElement = 0;
            int indexOfFirstElement = 0;
           
            for (int i = 0; i < numbers.Length; i++)
            {
                int currentSum = numbers[i];
                for (int j = i+1; j < numbers.Length; j++)
                {
                    currentSum+=numbers[j];
                    if (currentSum>maxSum)
                    {                       
                        maxSum = currentSum;
                        indexOfLastElement = j;
                        indexOfFirstElement = i;
                    }
                }
            }

            Console.WriteLine("The sequence with maximum sum is: ");
            for (int i = indexOfFirstElement; i <=indexOfLastElement; i++)
            {
                Console.Write(" " + numbers[i]);
            }
            Console.WriteLine();
            Console.WriteLine("The sum of these numbers is {0}",maxSum);
        }
    }
}
