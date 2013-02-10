using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01c.Matrix
{
    class cMatrix
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write N");
            int N = int.Parse(Console.ReadLine());
            int[,] matrix = new int[N, N];

            int number = 1;
            //Fill in the lower part including the diagonal
            for (int row = N-1; row >= 0; row--)
            {
                for (int col = 0; col <= N-row-1; col++)
                {
                    if ((row>=0)&&(row<=N-1)&&(col>=0)&&(col<=N-1))
                    {
                        matrix[row + col, col] = number;
                        number++;
                    }
                }
            }

            //fill in the upper part without the diagonal
            for (int col = 1; col <=N-1; col++)
            {
                for (int row = 0; row <= N-col-1; row++)
                {
                     if ((row>=0)&&(row<=N-1)&&(col>=0)&&(col<=N-1))
                    {
                        matrix[row, col+row] = number;
                        number++;
                    }
                }
            }

            for (int row = 0; row < N; row++)
            {
                for (int col = 0; col < N; col++)
                {
                    Console.Write("{0,3} ", matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
