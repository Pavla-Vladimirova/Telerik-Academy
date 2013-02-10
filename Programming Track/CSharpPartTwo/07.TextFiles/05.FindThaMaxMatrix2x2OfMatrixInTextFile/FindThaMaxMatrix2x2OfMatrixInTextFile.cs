using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.FindThaMaxMatrix2x2OfMatrixInTextFile
{
    class FindThaMaxMatrix2x2OfMatrixInTextFile
    {
        static void Main(string[] args)
        {
            WriteResultInTextFile();
        }

        static int[,] GetMatrixFromFileToIntArray()
        {
            Console.WriteLine("Write a path to file to read");
            string path = Console.ReadLine();
            using ( StreamReader readFile = new StreamReader(path))
            {
                string fileToString = readFile.ReadLine();
                int arraySize = Convert.ToInt32(fileToString);
                int[,] matrix=new int[arraySize,arraySize];
              
                int row=0;
                fileToString = readFile.ReadLine();
                while (fileToString != null)
                {
                    string[] currentLine = fileToString.Split(' ');
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        matrix[row, col] = Convert.ToInt32(currentLine[col]);
                    }
                    row++;
                    fileToString = readFile.ReadLine();
                }
                return matrix;
            }
        }

        static int GetMaxSumOfMatrix2x2()
        {
            int[,] matrix = GetMatrixFromFileToIntArray();
            int maxSum = Int32.MinValue;
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int currentSum = matrix[row, col] + matrix[row, col + 1] +
                    matrix[row + 1, col] + matrix[row + 1, col + 1];
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                    }
                }
            }
            return maxSum;
        }

        static void WriteResultInTextFile()
        {
            Console.WriteLine("Write the path where you want to save the file");
            string savePath = Console.ReadLine();
            using (StreamWriter newFile=new StreamWriter(savePath))
            {
                newFile.WriteLine(GetMaxSumOfMatrix2x2());
            }
        }
    }
}
