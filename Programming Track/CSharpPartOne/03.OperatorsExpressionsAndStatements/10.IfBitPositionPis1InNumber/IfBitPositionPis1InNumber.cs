using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.IfBitPositionPis1InNumber
{
    class IfBitPositionPis1InNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a number");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Write a number for the position of the bit counting from zero (to check if it has value of 1)");
            int position = int.Parse(Console.ReadLine());
            int i = 1;  //0000 0001
            int move = i << position; //Move the 1st bit left by "p" positions
            Console.WriteLine((number&move)!=0 ? "The p-th bit in the number is 1" : "The p-th bit in number is 0");
        }
    }
}
