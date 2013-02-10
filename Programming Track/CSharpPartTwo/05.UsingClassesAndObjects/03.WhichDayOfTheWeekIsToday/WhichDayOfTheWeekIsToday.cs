using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.WhichDayOfTheWeekIsToday
{
    class WhichDayOfTheWeekIsToday
    {
        static void Main(string[] args)
        {
            DayOfWeek today = DateTime.Today.DayOfWeek;
            Console.WriteLine("Which day of week is today? - {0}", today);
        }
    }
}
