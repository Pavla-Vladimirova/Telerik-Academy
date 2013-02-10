using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Number1toNNotDividedBy3and7
{
    class Number1toNNotDividedBy3and7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write N");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <=n; i++)
            {
                if ((i%(3*7))==0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}
