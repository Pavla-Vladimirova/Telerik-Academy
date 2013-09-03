using System;

namespace Matrix
{
    public class MatrixGame 
    {
        public static Direction ChangeDirection(Direction direction ) 
        {
            int numberOfDirections = 8;
            int[] directionsX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] directionsY = { 1, 0, -1, -1, -1, 0, 1, 1 };
            int currentNumberOfDirection = 0;

            for (int number = 0; number < numberOfDirections; number++)
            {
                if (directionsX[number] == direction.X && directionsY[number] == direction.Y) 
                { 
                    currentNumberOfDirection = number; 
                    break; 
                }
            }

            if (currentNumberOfDirection == numberOfDirections-1)
            {
                direction.X = directionsX[0];
                direction.Y = directionsY[0]; 
            }
            else
            {
                direction.X = directionsX[currentNumberOfDirection + 1];
                direction.Y = directionsY[currentNumberOfDirection + 1];
            }
            return direction;
        }

        public static bool CheckIfThereIsPossibleDirection( int[,] arr, MatrixCell cell)
        {
            int[] directionsX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] directionsY = { 1, 0, -1, -1, -1, 0, 1, 1 };
            for( int i = 0; i < 8; i++ )
            {
                if (cell.X + directionsX[i] >= arr.GetLength(0) || cell.X + directionsX[i] < 0)
                {
                    directionsX[i] = 0;
                }


                if (cell.Y + directionsY[i] >= arr.GetLength(0) || cell.Y + directionsY[i] < 0)
                {
                    directionsY[i] = 0;
                }
            }

            for (int i = 0; i < 8; i++)
            {
                if (arr[cell.X + directionsX[i], cell.Y + directionsY[i]] == 0)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool CheckIfOutsideTheMatrix(int matrixSize, MatrixCell currentCell, Direction direction)
        {
            return currentCell.X + direction.X >= matrixSize || currentCell.X + direction.X < 0 ||
                                currentCell.Y + direction.Y >= matrixSize || currentCell.Y + direction.Y < 0;
        }

        public static MatrixCell GetNewCellOnRestart ( int[,] arr, MatrixCell cell)
        {
            cell.X = 0;
            cell.Y = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    if (arr[i, j] == 0)
                    {
                        cell.X = i;
                        cell.Y = j; 
                        return cell;
                    }
                }
            }
            return cell;
        }

        public static void DrawMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0,3}", matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
        
        static void Main( string[] args )
        {
            //Console.WriteLine( "Enter a positive number " );
            //string input = Console.ReadLine(  );
            //int n = 0;
            //while ( !int.TryParse( input, out n ) || n < 0 || n > 100 )
            //{
            //    Console.WriteLine( "You haven't entered a correct positive number" );
            //    input = Console.ReadLine(  );
            //}
            int matrixSize = 3;
            int[,] matrix = new int[matrixSize, matrixSize];
            int number = 1;
            MatrixCell currentCell = new MatrixCell();
            currentCell.X = 0;
            currentCell.Y = 0;
            Direction direction=new Direction();
            direction.X = 1;
            direction.Y = 1;
            matrix[currentCell.X, currentCell.Y] = number;

            while( CheckIfThereIsPossibleDirection( matrix, currentCell))
            {
                while ((CheckIfOutsideTheMatrix(matrixSize, currentCell, direction) || 
                    matrix[currentCell.X + direction.X, currentCell.Y + direction.Y] != 0))
                {
                    direction=ChangeDirection(direction);
                }

                currentCell.X += direction.X; 
                currentCell.Y += direction.Y;
                number++;
                matrix[currentCell.X, currentCell.Y] = number;
            }

            DrawMatrix(matrix);

            currentCell = GetNewCellOnRestart(matrix, currentCell);

            if( currentCell.X != 0 && currentCell.Y != 0 )
            {
                direction.X = 1;
                direction.Y = 1;
                matrix[currentCell.X, currentCell.Y] = number;

                while (CheckIfThereIsPossibleDirection(matrix, currentCell))
                {   
                    while ((CheckIfOutsideTheMatrix(matrixSize, currentCell, direction) ||
                            matrix[currentCell.X + direction.X, currentCell.Y + direction.Y] != 0))
                    {
                        direction = ChangeDirection(direction);
                    }

                    currentCell.X += direction.X;
                    currentCell.Y += direction.Y;
                    number++;
                    matrix[currentCell.X, currentCell.Y] = number;
                }
            }

            DrawMatrix(matrix);
        }
    }
}
