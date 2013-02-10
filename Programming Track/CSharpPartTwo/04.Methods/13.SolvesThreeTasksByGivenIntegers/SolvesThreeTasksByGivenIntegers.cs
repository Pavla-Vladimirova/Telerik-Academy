using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.SolvesThreeTasksByGivenIntegers
{
    class SolvesThreeTasksByGivenIntegers
    {
        static void Main(string[] args)
        {
            //Menu
            int choice = 0;
            Console.WriteLine("Press");
            Console.WriteLine("1 if you want to reverse a number");
            Console.WriteLine("2 if you want to find average sum of numbers");
            Console.WriteLine("3 if you want to solve the linear equation a*x+b=0");
            while (true)
            {
                choice = int.Parse(Console.ReadLine());
                if ((choice==1)||(choice==2)||(choice==3))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Write 1 of the 3 options!");
                }
            }
        
            if (choice==1)
            {
                //Reverse number
                Console.WriteLine("Write number to reverse");
                //chek if it's a non-negative number
                while (true)
                {
                    string str = Console.ReadLine();
                    uint inputNumber;
                    bool parseSuccess = UInt32.TryParse(str, out inputNumber);
                    if (parseSuccess == true)
                    {
                        Console.WriteLine("The reversed number is {0} ", ReverseNumber(inputNumber));
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Write a non-negative number");
                    }
                }
            }
            else if (choice==2)
	        {
		        //Find average of integers           
                Console.WriteLine("Specify of how many number you want find the average sum");
                int N = int.Parse(Console.ReadLine());           
                int[] inputNumbers = new int[N];
                bool IsEmpty = true;
                while (IsEmpty)
                {
                    Console.WriteLine("Write sequence of integers(the sequnece shold not be empty!):");
                    for (int i = 0; i < inputNumbers.Length; i++)
                    {
                        inputNumbers[i] = int.Parse(Console.ReadLine());
                        if (inputNumbers[i] != 0)
                        {
                            IsEmpty = false;
                        }

                    }
                }
                Console.WriteLine("The average of the sequence is {0}", AverageSum(inputNumbers)); 
	        }
            else
            {
               // Solves linear equation
                Console.WriteLine("Write 'a' ");
                //chek if is 'a' is not equal to 0
                int coefficientA = 0;
                while (true)
                {
                    coefficientA = int.Parse(Console.ReadLine());
                    if (coefficientA!=0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Write 'a' different from zaero");
                    }
                }
                Console.WriteLine("Write 'b' ");
                int coefficientB = int.Parse(Console.ReadLine());
                Console.WriteLine("The answer of a*x+b=0 is x={0}", SolvesLinearEquation(coefficientA, coefficientB));
            }       

        }

        static uint ReverseNumber(uint number)
        {
            uint reversed = 0;
            uint currentDigit = 0;
            while (number>0)
            {
                currentDigit = number % 10;
                reversed = reversed * 10 + currentDigit;
                number /= 10;
            }
            return reversed;
        }

        static double AverageSum(int[] numbers)
        {
            long sum=0;
            int counter=0;
            foreach (int element in numbers)
            {
                sum = sum + element;
                counter++;
            }
            double average = (double)sum / counter;
            return average;
        }

        static double SolvesLinearEquation(int a,int b)
        {
            double x = -b /(double) a;
            return x;
        }
    }
}
