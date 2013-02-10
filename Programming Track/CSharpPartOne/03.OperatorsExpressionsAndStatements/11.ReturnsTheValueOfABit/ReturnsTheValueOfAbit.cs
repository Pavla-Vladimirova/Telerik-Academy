using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ReturnsTheValueOfABit
{
    class ReturnsTheValueOfAbit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a number");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Write a number for the bit position counting from zero,you would like to know what its value is");
            int bitPosition = int.Parse(Console.ReadLine());
            int i = 1;  //0000 0001
            int mask = i << bitPosition; //Move the 1st bit left by "bitPositions" positions
            int numberAndMask = number & mask;
            int bit = numberAndMask >> bitPosition;  // 00000000 00000001
		    Console.WriteLine(bit);   // 1
        }
    }
}
