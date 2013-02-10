﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.ChangeTheWordSTARTwithFINISHinTextFile
{
    class ChangeTheWordSTARTwithFINISHinTextFile
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Write the path to the file");
            string pathFile = Console.ReadLine();
            Console.WriteLine("Write the path to save the file");
            string savePath = Console.ReadLine();
            ChangeSTARTwithFINISH(pathFile,savePath);
        }

        static void ChangeSTARTwithFINISH(string path,string newPath)
        {
            using (StreamReader file = new StreamReader(path))
            {
                using (StreamWriter newFile = new StreamWriter(newPath))
                {
                    string fileToString = file.ReadLine();
                    
                    while (fileToString != null)
                    {
                        string replaced=fileToString.Replace("start", "finish");
                        newFile.WriteLine(replaced);
                        fileToString = file.ReadLine();
                    }
                    return;
                }
            }
        }
    }
}
