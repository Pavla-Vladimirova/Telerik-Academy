using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.PrintTheOddLines
{
    class PrintTheOddLines
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a path to file to read");
            string pathFile = Console.ReadLine();
            ReadOddLines(pathFile);
        }
        static void ReadOddLines(string path)
        {
            using ( StreamReader readFile = new StreamReader(path))
            {
                string oddLines = readFile.ReadLine();
                int counter = 1; //start form 1 not from 0 so that we read the real odd lines in the file 1,3,5...
                while (oddLines!=null)
                {
                    if (counter%2!=0)
                    {
                        Console.WriteLine(oddLines);
                    }
                    oddLines = readFile.ReadLine();
                    counter++;
                }
            }
        }
    }
}
