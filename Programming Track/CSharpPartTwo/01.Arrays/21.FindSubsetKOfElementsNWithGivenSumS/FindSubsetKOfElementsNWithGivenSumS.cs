using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.FindSubsetKOfElementsNWithGivenSumS
{
    class FindSubsetKOfElementsNWithGivenSumS
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write the length of the array");
            int N = int.Parse(Console.ReadLine());
            int[] numbers = new int[N];
            Console.WriteLine("Write the elements of the array");
            for (int i = 0; i < N; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int K = int.Parse(Console.ReadLine());
            int S = int.Parse(Console.ReadLine());
            bool breaking = false;
            int mask = 1;
            for (int i = 1; i <= (Math.Pow(2, N) - 1); i++)
            {
                long currentSum = 0;
                int counter = 0;
                for (int j = 0; j < N; j++)
                {
                    if (((mask << j) & i) != 0)
                    {
                        currentSum = currentSum + numbers[j];
                        counter++;
                        if (counter == K)
                        {
                            if (currentSum == S)
                            {
                                Console.WriteLine(currentSum);
                                breaking = true;
                                break;
                            }
                        }
                    }
                }
                if (breaking)
                {
                    break;
                }
            }
        }
    }
}
