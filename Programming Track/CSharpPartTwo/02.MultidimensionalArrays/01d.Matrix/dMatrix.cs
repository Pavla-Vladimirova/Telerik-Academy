using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01d.Matrix
{
    class dMatrix
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write N");
            int N = int.Parse(Console.ReadLine());
            int[,] matrix = new int[N, N];

            int number = 1;
            int odd = N;
            // k,m,s changes the index on every new  outside loop
            int k = 0;
            int m = 0;
            int s = 1;

            for (int currentSquare = 0; currentSquare <= matrix.GetLength(0); currentSquare++)
            {
                for (int row = k; row <= N - 2; row++)
                {
                    int col = m;
                    matrix[row, col] = number;
                    number++;
                }
                for (int col = k; col <= N - 2; col++)
                {
                    int row = N - 1;
                    matrix[row, col] = number;
                    number++;
                }
                for (int row = N - 1; row >= s; row--)
                {
                    int col = N - 1;
                    matrix[row, col] = number;
                    number++;
                }
                for (int col = N - 1; col >= s; col--)
                {
                    int row = m;
                    matrix[row, col] = number;
                    number++;
                }
                N--;
                k++;
                s++;
                m++;
            }

            //Writing the last Number when N is odd
            if (odd % 2 != 0)
            {
                int middleIndexRow = odd / 2;
                int middleIndexCol = odd / 2;
                matrix[middleIndexRow, middleIndexCol] = odd * odd;
            }

            //Print the matrix
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0,3} ", matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
