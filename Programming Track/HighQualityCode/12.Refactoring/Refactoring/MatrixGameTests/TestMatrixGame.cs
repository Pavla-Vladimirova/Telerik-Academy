using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Matrix;

namespace MatrixGameTests
{
    [TestClass]
    public class TestMatrixGame
    {
        #region Test ChangeDirection
        [TestMethod]
        public void TestChangeDirection()
        {
            Direction curretnDirection = new Direction();
            curretnDirection.X = 1;
            curretnDirection.Y = 0;
            Direction result = MatrixGame.ChangeDirection(curretnDirection);
            Direction nextDirection = new Direction();
            nextDirection.X = 1;
            nextDirection.Y = -1;
            Direction expected = nextDirection;
            Assert.AreEqual(expected.X, result.X);
            Assert.AreEqual(expected.Y, result.Y);
        }

        [TestMethod]
        public void TestChangeDirectionWithCurrentDirectionLast()
        {
            Direction curretnDirection = new Direction();
            curretnDirection.X = 0;
            curretnDirection.Y = 1;
            Direction result = MatrixGame.ChangeDirection(curretnDirection);
            Direction nextDirection = new Direction();
            nextDirection.X = 1;
            nextDirection.Y = 1;
            Direction expected = nextDirection;
            Assert.AreEqual(expected.X, result.X);
            Assert.AreEqual(expected.Y, result.Y);
        }
        #endregion

        #region Test CheckIfThereIsPossibleDirection
        [TestMethod]
        public void TestCheckIfThereIsPossibelDirectionWithAllPossibleDIrections()
        {
            int[,] matrix =
            { 
                {0,0,0},
                {0,1,0},
                {0,0,0}
            
            };
            MatrixCell currentCell = new MatrixCell();
            currentCell.X = 1;
            currentCell.Y = 1;
            bool result = MatrixGame.CheckIfThereIsPossibleDirection(matrix, currentCell);
            bool expected = true;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestCheckIfThereIsPossibelDirectionWithNoPossibleDirections()
        {
            int[,] matrix =
            { 
                {1,1,1},
                {1,1,1},
                {1,1,1}
            
            };
            MatrixCell currentCell = new MatrixCell();
            currentCell.X = 1;
            currentCell.Y = 1;
            bool result = MatrixGame.CheckIfThereIsPossibleDirection(matrix, currentCell);
            bool expected = false;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestCheckIfThereIsPossibelDirectionWithOnePossibleDirection()
        {
            int[,] matrix =
            { 
                {1,1,1},
                {1,1,1},
                {1,0,1}
            
            };
            MatrixCell currentCell = new MatrixCell();
            currentCell.X = 1;
            currentCell.Y = 1;
            bool result = MatrixGame.CheckIfThereIsPossibleDirection(matrix, currentCell);
            bool expected = true;
            Assert.AreEqual(expected, result);
        }

        #endregion

        #region Test GetNewCellOnRestart
        [TestMethod]
        public void TestGetNewCellOnRestartWithOnePossibleStart()
        {
            int[,] matrix =
            { 
                {1,1,1},
                {1,1,1},
                {1,0,1}
            
            };
            MatrixCell currentCell = new MatrixCell();
            currentCell.X = 1;
            currentCell.Y = 1;
            MatrixCell result = MatrixGame.GetNewCellOnRestart(matrix, currentCell);
            MatrixCell expected = new MatrixCell();
            expected.X = 2;
            expected.Y = 1;
            Assert.AreEqual(expected.X, result.X);
            Assert.AreEqual(expected.Y, result.Y);
        }

        [TestMethod]
        public void TestGetNewCellOnRestartWithTwoPossibleStarts()
        {
            int[,] matrix =
            { 
                {1,1,1},
                {0,1,1},
                {1,0,1}
            
            };
            MatrixCell currentCell = new MatrixCell();
            currentCell.X = 1;
            currentCell.Y = 1;
            MatrixCell result = MatrixGame.GetNewCellOnRestart(matrix, currentCell);
            MatrixCell expected = new MatrixCell();
            expected.X = 1;
            expected.Y = 0;
            Assert.AreEqual(expected.X, result.X);
            Assert.AreEqual(expected.Y, result.Y);
        }

        [TestMethod]
        public void TestGetNewCellOnRestartWithThreePossibleStarts()
        {
            int[,] matrix =
            { 
                {1,0,1},
                {0,1,1},
                {1,0,1}
            
            };
            MatrixCell currentCell = new MatrixCell();
            currentCell.X = 1;
            currentCell.Y = 1;
            MatrixCell result = MatrixGame.GetNewCellOnRestart(matrix, currentCell);
            MatrixCell expected = new MatrixCell();
            expected.X = 0;
            expected.Y = 1;
            Assert.AreEqual(expected.X, result.X);
            Assert.AreEqual(expected.Y, result.Y);
        }

        #endregion

        #region Test CheckIfOutsideTheMatrix
        [TestMethod]
        public void TestCheckIfOutsideTheMatrixTrue()
        {
            int matrixSize = 3;
            MatrixCell currentCell = new MatrixCell();
            currentCell.X = 0;
            currentCell.Y = 0;
            Direction direction = new Direction();
            direction.X = -1;
            direction.Y = 1;
            bool result = MatrixGame.CheckIfOutsideTheMatrix(matrixSize, currentCell, direction);
            bool expected = true;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestCheckIfOutsideTheMatrixFalse()
        {
            int matrixSize = 3;
            MatrixCell currentCell = new MatrixCell();
            currentCell.X = 1;
            currentCell.Y = 1;
            Direction direction = new Direction();
            direction.X = 1;
            direction.Y = 1;
            bool result = MatrixGame.CheckIfOutsideTheMatrix(matrixSize,currentCell,direction);
            bool expected = false;
            Assert.AreEqual(expected,result);
        }

        #endregion
    }
}
