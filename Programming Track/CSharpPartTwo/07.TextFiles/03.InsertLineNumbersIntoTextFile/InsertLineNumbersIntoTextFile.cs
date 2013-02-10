using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.InsertLineNumbersIntoTextFile
{
    class InsertLineNumbersIntoTextFile
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write the path to the file");
            string pathFile = Console.ReadLine();
            Console.WriteLine("Write the path to the file where you want to write the new text");
            string newPathFile = Console.ReadLine();
            InsertLineNumber(pathFile,newPathFile);
        }

        static void InsertLineNumber(string path,string newPath)
        {
            using (StreamReader file=new StreamReader(path))
            {
                using (StreamWriter newFile = new StreamWriter(newPath))
                {
                      StringBuilder newString = new StringBuilder();
                    int currentLineNumber = 1;
                    string currentLine = file.ReadLine();
                    while (currentLine != null)
                    {
                        newString.Append(currentLineNumber);
                        newString.Append('.');
                        newString.Append(currentLine);
                        newString.Append(Environment.NewLine);
                        currentLineNumber++;
                        currentLine = file.ReadLine();
                    }
                    newFile.WriteLine(newString.ToString());
                    return;
                }
            }
        }
    }
}
