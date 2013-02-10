using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.TheBiggerOfThreeNumbers
{
    class TheBiggerOfThreeNumbers
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
            
            int maxNum=firstNum;
            if (secondNum > maxNum)
            {
                maxNum = secondNum;
            }
            if (thirdNum > maxNum)
            {
                maxNum = thirdNum;
            }
            Console.WriteLine("The maximum number is {0}",maxNum);
        }
    }
}
