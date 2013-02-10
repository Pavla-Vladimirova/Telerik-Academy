using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.DivideBy5and7AtTheSameTime
{
    class DivideBy5and7AtTheSameTime
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write an integer number");
            int numToCheck = int.Parse(Console.ReadLine());
            bool division = ((numToCheck % 5 == 0) && (numToCheck % 7 == 0));
            Console.WriteLine(division);
        }
    }
}
