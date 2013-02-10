using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BinaryToDecimal
{
    class BinaryToDecimal
    {
        static void Main(string[] args)
        {
            //for both positive and negative numbers for Int64
            Console.WriteLine("Write number in binary");
            string number = Console.ReadLine();
            StringBuilder numberInBinary = new StringBuilder();
            numberInBinary.Append(number);
            long numberInDecimal=0;

            if (numberInBinary.Length == 64)
            {
                if (numberInBinary[0] == '1')
                {
                    numberInBinary.Replace('1', '0',0,1);
                    //make the number from binary to decimal
                    for (int i = 0; i < numberInBinary.Length; i++)
                    {
                        numberInDecimal += (((long)(numberInBinary[numberInBinary.Length - 1 - i]) - (long)'0') * (long)Math.Pow(2, i));
                    }
                    numberInDecimal = -1*((long.MaxValue-numberInDecimal)+1); //  since it is negative number,we have to subtract the number with the same bits but first bit 0 from 
                     Console.WriteLine(numberInDecimal);                      // the max value(64 bit),add +1 afterwards(so we don's have overflow) and multiply it with -1
                }                                                             //example(for 8bit(easier)) -5=1111 1011 change first bit 1 to 0 -> 123=0111 1011 then maxValue=127
            }                                                                 // -1((127-123)+1) =-5 
            else
            {
                for (int i = 0; i < numberInBinary.Length; i++)
                {
                    numberInDecimal += (((long)(numberInBinary[numberInBinary.Length - 1 - i]) - (long)'0') * (long)Math.Pow(2, i));
                }
                Console.WriteLine(numberInDecimal);      
            }                
        }
    }
}
