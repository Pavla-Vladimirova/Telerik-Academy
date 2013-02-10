using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1MissCatArray
{
    class MissCatArray
    {
        static void Main(string[] args)
        {
            uint n = uint.Parse(Console.ReadLine());
            int[] cats = new int[10];

            for (int i = 0; i < n; i++)
            {
                int cat = int.Parse(Console.ReadLine());
                cats[cat - 1]++;
            }

            int catNumberWithMaxVotes = 1;
            int currentMaxVotes = cats[0]; 
            for (int i = 1; i < cats.Length; i++) 
            {
                if (cats[i] > currentMaxVotes)
                {
                    catNumberWithMaxVotes = i + 1;
                    currentMaxVotes = cats[i];
                }
            }
            Console.WriteLine(catNumberWithMaxVotes);
        }
    }
}
