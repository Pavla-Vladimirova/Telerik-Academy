using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.IfANumbersThirdDigitIs7
{
    class IfANumbersThirdDigitIs7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write an integer number");
            int numToCheck =int.Parse(Console.ReadLine());
            int divisionBy100 = (numToCheck / 100);
            int divisionBy10 = (divisionBy100 % 10);
            bool checking = (divisionBy10 == 7);
            Console.WriteLine(checking);
        }
    }
}
