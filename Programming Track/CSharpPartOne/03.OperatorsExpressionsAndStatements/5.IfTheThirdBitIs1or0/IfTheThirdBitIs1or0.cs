using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.IfTheThirdBitIs1or0
{
    class IfTheThirdBitIs1or0
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a number");
            int numberInDec = int.Parse(Console.ReadLine());
            int mask = 8;  //It's third bit is 1 counting from zero (8=1000)
            int check = numberInDec & mask; //only 1&1=1,if the other number's third bit is 0 the result from this check will be 0
            Console.WriteLine(check!=0 ? "The 3th bit is 1" : "The 3th bit is 0");
        }
    }
}
