using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.IfTheSumOfSomeSubsetOfFiveNumbersIsZero
{
    class IfTheSumOfSomeSubsetOfFiveNumbersIsZero
    {
        static void Main(string[] args)
        {
            byte n = 5;
            byte sum = 0;
            int[] numbers = new int[5];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] =int.Parse( Console.ReadLine());
            }
           
            byte combination = (byte)(Math.Pow(2, n) - 1);
            for (int i = 1; i <= combination; i++)
            {
                int tempSum = 0;
                byte one=1;
                for (int j = 0; j < n; j++)
                {
                    if (((one << j) & i) != 0)
                    {
                        tempSum = tempSum + numbers[j];
                    }
                }
                if (tempSum == sum) 
                {
                    Console.WriteLine("Some subset of them is 0");
                    return;
                }
            }
            Console.WriteLine("No one of the subset is 0 ");
        }
    }
}
