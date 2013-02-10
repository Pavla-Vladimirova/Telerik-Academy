using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _13.FindNumberOfRepetitionOfWordsInTextFileListedInAnother
{
    class FindNumberOfRepetitionOfWordsInTextFileListedInAnother
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Write the path to the file");
            string pathFile = Console.ReadLine();
            Console.WriteLine("Write the path to the file with the words listed");
            string listPathFile = Console.ReadLine();
            Console.WriteLine("Write the path to save the file");
            string savePath = Console.ReadLine();
            FindListedWords(pathFile, listPathFile, savePath);
        }

        static void FindListedWords(string path, string listPath, string newPath)
        {
            try
            {
                using (StreamReader file = new StreamReader(path), listFile = new StreamReader(listPath))
                {
                    using (StreamWriter newFile = new StreamWriter(newPath))
                    {
                        //split words into array
                        char[] charSeparators = new char[] { ' ', '\r', '\n' };
                        string[] words = (listFile.ReadToEnd()).Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);
                        Dictionary<string, int> repeatingWords = new Dictionary<string, int>();
                        for (int i = 0; i < words.Length; i++)
                        {
                            repeatingWords.Add(words[i], 0);
                        }
                        string readFile = file.ReadLine();
                        while (readFile != null)
                        {
                            Match match = Regex.Match(readFile, @"\b\w+\b", RegexOptions.IgnoreCase);//for each whole word chek if it has not alredy been added,if it has been met for n-th time add +1;
                            while (match.Success)
                            {
                                string currentWord = match.Value;
                                if (repeatingWords.ContainsKey(currentWord) == true)
                                {
                                    repeatingWords[currentWord]++;
                                }
                                match = match.NextMatch();
                            }
                            readFile = file.ReadLine();
                        }
                        var items = repeatingWords.OrderByDescending(i => i.Value);
                        foreach (var pair in items)
                        {
                            newFile.WriteLine("{0}, {1}", pair.Key, pair.Value);
                        }
                    }
                }
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Some of the paths may be null");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Some of the paths may be empty");
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("Either some of the paths length is over 248 characters or file name is over 260 characters");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Some of the files cannot be found");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Some of the paths are not valid(not existing)");
            }
            catch (FileLoadException)
            {
                Console.WriteLine("Some of the files cannot be loaded");
            }
            catch (System.Security.SecurityException)
            {
                Console.WriteLine("You don't have the requiered permission to get some of the files");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Either some of the files you are trying to get are read-only,or this operation is not supported on the current platform,or the path is a directory.");
            }
          
          
        }
    }
}
