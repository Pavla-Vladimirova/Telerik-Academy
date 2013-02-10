using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MaxSumInSquare3x3inRectangularMatrix
{
    class MaxSumInSquare3x3inRectangularMatrix
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wrtie N:");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Write M:");
            int M = int.Parse(Console.ReadLine());
            int[,] matrix = new int[N, M];

            int maxSum = int.MinValue;
            int currentSum = 0;
            int squareX = 3;
            int squareY = 3;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] =int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i <=matrix.GetLength(0)-squareX; i++)
            {
                for (int j = 0; j <=matrix.GetLength(1)-squareY; j++)
                {
                    currentSum = 0;
                    for (int row = i; row <squareX+i ; row++)
                    {
                        for (int col = j; col <squareY+j; col++)
                        {
                            currentSum += matrix[row, col];
                        }
                    }
                    if (currentSum>maxSum)
                    {
                        maxSum = currentSum;
                    }
                }
            }
            Console.WriteLine("The maximum sum of square 3x3 is {0} ",maxSum);
        }
    }
}
