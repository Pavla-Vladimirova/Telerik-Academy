using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MaxSequenceInMatrixOfStrings
{
    class MaxSequenceInMatrixOfStrings
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write N: ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Write M: ");
            int M = int.Parse(Console.ReadLine());
            string[,] matrix = new string[N, M];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = Console.ReadLine();
                }
            }

            //Print the matrix
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0,3}",matrix[i,j]);
                }
                Console.WriteLine();
            }

            int currentCounter = 1;
            int maxCounter = 0;
            //going through the rows
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                currentCounter = 1;
                for (int col = 0; col < matrix.GetLength(1)-1; col++)
                {
                    if (matrix[row,col]==matrix[row,col+1])
                    {
                        currentCounter++;
                    }
                }
                if (currentCounter>maxCounter)
                {
                    maxCounter = currentCounter;
                }
            }

            //going through the cols
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                currentCounter = 1;
                for (int row = 0; row < matrix.GetLength(0) - 1; row++)
                {

                    if (matrix[row, col] == matrix[row+1, col])
                    {
                        currentCounter++;
                    }
                }
                if (currentCounter > maxCounter)
                {
                    maxCounter = currentCounter;
                }
            }

            //going through the diagonals
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                currentCounter = 1;
                for (int col = 0; col < matrix.GetLength(0)-row-1; col++)
                {
                    if ((row >= 0) && (row <= N - 2) && (col >= 0) && (col <= N - 2))
                    {
                        if (matrix[row + col, col] == matrix[row + col + 1, col + 1])
                        {
                            currentCounter++;
                        }
                    }
                }
                if (currentCounter>maxCounter)
                {
                    maxCounter = currentCounter;
                }
            }
            Console.WriteLine("The max sequence is {0} ",maxCounter);
        }
    }
}
