using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.PrintRandomValues
{
    class PrintRandomValues
    {
        static void Main(string[] args)
        {
            Random number = new Random();       
            for (int i = 0; i < 10; i++)
            {
                int randomNumber = number.Next(100, 201);
                Console.WriteLine("{0}.Random number : {1}",i,randomNumber);
            }
        }
    }
}
