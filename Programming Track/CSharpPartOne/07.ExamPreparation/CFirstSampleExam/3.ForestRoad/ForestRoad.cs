using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.ForestRoad
{
    class ForestRoad
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char asterisk = '*';
            char dot = '.';

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i == j)
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

            for (int s = 1; s <= n - 1; s++)
            {
                for (int j = n - 1; j >= 0; j--)
                {
                    if (s == j)
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
}
