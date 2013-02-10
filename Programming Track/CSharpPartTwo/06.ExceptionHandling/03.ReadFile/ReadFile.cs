using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ReadFile
{
    class ReadFile
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Write a path to the file you want to read");
                    string path = Console.ReadLine();
                    string readText = File.ReadAllText(path);
                    Console.WriteLine(readText);
                    return;
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("The path is null");
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Either the path is empty,or contains only white space, or contains one or more invalid characters");
                }
                catch (NotSupportedException)
                {
                    Console.WriteLine("The path is not in a valid format");
                }
                catch (PathTooLongException)
                {
                    Console.WriteLine("Either the path length is over 248 characters or file name is over 260 characters");
                }
                catch (DirectoryNotFoundException)
                {
                    Console.WriteLine("The path is not valid(not existing)");
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine("The file you are trying to get is not found");
                }
                catch (System.Security.SecurityException)
                {
                    Console.WriteLine("You don't have the requiered permission to get this file");
                }
                catch (UnauthorizedAccessException)
                {
                    Console.WriteLine("Either the file you are trying to get is read-only,or this operation is not supported on the current platform,or the path is a directory.");
                }
                catch (IOException)
                {
                    Console.WriteLine("An Input/Output error occurred while opening the file.");
                }
            }
        }
    }
}
