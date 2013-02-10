using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.CalculateDaysBetweenTwoDates
{
    class CalculateDaysBetweenTwoDates
    {
        static void Main(string[] args)
        {
            CultureInfo provider = CultureInfo.InvariantCulture;
            string format = "d.M.yyyy";
            Console.WriteLine("Write a date(day.month.year)");
            string first = Console.ReadLine();
            DateTime firstDate = DateTime.ParseExact(first,format,provider);
            Console.WriteLine("Write a date(day.month.year)");
            string second = Console.ReadLine();
            DateTime secondDate = DateTime.ParseExact(second, format, provider);
            TimeSpan span = (secondDate-firstDate);
            Console.WriteLine("The days between {0:dd.MM.yyyy} and {1:dd.MM.yyyy} are {2}",firstDate,secondDate,span.TotalDays);
        }
    }
}
