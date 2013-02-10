using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CheckIfBracketsInExpressionArePutCorrectly
{
    class CheckIfBracketsInExpressionArePutCorrectly
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write expression");
            string input = Console.ReadLine(); //"((a+b)/5-d)"; //")(a+b))";
            Console.WriteLine("Are the brackets correctly put? - {0}",IfBracketsAreCorrectlyPut(input));
        }
        static bool IfBracketsAreCorrectlyPut(string expression)
        {
            int counter = 0;
            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i]=='(')
                {
                    counter++;
                }
                else if (expression[i]==')')
                {
                    counter--;
                }
            }
            if (counter==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
