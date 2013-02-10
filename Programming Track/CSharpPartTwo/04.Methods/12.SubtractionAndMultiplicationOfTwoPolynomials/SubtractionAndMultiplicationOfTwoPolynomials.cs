using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.SubtractionAndMultiplicationOfTwoPolynomials
{
    class SubtractionAndMultiplicationOfTwoPolynomials
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write the length of the first polynomial");
            int firstLength = int.Parse(Console.ReadLine());
            Console.WriteLine("Write the length of the second polynomial");
            int secondLength = int.Parse(Console.ReadLine());
            Console.WriteLine("Write the coefficients of the first polynomial");
            int[] firstPolynomial=new int[firstLength];
            InputCoefficientsOfPolynomial(firstPolynomial);
            Console.WriteLine("Write the coefficients of the second polynomial");
            int[] secondPolynomial = new int[secondLength];
            InputCoefficientsOfPolynomial(secondPolynomial);
            Console.WriteLine();
            //print the equation of subtraction
            Console.WriteLine("The subtraction is");
            PrintArray(firstPolynomial);
            Console.WriteLine("-");
            PrintArray(secondPolynomial);
            int[] substractResult = SubtractPolynomials(firstPolynomial, secondPolynomial);
            Console.WriteLine("=");
            PrintArray(substractResult);
            //print the equation of multiplication
            Console.WriteLine();
            Console.WriteLine("The multiplication is");
            PrintArray(firstPolynomial);
            Console.WriteLine("*");
            PrintArray(secondPolynomial);
            int[] multiplyResult = MultiplyPolynomials(firstPolynomial, secondPolynomial);
            Console.WriteLine("=");
            PrintArray(multiplyResult);   
        }

        static void InputCoefficientsOfPolynomial(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("x^{0}=",i);
                array[i] = int.Parse(Console.ReadLine());
            }
            return;
        }

        static void PrintArray(int[] array)
        {
            Console.Write("(");
            for (int i = array.Length-1; i > 1; i--)
            {
                if (array[i]==0)
                {
                    continue;
                }
                else
                {
                    Console.Write("{0}x^{1} + ", array[i], i); 
                }                   
            }
            if (array[0] == 0)
            {
                Console.Write("{0}x^{1}", array[1], 1);
            }
            else
            {
                Console.Write("{0}x^{1} + ", array[1], 1);             
                Console.Write("{0}x^{1}", array[0], 0);
            }
            Console.WriteLine(")");
            return;
        }
 
      
        static int[] SubtractPolynomials(int[] firstNum, int[] secondNum)
        {
            int maxLength = firstNum.Length;
            int minLength = secondNum.Length;
            if (secondNum.Length > maxLength)
            {
                maxLength = secondNum.Length;
                minLength = firstNum.Length;
            }
            int[] sum = new int[maxLength];
            int currentSum = 0;
            for (int i = 0; i < minLength; i++)
            {
                currentSum = 0;
                currentSum = firstNum[i] - secondNum[i];
                sum[i] = currentSum;

            }
            currentSum = 0;
            for (int i = minLength; i < maxLength; i++)
            {
                if (firstNum.Length > secondNum.Length)
                {
                    currentSum = firstNum[i];
                    sum[i] = currentSum;
                }
                else
                {
                    currentSum = secondNum[i];
                    sum[i] = currentSum;
                }
            }
            return sum;
        }

        static int[] MultiplyPolynomials(int[] firstNum, int[] secondNum)
        {
            int[] sum = new int[firstNum.Length*secondNum.Length];
            int index = 0;
            for (int i = 0; i <firstNum.Length; i++)
            {
                for (int j = 0; j < secondNum.Length; j++)
                {
                    index = i + j;                   
                    sum[index] += firstNum[i] * secondNum[j];
                }
            }
            return sum;
        }
    }
}
