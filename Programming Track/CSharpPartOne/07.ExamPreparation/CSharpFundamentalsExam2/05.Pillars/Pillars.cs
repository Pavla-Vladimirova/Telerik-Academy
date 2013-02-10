using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Pillars
{
    class Pillars
    {
        static void Main(string[] args)
        {
            byte[] inputNumbers = new byte[8];
            for (int i = 0; i < inputNumbers.Length; i++)
            {
                inputNumbers[i] = byte.Parse(Console.ReadLine());
            }

            //Fill in the grid
            byte[,] gridArray = new byte[8, 8];

            byte currentNumber = 0;
            byte mask = 1;
            int result = 0;
            for (int row = 0; row < gridArray.GetLength(0); row++)
            {
                currentNumber = inputNumbers[row];
                for (int col = gridArray.GetLength(1) - 1; col >= 0; col--)
                {
                    result = 0;
                    result = (mask << col) & currentNumber;
                    if (result != 0)
                    {
                        gridArray[row, col] = 1;
                    }
                    else
                    {
                        gridArray[row, col] = 0;
                    }
                }
            }

            int pillarColumn = 0;
            int counterLeft = 0;
            int counterRight = 0;
            bool flag = true;
            for ( pillarColumn = 7; pillarColumn >= 0; pillarColumn--)
            {
                counterLeft = 0;
                counterRight = 0;
                //from the example: from 7 to 5+1=6(to where the pillar is) we count how many bits is on the left side
                for (int col =  gridArray.GetLength(1)-1; col >=pillarColumn+1; col--)
                {
                    //check over every column and count how many 1 there are 
                    for (int row = 0; row < gridArray.GetLength(0); row++)
                    {
                        if (gridArray[row, col] == 1)
                        {
                            counterLeft++;
                        }
                    }
                }
                //from the example: from 0 to 5-1=4(to where the pillar is) we count how many bits is on the right side
                for (int col =0; col <= pillarColumn - 1; col++)
                {
                    //check over every column and count how many 1 there are 
                    for (int row = 0; row < gridArray.GetLength(0); row++)
                    {
                        if (gridArray[row, col] == 1)
                        {
                            counterRight++;
                        }
                    }
                }
                if (counterLeft == counterRight)
                {
                    Console.WriteLine(pillarColumn);
                    Console.WriteLine(counterLeft);
                    flag = false;
                    break;
                }                          
            }

            if (flag==true)
            {
                Console.WriteLine("No");
            }
        }
    }
}
