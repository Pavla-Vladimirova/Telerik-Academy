using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _17.CalculateTimeAfterSixHoursAndThirtyMinutes
{
    class CalculateTimeAfterSixHoursAndThirtyMinutes
    {
        static void Main(string[] args)
        {
            CultureInfo provider = CultureInfo.InvariantCulture;
            string format = "d.M.yyyy HH:m:s";
            Console.WriteLine("Write a date(day.month.year hour:minute:second )");
            string first = Console.ReadLine();
            DateTime firstDate = DateTime.ParseExact(first, format, provider);
            DayOfWeek dayAfter = firstDate.AddHours(6).AddMinutes(30).DayOfWeek;
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("bg-BG");
            Console.WriteLine("After 6 hours and 30 minutes on date {0:dd.MM.yyyy HH:mm:ss} \nwas/will be {1:dd.MM.yyyy HH:mm:ss} and the day in Bulgaria was/will be {2}",firstDate,firstDate.AddHours(6).AddMinutes(30), dayAfter);
        }
    }
}
