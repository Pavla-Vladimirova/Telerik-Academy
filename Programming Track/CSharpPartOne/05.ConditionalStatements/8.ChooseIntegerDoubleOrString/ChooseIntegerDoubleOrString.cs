using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.ChooseIntegerDoubleOrString
{
    class ChooseIntegerDoubleOrString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write 0 to input Integer Values,or 1 to input Double Values,or 2 to input String Values");
            byte choice = byte.Parse(Console.ReadLine());
            switch (choice)
            {
                case 0:
                    {
                        Console.WriteLine("Write an Integer Value");
                        int intNumber = int.Parse(Console.ReadLine());
                        intNumber = intNumber + 1;
                        Console.WriteLine("Your number now is {0}",intNumber);
 
                    } break;
                case 1:
                    {
                        Console.WriteLine("Write a Double Value");
                        double doubleNumber = double.Parse(Console.ReadLine());
                        doubleNumber = doubleNumber + 1;
                        Console.WriteLine("Your number now is {0}", doubleNumber);
                    }break;
                case 2:
                   {
                       Console.WriteLine("Write an String Value");
                       string stringValue = Console.ReadLine();
                       stringValue = stringValue + "*";
                       Console.WriteLine("Your value now is {0}", stringValue);
                   }break;
            }
        }
    }
}
