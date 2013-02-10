using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.FindElementsInArrayThatHaveDefiniteSumS
{
    class FindElementsInArrayThatHaveDefiniteSumS
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write length of the array");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Write the sum S to check");
            int S = int.Parse(Console.ReadLine());

            int[] numberArray = new int[n];
            Console.WriteLine("Write the elements of the array");
            for (int i = 0; i < n; i++)
            {
                numberArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("The array is");
            for (int i = 0; i < n; i++)
            {
                Console.Write(" " + numberArray[i]);
            }
            Console.WriteLine();

            int firstElementIndex = 0;
            int counter = 0;
            for (int i = 0; i < numberArray.Length; i++)
            {
                int sum =0;
                counter = 0;
                firstElementIndex=i;
                for (int j = i; j < numberArray.Length; j++)
                {
                    if (sum < S)
                    {
                        sum += numberArray[j];
                        counter++;
                    }
                }
                if (sum==S)
                {
                    Console.WriteLine("The sequence with Sum {0} is ", S);
                    for (int k = firstElementIndex; k < (firstElementIndex + counter); k++)
                    {
                        Console.Write(" " + numberArray[k]);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
