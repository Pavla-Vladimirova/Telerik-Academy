using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CheckIfGivenYearIsLeapYear
{
    class CheckIfGivenYearIsLeapYear
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write year");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Is leap year? - {0}",DateTime.IsLeapYear(year));
        }
    }
}
