using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.FirTree
{
    class FirTree
    {
        static void Main(string[] args)
        {
            char asterisk = '*';
            char dot = '.';
            int N = int.Parse(Console.ReadLine());

            int currentStart = N-1;
            int currentEnd = N;
         
            for (int i = 1; i <N; i++)
            {
                for (int frontDots = 1; frontDots <= N-(i+1); frontDots++)
                {
                    Console.Write(dot);
                }
                for (int j = currentStart; j < currentEnd; j++)
                {
                    Console.Write(asterisk);
                }
                for (int backDots = (N*2-3); backDots >=N+(i-1); backDots--)
                {
                    Console.Write(dot);
                }
                currentStart--;
                currentEnd++;
                Console.WriteLine();
            }

            for (int lastRow = 1; lastRow <=(N*2-3); lastRow++)
            {
                if (N-1==lastRow)
                {
                    Console.Write(asterisk);
                }
                else
                {
                    Console.Write(dot);
                }
            }
            Console.WriteLine();
        }
    }
}
