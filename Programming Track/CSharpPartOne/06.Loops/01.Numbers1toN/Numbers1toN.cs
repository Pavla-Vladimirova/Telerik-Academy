using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Numbers1toN
{
    class Numbers1toN
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wrtie N");
            int n = int.Parse(Console.ReadLine());
            
            for (int i =1; i <= n; i++)
            {
                Console.WriteLine(i + " ");
            }
        }
    }
}
