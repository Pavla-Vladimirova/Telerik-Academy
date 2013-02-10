using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CheckNumberInGivenRange
{
    class CheckNumberInGivenRange
    {
        static void Main(string[] args)
        {
            int startNumber = 1;
            int endNumber = 100; 
            for (int i = 0; i < 10; i++)
            {
               startNumber=ReadNumber(startNumber, endNumber);
            }
        }

        static int ReadNumber(int start, int end)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Write your number");
                    int number = int.Parse(Console.ReadLine());
                    if ((number < start) || (number > end))
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    return number;
                }
                catch (FormatException)
                {
                    Console.WriteLine("You did not enter a number");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("You entered number out of the range of Integer");
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("You entered number out of the given range");
                }
            }
        }
    }
}
