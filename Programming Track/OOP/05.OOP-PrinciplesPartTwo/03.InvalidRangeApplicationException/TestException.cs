using System;
using System.Globalization;
using System.Linq;

//03.Define a class InvalidRangeException<T> that holds information about an error condition related to invalid range.
//It should hold error message and a range definition [start … end].
//Write a sample application that demonstrates the InvalidRangeException<int> and 
//InvalidRangeException<DateTime> by entering numbers in the range [1..100] and dates in the range [1.1.1980 … 31.12.2013].

namespace _03.InvalidRangeApplicationException
{
    class TestException
    {
        static void Main(string[] args)
        {
            //demonstrates the InvalidRangeException<int> by entering numbers in the range [1..100] 
            int intStart = 1;
            int intEnd = 100;
            try
            {
                Console.WriteLine("Write your number");
                int number = int.Parse(Console.ReadLine());
                if ((number < intStart) || (number > intEnd))
                {
                    throw new InvalidRangeException<int>("Out of the given range", intStart, intEnd);
                }
            }
            catch (InvalidRangeException<int> ex)
            {
               Console.WriteLine(ex.Message);
            }

            //demonstrates the InvalidRangeException<DateTime> by entering numbers in the range [1.1.1980 .. 31.12.2013].
            DateTime dateStart = new DateTime(1980, 1, 1);
            DateTime dateEnd = new DateTime(2013, 12, 31);
            try
            {
                Console.WriteLine("Write your date");
                string str = Console.ReadLine();
                DateTime date = DateTime.Parse(str,CultureInfo.CurrentCulture,DateTimeStyles.NoCurrentDateDefault);
                if ((date < dateStart) || (date > dateEnd))
                {
                    throw new InvalidRangeException<DateTime>("Out of the given range", dateStart, dateEnd);
                }
            }
            catch (InvalidRangeException<DateTime> ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
