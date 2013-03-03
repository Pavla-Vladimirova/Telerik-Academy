using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MatrixOfNumbers
{
    class TestMatrix
    {
        static void Main(string[] args)
        {
           // Matrix<int> newMatrix = new Matrix<int>(5, 5);
           // newMatrix[0, 0] = 5;
           // newMatrix[0, 1] = 6;
           //// Console.WriteLine(newMatrix[0,0]);
            Matrix<int> firstMatrix = new Matrix<int>(2, 2);
            Matrix<int> secondMatrix = new Matrix<int>(2, 2);
            for (int i = 0; i < firstMatrix.Rows; i++)
            {
                for (int j = 0; j < firstMatrix.Cols; j++)
                {
                    firstMatrix[i, j] = i +j+1;
                }
            }
            firstMatrix.Print();

            for (int i = 0; i < secondMatrix.Rows; i++)
            {
                for (int j = 0; j < secondMatrix.Cols; j++)
                {
                    secondMatrix[i, j] = i + j;
                }
            }
            secondMatrix.Print();

            //Overloading + 
            Matrix<int> resultAdditionMatrix = firstMatrix + secondMatrix;
            resultAdditionMatrix.Print();

            //Overloading - 
            Matrix<int> resultSubtractionMatrix = firstMatrix - secondMatrix;
            resultSubtractionMatrix.Print();
        
            //Overloading *
            Matrix<int> resultMultiplicationMatrix = firstMatrix * secondMatrix;
            resultMultiplicationMatrix.Print();

            //Overloading true and false
            Matrix<int> matrix = new Matrix<int>(2,2);
            matrix[0, 0] = 3;
            matrix[0, 1] = 5;
            matrix[1, 0] = 0;
            matrix[1, 1] = 7;

            if (matrix)
            {
                Console.WriteLine("There are no zero elements");
            }
            else
            {
                Console.WriteLine("There are some zero elements");
            }
        }
    }
}
