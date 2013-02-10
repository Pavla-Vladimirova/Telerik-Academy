using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ConcatTwoTextFilesIntoNewOne
{
    class ConcatTwoTextFilesIntoNewOne
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write the paths to the files you want to concat");
            string firstPathFile = Console.ReadLine();
            string secondPathFile = Console.ReadLine();
            Console.WriteLine("Write the path where to save the file");
            string newFilePath = Console.ReadLine();
            ConcatTwoFiles(firstPathFile, secondPathFile,newFilePath);
        }

        static StreamWriter ConcatTwoFiles(string firstPath,string secondPath,string newPath)
        {
            using (StreamReader firstFile = new StreamReader(firstPath),secondFile = new StreamReader(secondPath)) 
            {
                using ( StreamWriter newFile = new StreamWriter(newPath))
                {
                    StringBuilder file = new StringBuilder();
                    file.Append(firstFile.ReadToEnd());
                    file.Append(Environment.NewLine);
                    file.Append(secondFile.ReadToEnd());
                    string concatString = file.ToString();
                    newFile.WriteLine(concatString);
                    return newFile;
                }
            }
        }
    }
}
