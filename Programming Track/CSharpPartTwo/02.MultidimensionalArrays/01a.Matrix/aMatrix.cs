using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01a.Matrix
{
    class aMatrix
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write N");
            int N = int.Parse(Console.ReadLine());
            int[,] matrix = new int[N, N];

            int number = 1;
            for (int col= 0; col < N; col++)
            {
                for (int row = 0; row < N; row++)
                {                   
                    matrix[row, col] = number;
                    number++;   
                }
            }

            for (int row = 0; row < N; row++)
            {
                for (int col = 0; col < N; col++)
                {
                    Console.Write("{0,3} ",matrix[row,col]);
                }
                Console.WriteLine();
            }
        }
    }
}
