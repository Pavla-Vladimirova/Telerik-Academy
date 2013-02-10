using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.ExtractOnlyTextWithoutTagsFromXMLFile
{
    class ExtractOnlyTextWithoutTagsFromXMLFile
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write the path to the file");
            string pathFile = Console.ReadLine();
            Console.WriteLine("Write the path to the file where you want to write the new text");
            string newPathFile = Console.ReadLine();
            ExtractWords(pathFile, newPathFile);
        }

        static void ExtractWords(string path, string newPath)
        {
            using (StreamReader file = new StreamReader(path))
            {
                using (StreamWriter newFile = new StreamWriter(newPath))
                {
                    StringBuilder newChars = new StringBuilder();
                    int current = file.Read();
                    char currentChar = Convert.ToChar(current);
                    while (!file.EndOfStream)
                    {
                        if (current == 60) //60='<'
                        {
                            while (current != 62) //62='>'
                            {
                                current = file.Read();
                            }
                            if (current == 62)
                            {
                                current = file.Read();
                                if ((newChars.ToString() != "") ^ (newChars.ToString() == "\r\n"))
                                {
                                    Console.WriteLine(newChars.ToString());
                                    newFile.WriteLine(newChars.ToString());
                                }
                                newChars = new StringBuilder();
                            }
                        }
                        else
                        {
                            currentChar = Convert.ToChar(current);
                            newChars.Append(currentChar);
                            current = file.Read();
                        }
                    }
                    return;
                }
            }
        }
    }
}
