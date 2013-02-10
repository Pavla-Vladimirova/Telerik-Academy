using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N16PrintTheASCIITable
{
    class N16PrintTheASCIITable
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 127; i++)
            {
                char character = (char)i;
                Console.WriteLine("No " + i + " Character: " + character);
            }
        }
    }
}
