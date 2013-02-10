using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.SieveOfErathostenes
{
    class SieveOfErathostenes
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write N");
            int N = int.Parse(Console.ReadLine());
            int upperBoundSquareRoot = (int)Math.Sqrt(N);
            bool[] isComposite = new bool[N + 1];
            for (int m = 2; m <= upperBoundSquareRoot; m++)
            {
                if (isComposite[m] == false) //delete all the numbers m+m after m according to the sieve of Erathosten
                {
                    Console.Write(m + " ");
                    for (int k = m * m; k <= N; k += m)
                    {
                        isComposite[k] = true;
                    }
                }
            }

            for (int m = upperBoundSquareRoot; m <= N; m++)
            {
                if (isComposite[m] == false)
                {
                    Console.Write(m + " ");
                }
            }
            Console.WriteLine();  
        }
    }
}
