using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.IntegerNumbeNValueVPositionP
{
    class IntegerNumberNValueVPositionP
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a number");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Write a number for the bit position,you would like to know what it's value is");
            int bitPosition = int.Parse(Console.ReadLine());
            Console.WriteLine("Write the value of the bit (0 or 1)");
 
            int i = 1;  //0000 0001
            int move = i << bitPosition; //Move the 1st bit left by "bitPositions" positions
            Console.WriteLine((number & move) != 0 ? "The bit at position {0} is 1" : "The bit at position {0} is 0",bitPosition);

            if ((number & move) != 0)
            {
                Console.WriteLine("The bit in this position is 1 and now we will change it to 0");
                number = number & (~(1 << bitPosition));
                Console.WriteLine("The new number is {0}",number);
            }
            else
            {
                Console.WriteLine("The bit in this position is 0 and now we will change it to 1");
                number = number |(1 << bitPosition);
                Console.WriteLine("The new number is {0}", number);
            }
        }
    }
}
