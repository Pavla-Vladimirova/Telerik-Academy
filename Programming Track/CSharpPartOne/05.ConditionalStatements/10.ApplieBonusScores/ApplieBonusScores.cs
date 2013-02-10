using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.ApplieBonusScores
{
    class ApplieBonusScores
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a digit (0-9)");
            int digit;
            bool isDigit = int.TryParse(Console.ReadLine(), out digit);
            if (isDigit)
            {
                switch (digit)
                {
                    case 1:
                    case 2:
                    case 3:
                        {
                            digit = digit * 10;
                            Console.WriteLine(digit);
                        } break;
                    case 4:
                    case 5:
                    case 6:
                        {
                            digit = digit * 100;
                            Console.WriteLine(digit);
                        } break;
                    case 7:
                    case 8:
                    case 9:
                        {
                            digit = digit * 1000;
                            Console.WriteLine(digit);
                        } break;
                    default:
                        Console.WriteLine("There has been an error: the input digit is either 0 or not a digit at all ");
                        break;
                }
            }
            else
            {
                Console.WriteLine("There has been an error: the input digit is either 0 or not a digit at all ");
            }
        }
    }
}
