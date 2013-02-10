using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N3NumberComparison
{
    class NumberComparison
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write two numbers to compare:");
            float firstNum = float.Parse(Console.ReadLine());
            float secondNum = float.Parse(Console.ReadLine());
            float precision = 0.000001f;
            bool compare = Math.Abs(firstNum - secondNum) <= precision;
            Console.WriteLine(compare);
        }
    }
}
