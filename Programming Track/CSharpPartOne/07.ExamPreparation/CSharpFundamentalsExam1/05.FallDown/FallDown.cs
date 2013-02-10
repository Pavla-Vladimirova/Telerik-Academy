using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.FallDown
{
    class FallDown
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
            for (int i = 0; i < gridArray.GetLength(0); i++)
            {
                currentNumber = inputNumbers[i];
                for (int j = gridArray.GetLength(1)-1; j >=0 ; j--)
                {
                    result = 0;
                    result = (mask << j) & currentNumber;
                    if (result!=0)
	                {
		                gridArray[i,j]=1;
	                }
                    else
                    {
                        gridArray[i,j]=0;
                    }
                }
            }

            //j -columns ; i,k-rows in a single column
            int counter = 0;
            for (int j = gridArray.GetLength(1)-1; j >=0 ; j--)
            {
                counter = 0;
                //check over every column and count how many 1 there are and make them to 0
                for (int i = 0; i < gridArray.GetLength(0); i++)
                {
                    if (gridArray[i,j]==1)
                    {
                        counter++;
                        gridArray[i, j] = 0;
                    }
                }
                //write the 1 in the rows of teh current column from bottom to top until the counter(number od the counted before 1) becomes 0 
                for (int k =gridArray.GetLength(0)-1; k >=0; k--)
                {
                    if (counter > 0)
                    {
                        gridArray[k,j] = 1;
                        counter--;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            int outputNumber = 0;
            ////byte[] outputNumbers = new byte[8];
            for (int i = 0; i < gridArray.GetLength(0); i++)
            {
                outputNumber = 0;
                for (int j = gridArray.GetLength(1) - 1; j >= 0; j--)
                {
                    outputNumber |= (gridArray[i, j] <<= j);
                }
                Console.WriteLine(outputNumber);
            }
        }
    }
}
