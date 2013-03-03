using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.IfAProductOfThreeNumbersIsPlusOrMinus
{
    class IfAProductOfThreeNumbersIsPlusOrMinus
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wrtie three numbers");
            Console.WriteLine("Write the first one:");
            int firstNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Write the second one:");
            int secondNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Write the third one:");
            int thirdNum = int.Parse(Console.ReadLine());
            int counter=0;
            
            if (firstNum < 0)
            {
                counter++;
            }
            if (secondNum < 0)
            {
                counter ++;
            }
            if (thirdNum < 0)
            {
                counter ++;
            }
            if ((counter % 2) == 0)// Checks if the negative numbers are even number or odd
            {
                Console.WriteLine("The sign of the product ot the three numbers is \"+\" ");
            }
            else
            {
                Console.WriteLine("The sign of the product of the three numbers is \"-\" ");
            }
        }
    }
}
