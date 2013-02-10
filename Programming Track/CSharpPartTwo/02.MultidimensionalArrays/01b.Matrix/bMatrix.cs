using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01b.Matrix
{
    class bMatrix
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write N");
            int N = int.Parse(Console.ReadLine());
            int[,] matrix = new int[N, N];

            int direction = 1;
            int number = 1;
            for (int col = 0; col < N; col++)
            {
                if (direction==1)
                {
                    for (int row = 0; row < N; row++)
                    {
                        matrix[row, col] = number;
                        number++;
                    }
                }
                else
                {
                    for (int row = N-1; row >= 0; row--)
                    {
                        matrix[row, col] = number;
                        number++;
                    }
                      
                }       
                direction *=-1 ;
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
