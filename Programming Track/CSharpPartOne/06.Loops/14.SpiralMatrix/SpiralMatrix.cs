using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.SpiralMatrix
{
    class SpiralMatrix
    {
        static void Main(string[] args)
        {
            Console.WriteLine("write N");
            int N=int.Parse(Console.ReadLine());
            int[,] spiralMatrix = new int[N, N];
            int numbers = 1;
            int odd = N; 

            // k,m,s changes the index on every new  outside loop
            int k = 0;
            int m = 0;
            int s = 1;
            for (int currentSquare = 0; currentSquare <= spiralMatrix.GetLength(0); currentSquare++)
            {
                for (int col = k; col <= N - 2; col++)
                {
                    int row = m;
                    spiralMatrix[row, col] = numbers;
                    numbers++;
                }
                for (int row = k; row <= N - 2; row++)
                {
                    int col = N - 1;
                    spiralMatrix[row, col] = numbers;
                    numbers++;
                }
                for (int col = N - 1; col >= s; col--)
                {
                    int row = N - 1;
                    spiralMatrix[row, col] = numbers;
                    numbers++;
                }
                for (int row = N - 1; row >= s; row--)
                {
                    int col = m;
                    spiralMatrix[row, col] = numbers;
                    numbers++;
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
                spiralMatrix[middleIndexRow, middleIndexCol] = odd*odd;
            }     
                  
            //Print the matrix
            for (int row = 0; row < spiralMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < spiralMatrix.GetLength(1); col++)
                {
                    Console.Write("{0,3} ", spiralMatrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
