using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Trapezoid
{
    class Trapezoid
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char asterisk = '*';
            char dot = '.';

           //top
            for (int i = 0; i < 2*n; i++)
            {
                if (i < n)
                {
                    Console.Write(dot);
                }
                else
                {
                    Console.Write(asterisk);
                }
            }
            Console.WriteLine();

            //middle
            for (int i = 0; i < n+1-2; i++)
            {
                for (int j = 0; j < 2*n; j++)
			    {
                    if ((j == n-i-1)||(j==(2*n)-1))
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

            //bottom
            for (int i = 0; i < 2*n; i++)
            {
                Console.Write(asterisk);
            }
            Console.WriteLine();
        }
    }
}
