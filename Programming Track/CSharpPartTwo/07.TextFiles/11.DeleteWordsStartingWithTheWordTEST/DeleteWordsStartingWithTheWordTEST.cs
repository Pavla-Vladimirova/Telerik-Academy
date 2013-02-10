using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _11.DeleteWordsStartingWithTheWordTEST
{
    class DeleteWordsStartingWithTheWordTEST
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write the path to the file");
            string pathFile = Console.ReadLine();
            Console.WriteLine("Write the path to save the file");
            string savePath = Console.ReadLine();
            DeleteWordsStartingWithTEST(pathFile, savePath);
        }

        static void DeleteWordsStartingWithTEST(string path, string newPath)
        {
            using (StreamReader file = new StreamReader(path))
            {
                using (StreamWriter newFile = new StreamWriter(newPath))
                {
                    string fileToString = file.ReadLine();

                    while (fileToString != null)
                    {
                        string replaced = Regex.Replace(fileToString, @"\btest\w+", "");
                        newFile.WriteLine(replaced);
                        fileToString = file.ReadLine();
                    }
                    return;
                }
            }
        }
    }
}
