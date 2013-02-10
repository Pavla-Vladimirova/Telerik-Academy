using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ConvertNumberToTextFrom0To999
{
    class ConvertNumberToTextFrom0To999
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a three digit number (0-999)");
            int number = int.Parse(Console.ReadLine());
            int hundreds = number / 100;
            int tens = (number % 100) / 10;
            int ones = (number % 100) % 10;
            string[] onesArray=new string[9];
           
            onesArray[0] = "one";
            onesArray[1] = "two";
            onesArray[2] = "three";
            onesArray[3] = "four";
            onesArray[4] = "five";
            onesArray[5] = "six";
            onesArray[6] = "seven";
            onesArray[7] = "eight";
            onesArray[8] = "nine";

            string[] tensArray=new string[8];
            tensArray[0] = "twenty";
            tensArray[1] = "thirty";
            tensArray[2] = "forty";
            tensArray[3] = "fifty";
            tensArray[4] = "sixty";
            tensArray[5] = "seventy";
            tensArray[6] = "eighty";
            tensArray[7] = "ninety";

            string[] tenToTwentyArray = new string[10];
            tenToTwentyArray[0] = "ten";
            tenToTwentyArray[1] = "eleven";
            tenToTwentyArray[2] = "twelve";
            tenToTwentyArray[3] = "thirteen";
            tenToTwentyArray[4] = "fourteen";
            tenToTwentyArray[5] = "fifteen";
            tenToTwentyArray[6] = "sixteen";
            tenToTwentyArray[7] = "seventeen";
            tenToTwentyArray[8] = "eighteen";
            tenToTwentyArray[9] = "nineteen";

            string[] hundredsArray=new string[9];           
            hundredsArray[0] = "one hundred";
            hundredsArray[1] = "two hundred";
            hundredsArray[2] = "three hundred";
            hundredsArray[3] = "four hundred";
            hundredsArray[4] = "five hundred";
            hundredsArray[5] = "six hundred";
            hundredsArray[6] = "seven hundred";
            hundredsArray[7] = "eight hundred";
            hundredsArray[8] = "nine hundred";

            if ((ones==0)&&(tens==0)&&(hundreds==0))
            {
                Console.WriteLine("zero");
                return;
            }
          
            for (int i = 0; i < hundredsArray.Length; i++)
            {
                if (hundreds==i+1)
                {
                    Console.Write(hundredsArray[i]+" ");
                }
            }

            if (tens == 1)
            {
                for (int i = 0; i <= onesArray.Length; i++)
                {
                    if (ones == i)
                    {
                        Console.WriteLine(tenToTwentyArray[i]); return;
                    }
                }
                
            }

            for (int i = 0; i <= tensArray.Length; i++)
            {
                if (tens==i+1)
                {
                    Console.Write(tensArray[i-1] + " ");
                }
                else if (tens == 0)
                {
                    if (ones == 0)
                    {
                        Console.WriteLine(); return;
                    }
                    else
                    {
                        break;
                    }
                }
                
            }

             for (int i = 0; i < onesArray.Length; i++)
            {
                if (ones==i+1)
                {
                    Console.Write(onesArray[i]);
                }
            }

            Console.WriteLine();
        }
    }
}
