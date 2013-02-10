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

            if ((firstNum < 0) && (secondNum < 0) && (thirdNum < 0))
            {
                Console.WriteLine("The sign of the product of the three numbers is \"-\" ");
            }
            else if ((firstNum > 0) && (secondNum > 0) && (thirdNum > 0))
            {
                Console.WriteLine("The sign of the product ot hte three numbers is \"+\" ");
            }
            else if (((firstNum < 0) && (secondNum < 0)) || ((firstNum < 0) && (thirdNum < 0)) || ((secondNum < 0) && (thirdNum < 0)))
            {
                Console.WriteLine("The sign of the product ot hte three numbers is \"+\" ");
            }
            else if ((firstNum < 0) || (secondNum < 0) || (thirdNum < 0))
            {
                Console.WriteLine("The sign of the product of the three numbers is \"-\" ");
            }
        }
    }
}
