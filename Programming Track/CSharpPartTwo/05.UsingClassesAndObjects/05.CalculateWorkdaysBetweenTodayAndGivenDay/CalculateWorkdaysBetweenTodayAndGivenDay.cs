using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CalculateWorkdaysBetweenTodayAndGivenDay
{
    class CalculateWorkdaysBetweenTodayAndGivenDay
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write the date(after today) to which you want to calculate the workdays");
            DateTime givenDate = DateTime.Parse(Console.ReadLine());
            DateTime[] OfficialHolidays = new DateTime[]
            {
                new DateTime(2013,01,01),
                new DateTime(2013,03,03),
                new DateTime(2013,05,01),
                new DateTime(2013,05,05),
                new DateTime(2013,05,06),
                new DateTime(2013,05,24),
                new DateTime(2013,09,06),
                new DateTime(2013,09,22),
                new DateTime(2013,12,24),
                new DateTime(2013,12,25)                
            };
            DateTime today=new DateTime();
            today=DateTime.Today;
            int workdays = 0;
            for (DateTime i = today; i <= givenDate; i=i.AddDays(1) )
            {             
                if ((i.DayOfWeek==DayOfWeek.Saturday)||(i.DayOfWeek==DayOfWeek.Sunday))
                {
                    continue;
                }
                else
                {
                    workdays++;
                }
                for (int j = 0; j < OfficialHolidays.Length; j++)
                {
                    if (i==OfficialHolidays[j])
                    {
                        workdays--;
                    }
                }
            }
            Console.WriteLine("The workdays form {0:dd.MM.yyyy}(today) to {1:dd.MM.yyyy}(including) are {2}", today, givenDate, workdays);
        }
    }
}
