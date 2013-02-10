using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.ComareTwoTextFiles
{
    class ComareTwoTextFiles
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write the path to files to compare");
            string firstPathFile = Console.ReadLine();
            string secondPathFile = Console.ReadLine();
            CompareLineByLine(firstPathFile, secondPathFile);
        }

        static void CompareLineByLine(string firstPath, string secondPath)
        {
            using (StreamReader firstFile = new StreamReader(firstPath), secondFile = new StreamReader(secondPath))
            {
                int firstFileLength = GetLength(firstPath);
                int secondFileLength = GetLength(secondPath);
                int equalLines = 0;
                if (firstFileLength == secondFileLength)
                {
                    string first = firstFile.ReadLine();
                    string second = secondFile.ReadLine();
                    while (first != null)
                    {
                        if (String.Compare(first, second) == 0)
                        {
                            equalLines++;
                        }
                        first = firstFile.ReadLine();
                        second = secondFile.ReadLine();
                    }
                    Console.WriteLine("The equal lines are {0} and the different lines are {1}", equalLines, firstFileLength - equalLines);
                }
                else
                {
                    Console.WriteLine("The two files are not with equal length");
                }
            }
            return;
        }

        static int GetLength(string path)
        {
            using (StreamReader file = new StreamReader(path))
            {
                int fileLength = 0;
                while (file.ReadLine() != null)
                {
                    fileLength++;
                }
                return fileLength;
            }
        }
    }
}
