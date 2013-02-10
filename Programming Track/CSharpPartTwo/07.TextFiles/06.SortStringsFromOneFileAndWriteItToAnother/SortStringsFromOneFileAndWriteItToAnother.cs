using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SortStringsFromOneFileAndWriteItToAnother
{
    class SortStringsFromOneFileAndWriteItToAnother
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a path to file to read");
            string pathFile = Console.ReadLine();
            Console.WriteLine("Write a path to save the file");
            string savePath = Console.ReadLine();
            WriteSortedStringToNewFile(pathFile, savePath);
        }

        static void WriteSortedStringToNewFile(string path,string newPath)
        {
            using (StreamReader file=new StreamReader(path))
            {
                using (StreamWriter newFile=new StreamWriter(newPath))
                {
                    List<string> listOfStrings = new List<string>();
                    string currentString = file.ReadLine();
                    while (currentString!=null)
                    {
                        listOfStrings.Add(currentString);
                        currentString = file.ReadLine();
                    }
                    listOfStrings.Sort();
                    for (int i = 0; i < listOfStrings.Count; i++)
                    {
                       newFile.WriteLine(listOfStrings[i]);
                    }
                    return;
                }
            }
        }
    }
}
