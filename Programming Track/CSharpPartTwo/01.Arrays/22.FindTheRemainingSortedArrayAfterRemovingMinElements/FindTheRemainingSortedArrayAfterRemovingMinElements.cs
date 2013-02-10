using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.FindTheRemainingSortedArrayAfterRemovingMinElements
{
    class FindTheRemainingSortedArrayAfterRemovingMinElements
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write the length of the array");
            int N = int.Parse(Console.ReadLine());
            int[] numbers = new int[N];
            Console.WriteLine("Write the elements of the array");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i]=int.Parse(Console.ReadLine());
            }
            List<int> sort = new List<int>();
            List<int> checker = new List<int>();
            int minValue;
            int counter = 0;
            int count = 0;

            for (int i = 0; i < Math.Pow(2, N) - 1; i++)
            {
                minValue = int.MinValue;
                counter = 0;
                for (int j = 0; j < N; j++)
                {
                    if ((((1 << j) & i) != 0) && (numbers[j] >= minValue))
                    {
                        minValue = numbers[j];
                        checker.Add(numbers[j]);
                        counter++;
                    }
                }
                if (counter > count)
                {
                    sort.Clear();
                    count = counter;
                    for (int k = 0; k < checker.Count; k++)
                    {
                        sort.Add(checker[k]);
                    }
                }
                checker.Clear();
            }

            for (int i = 0; i < sort.Count; i++)
            {
                Console.Write("{0} ", sort[i]);
            }
            Console.WriteLine();
        }
    }
}
