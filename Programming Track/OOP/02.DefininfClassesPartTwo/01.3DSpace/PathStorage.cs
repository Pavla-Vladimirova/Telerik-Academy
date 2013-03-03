using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

//04.Create a static class PathStorage with static methods to save and load paths from a text file. Use a file format of your choice.

namespace _01._3DSpace
{
    public static class PathStorage
    {
        private static List<Path> pathsStorage=new List<Path>();

        public static List<Path> PathsStorage
        {
            get{  return pathsStorage;  }
            set{ pathsStorage = value; }
        }

        public static void SaveAndLoadFromFile()
        {
            //load paths form the file
            using (StreamReader readFile = new StreamReader(@"..\..\PathStorage.txt"))
            {
                string lines = readFile.ReadLine();
                while (lines != null)
                {
                    Path currentPath = new Path();
                    string[] splittedPoints = lines.Split(new char[] { ';' },StringSplitOptions.RemoveEmptyEntries);
                    for (int i = 0; i < splittedPoints.Length; i++)
                    {
                        string[] splitted = splittedPoints[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        int X = Convert.ToInt32(splitted[0]);
                        int Y = Convert.ToInt32(splitted[1]);
                        int Z = Convert.ToInt32(splitted[2]);
                        currentPath.AddPointWithGivenCoordinates(X, Y, Z);
                    }
                    //save paths from the file into PathStorage
                    PathsStorage.Add(currentPath);
                    lines = readFile.ReadLine();
                }
            }
        }

        public static void PrintStorage()
        {
            Console.WriteLine("PATH STORAGE");
            foreach (var item in PathsStorage)
            {
              item.PrintPath();
            }   
        }
    }
}
