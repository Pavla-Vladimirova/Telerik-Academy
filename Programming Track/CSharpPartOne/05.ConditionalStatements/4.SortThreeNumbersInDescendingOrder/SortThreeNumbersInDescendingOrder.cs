using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.SortThreeNumbersInDescendingOrder
{
    class SortThreeNumbersInDescendingOrder
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wrtie three numbers");
            Console.WriteLine("Write the first one:");
            double firstNum = double.Parse(Console.ReadLine());
            Console.WriteLine("Write the second one:");
            double secondNum = double.Parse(Console.ReadLine());
            Console.WriteLine("Write the third one:");
            double thirdNum = double.Parse(Console.ReadLine());
            double exchange;

            exchange = firstNum;
            if (secondNum < firstNum)
            {
                exchange = secondNum;
                secondNum = firstNum;
                firstNum = exchange;
            }
            if (thirdNum < firstNum)
            {
                exchange = thirdNum;
                thirdNum = firstNum;
                firstNum = exchange;
            }
            if (thirdNum < secondNum)
            {
                exchange = thirdNum;
                thirdNum = secondNum;
                secondNum = exchange;
            }
            Console.WriteLine("The numbers now are: {0},{1},{2}",thirdNum,secondNum,firstNum);
        }
    }
}
