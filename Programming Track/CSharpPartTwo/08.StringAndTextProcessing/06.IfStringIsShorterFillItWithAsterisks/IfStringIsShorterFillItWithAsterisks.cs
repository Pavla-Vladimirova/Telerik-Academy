using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.IfStringIsShorterFillItWithAsterisks
{
    class IfStringIsShorterFillItWithAsterisks
    {
        static void Main(string[] args)
        {
            string text ="";
            do
            {
                Console.WriteLine("Write the string with maximum of 20 characters");
                text = Console.ReadLine();
            } while (text.Length > 20);

            if (text.Length<20)
            {
                int neededAsterisks = 20 - text.Length;
                int initialLength = text.Length;
                for (int i = text.Length; i < initialLength+neededAsterisks; i++)
                {
                    text += "*";
                }
            }
            Console.WriteLine(text);
        }
    }
}
