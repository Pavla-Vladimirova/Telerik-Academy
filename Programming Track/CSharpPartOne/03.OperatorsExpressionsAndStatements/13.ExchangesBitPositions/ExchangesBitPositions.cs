using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.ExchangesBitPositions
{
    class ExchangesBitPositions
    {
        static void Main(string[] args)
        {
            string welcomeMsg =  "Please enter n: ";
            Console.Write(welcomeMsg);
            int userNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Your number in binary is: {0}", Convert.ToString(userNum, 2).PadLeft(32, '0'));
            int firstToSwap = 24;
            firstToSwap--; // counting starts from 0

            int mask = 7 << 3;
            int temp = userNum & mask;
            int firstThreeBits = temp >> 3 ;

            mask = 7 << 24;
            temp = userNum & mask;
            int secondThreeBits = temp >> 24;

            mask = ~(7 << 3);
            userNum &= mask;

            userNum |= (secondThreeBits << 3);

            mask = ~(7 << 24);
            userNum &= mask;

            userNum |= (firstThreeBits << 24);

            Console.WriteLine("After the change, your number is: {0}", Convert.ToString(userNum, 2).PadLeft(32, '0'));
        }
    }
}
