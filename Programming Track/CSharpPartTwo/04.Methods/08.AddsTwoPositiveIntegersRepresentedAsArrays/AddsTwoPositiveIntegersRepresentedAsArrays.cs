using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.AddsTwoPositiveIntegersRepresentedAsArrays
{
    class AddsTwoPositiveIntegersRepresentedAsArrays
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write the first number");
            string firstInputNumber = Console.ReadLine();
            Console.WriteLine("Write the second number");
            string secondInputNumber =Console.ReadLine();
            //add the numbers into arrays
            int[] firstDigits = (AddNumbersInArray(firstInputNumber));
            int[] secondDigits = AddNumbersInArray(secondInputNumber);
            //print numbers
            PrintArray(firstDigits);
            Console.Write(" + ");
            PrintArray(secondDigits);
            Console.WriteLine("=");
            //makes the ones to be at index 0,tens to be at index 1 and so on...
            Array.Reverse(firstDigits); 
            Array.Reverse(secondDigits);
           //find the result and reverse it as the numbers were add also reversed
            int[] result = FindTheSumOfTwoNumbers(firstDigits, secondDigits);
            Array.Reverse(result);
            //print result
            PrintArray(result);
            Console.WriteLine();          
        }

        static int[] AddNumbersInArray(string number)
        {
            //add each char of the string to int array (c.toString because each element
            // in the string is char and than convert it to int to become a digit) 
            int[] Digits = number.Select(c => Convert.ToInt32(c.ToString())).ToArray();
            return Digits;
        }

        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
            return;
        }

        static int[] FindTheSumOfTwoNumbers(int[] firstNum, int[] secondNum)
        {
            int maxLength = firstNum.Length;
            int minLength = secondNum.Length;
            if (secondNum.Length > maxLength)
            {
                maxLength = secondNum.Length;
                minLength = firstNum.Length;
            }
            int[] sum = new int[maxLength];
            int oneInMind = 0;
            int currentSum = 0;
            //first part
            for (int i = 0; i < minLength; i++)
            {
                currentSum = 0;
                if (oneInMind == 1)
                {
                    currentSum += oneInMind;
                }
                currentSum += firstNum[i] + secondNum[i];
                if (currentSum >= 10)
                {
                    oneInMind = 1;
                }
                else
                {
                    oneInMind = 0;
                }
                sum[i]=currentSum % 10;
            }
            //the second part
            currentSum = 0;
            for (int i = minLength; i < maxLength; i++)
            {
                if (firstNum.Length > secondNum.Length)
                {
                    currentSum = firstNum[i];
                    sum[i]=currentSum;
                }
                else
                {
                    currentSum = secondNum[i];
                    sum[i]=currentSum;
                }
            }
            return sum;
        }
    }
}
