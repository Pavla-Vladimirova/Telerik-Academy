using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CalculateSquareRoot
{
    class CalculateSquareRoot
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Write a number");
                string input = Console.ReadLine();
                try
                {
                    int number = Int32.Parse(input);
                    if (number < 0)
                    {
                        throw new System.ArithmeticException();
                    }
                    Console.WriteLine("The square root of the number is {0}", Math.Sqrt(number));
                    return;
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Invalid Number");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Number");
                }
                catch (ArithmeticException)
                {
                    Console.WriteLine("Invalid Number");
                }
                finally
                {
                    Console.WriteLine("Good bye");
                }
            }
        }
    }
}
