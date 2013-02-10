using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _08.ChangeOnlyWholeWords
{
    class ChangeOnlyWholeWords
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write the path to the file");
            string pathFile = Console.ReadLine();
            Console.WriteLine("Write the path to save the file");
            string savePath = Console.ReadLine();
            ChangeTheWholeWords(pathFile, savePath);
        }

        static void ChangeTheWholeWords(string path, string newPath)
        {
            using (StreamReader file = new StreamReader(path))
            {
                using (StreamWriter newFile = new StreamWriter(newPath))
                {
                    string fileToString = file.ReadLine();
                    while (fileToString != null)
                    {
                        string replaced = Regex.Replace(fileToString, @"\bstart\b", "finish");
                        newFile.WriteLine(replaced);
                        fileToString = file.ReadLine();
                    }
                    return;
                }
            }
        }
    }
}
