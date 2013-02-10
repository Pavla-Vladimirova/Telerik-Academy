using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.MaxNumberBeforeKWithMethodBinarySearch
{
    class MaxNumberBeforeKWithMethodBinarySearch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write N");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Write K");
            int K = int.Parse(Console.ReadLine());
            int[] numbers = new int[N];

            for (int i = 0; i < N; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(numbers);
            if (K<numbers[0])
            {
                Console.WriteLine("There is no element <=K in this array");
            }
            else if (Array.BinarySearch(numbers, K)>=0)
            {
                Console.WriteLine("The largest number is equal to K={0}",K );
            }
            else
            {
                Console.WriteLine("K={0} is not found in the array so the largest number <=K is {1}", K, numbers[~(Array.BinarySearch(numbers, K))-1]);
            }
        }
    }
}
