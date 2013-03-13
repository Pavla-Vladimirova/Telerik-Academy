using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

//08.Define a class Matrix<T> to hold a matrix of numbers (e.g. integers, floats, decimals). 
//09.Implement an indexer this[row, col] to access the inner matrix cells.
//10.Implement the operators + and - (addition and subtraction of matrices of the same size) and * for matrix multiplication. Throw an exception when the operation cannot be performed. Implement the true operator (check for non-zero elements).


namespace _03.MatrixOfNumbers
{
    public class Matrix<T>
    {
        private T[,] numberMatrix;
        public int Rows { get; private set; }
        public int Cols { get; private set; }

        public Matrix(int NumberOfRows,int numberOfCols)
        {
            this.Rows = NumberOfRows;
            this.Cols = numberOfCols;
            numberMatrix = new T[NumberOfRows, numberOfCols];
        }

        public T this[int row,int col]
        {
            get
            {
                if (row >= numberMatrix.GetLength(0) || col >= numberMatrix.GetLength(1))
                {
                    throw new IndexOutOfRangeException(String.Format(
                     "The Matrix capacity of {0} rows or {1} cols was exceeded.", numberMatrix.GetLength(0), numberMatrix.GetLength(1)));
                }
                return numberMatrix[row,col];
            }

            set
            {
                if (row >= numberMatrix.GetLength(0) || col>= numberMatrix.GetLength(1))
                {
                    throw new IndexOutOfRangeException(String.Format(
                     "The Matrix capacity of {0} rows or {1} cols was exceeded.", numberMatrix.GetLength(0), numberMatrix.GetLength(1)));
                }
                numberMatrix[row,col] = value;
            }
        }
         
        public void Print()
        {
            Console.WriteLine("Matrix:");
            for (int i = 0; i < numberMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < numberMatrix.GetLength(1); j++)
                {
                    Console.Write("{0} ",numberMatrix[i,j]);
                }
                Console.WriteLine();
            }
        }

        public static Matrix<T> operator +(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if ((firstMatrix.Rows == secondMatrix.Rows) && (firstMatrix.Cols == secondMatrix.Cols))
            {
                Matrix<T> resultMatrix = new Matrix<T>(firstMatrix.Rows, firstMatrix.Cols);
                for (int i = 0; i < firstMatrix.Rows; i++)
                {
                    for (int j = 0; j < firstMatrix.Cols; j++)
                    {
                        resultMatrix[i, j] = (dynamic)firstMatrix[i, j] + secondMatrix[i, j];
                    }
                }
                return resultMatrix;
            }
            else
            {
                throw new ArgumentException(string.Format("The two matrices are not with equal size!"));
            }
        }

        public static Matrix<T> operator -(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if ((firstMatrix.Rows == secondMatrix.Rows) && (firstMatrix.Cols == secondMatrix.Cols))
            {
                Matrix<T> resultMatrix = new Matrix<T>(firstMatrix.Rows, firstMatrix.Cols);
                for (int i = 0; i < firstMatrix.Rows; i++)
                {
                    for (int j = 0; j < firstMatrix.Cols; j++)
                    {
                        resultMatrix[i, j] = (dynamic)firstMatrix[i, j] - secondMatrix[i, j];
                    }
                }
                return resultMatrix;
            }
            else
            {
                throw new ArgumentException(string.Format("The two matrices are not with equal size!"));
            }
        }

        public static Matrix<T> operator *(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.Rows == secondMatrix.Cols)
            {
                Matrix<T> resultMatrix = new Matrix<T>(firstMatrix.Rows, secondMatrix.Cols);
                for (int i = 0; i < firstMatrix.Rows; i++)
                {
                    for (int j = 0; j < secondMatrix.Cols; j++)
                    {
                        for (int k = 0; k < firstMatrix.Cols; k++)
                        {
                            resultMatrix[i, j] += (dynamic)firstMatrix[i, k] * secondMatrix[k, j];
                        }
                    }
                }
                return resultMatrix;
            }
            else
            {
                throw new ArgumentException(string.Format("The two matrices are not with equal size!"));
            }
        }

        public static bool operator true(Matrix<T> matrix)
        {
            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Cols; j++)
                {
                    if (((dynamic)matrix[i, j] == 0))
                        return false;
                }
            }
            return true;
           
        }

        public static bool operator false(Matrix<T> matrix)
        {
            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Cols; j++)
                {
                    if (((dynamic)matrix[i, j] == 0))
                        return false;
                }
            }
            return true;
        }

    }
}
