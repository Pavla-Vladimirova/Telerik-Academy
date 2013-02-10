using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MaxOfThreeNumbers
{
    class MaxOfThreeNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write first Number");
            int fisrtInputNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Write second Number");
            int secondInputNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Write third number");
            int thirdInputNumber = int.Parse(Console.ReadLine());

            int currentResult = GetMax(fisrtInputNumber, secondInputNumber);
            int maxNumber = GetMax(currentResult, thirdInputNumber);
            Console.WriteLine("The max of numbers {0},{1},{2} is {3} ",fisrtInputNumber,secondInputNumber,thirdInputNumber,maxNumber);     
        }

        static int GetMax(int firstNum,int secondNum)
        {
            int maxNum = firstNum;
            if (secondNum>maxNum)
            {
                maxNum = secondNum;
            }
            return maxNum;
        }
    }
}
