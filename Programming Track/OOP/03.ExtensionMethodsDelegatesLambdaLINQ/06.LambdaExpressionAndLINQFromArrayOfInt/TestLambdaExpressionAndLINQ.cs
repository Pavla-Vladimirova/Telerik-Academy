using System;
using System.Linq;

//06.Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.

namespace _06.LambdaExpressionAndLINQFromArrayOfInt
{
    class TestLambdaExpressionAndLINQ
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 13, 83, 21, 36, 49, 63, 30, 56, 441, 3 };

            //with Lambda Epxression
            var foundNumbersWithLambda = numbers.Where(num => num % 7 == 0 && num % 3 == 0).Select(num => num);
            Console.WriteLine("Numbers divisible by 7 and 3 (with lambda expression)");
            foreach (var num in foundNumbersWithLambda)
            {
                Console.Write("{0} ",num);
            }
            Console.WriteLine();

            //with LINQ
            var foundNumbersWithLinq =
                from num in numbers
                where num % 7 == 0 && num % 3 == 0
                select num;
            Console.WriteLine("Numbers divisible by 7 and 3 (with LINQ)");
            foreach (var num in foundNumbersWithLinq)
            {
                Console.Write("{0} ", num);
            }
            Console.WriteLine();
        }
    }
}
