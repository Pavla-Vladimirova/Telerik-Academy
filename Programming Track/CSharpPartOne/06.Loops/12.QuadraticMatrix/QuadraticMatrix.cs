using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.QuadraticMatrix
{
    class QuadraticMatrix
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wrtie n");
            byte n = byte.Parse(Console.ReadLine());

            for (int i = 1; i <=n; i++)
            {
                for (int j = i; j <=i+(n-1); j++)
                {
                   Console.Write("{0,3}",j);
                }
                Console.WriteLine();
            }
        }
    }
}
