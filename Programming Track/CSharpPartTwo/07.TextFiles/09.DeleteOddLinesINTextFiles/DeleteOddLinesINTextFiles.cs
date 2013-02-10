using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.DeleteOddLinesINTextFiles
{
    class DeleteOddLinesINTextFiles
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a path to file to read");
            string pathFile = Console.ReadLine();
            DeleteOddLines(pathFile);
        }
        static void DeleteOddLines(string path)
        {
            StringBuilder newString = new StringBuilder();
            using (StreamReader file = new StreamReader(path))
            {
                string oddLines = file.ReadLine();
                int counter = 1; //start form 1 not from 0 so that we read the real odd lines in the file 1,3,5...
                while (oddLines != null)
                {
                    if (counter % 2 != 0)
                    {
                        oddLines = oddLines.Remove(0, oddLines.Length - 1);
                    }
                    else
                    {
                        newString.Append(oddLines);
                        newString.Append(Environment.NewLine);
                    }
                    oddLines = file.ReadLine();                   
                    counter++;
                }
            }
            //when file closes after reading open it again and overwrite it by putting "false" after the path
            using (StreamWriter newFile = new StreamWriter(path,false))
            {
                newFile.WriteLine(newString.ToString());
                return;
            }
        }
    } 
}
