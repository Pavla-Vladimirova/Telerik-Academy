using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.SortStringArrayByTheLengthOfItsElements
{
    class SortStringArrayByTheLengthOfItsElements
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write N");
            int N = int.Parse(Console.ReadLine());
            string[] strings = new string[N];

            for (int i = 0; i < N; i++)
            {
                strings[i] = Console.ReadLine();
            }

            //before stort
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(strings[i]);
            }
            Console.WriteLine();

            Array.Sort(strings, (x, y) => (x.Length).CompareTo(y.Length));

            //after sort
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(strings[i]);
            }
        }
    }
}
