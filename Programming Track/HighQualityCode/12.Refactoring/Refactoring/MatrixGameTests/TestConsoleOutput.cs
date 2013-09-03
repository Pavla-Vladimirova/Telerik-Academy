using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Matrix;
using System.Text;

namespace MatrixGameTests
{
    [TestClass]
    public class TestConsoleOutput
    {
        [TestMethod]
        public void TestDrawMatrix()
        {
            var currentConsoleOut = Console.Out;

            int[,] matrix =
            {
                  {1,7,8},
                  {6,2,9},
                  {5,4,3},
                  {1,7,8},
                  {6,2,9},
                  {5,4,3},
            };

            StringBuilder expectedMatrix = new StringBuilder();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    expectedMatrix.AppendFormat("  {0}",matrix[i,j]);
                }
                expectedMatrix.AppendLine();
            }

            using (var consoleOutputResult = new ConsoleOutput())
            {
                MatrixGame.DrawMatrix(matrix);
                Assert.AreEqual(expectedMatrix.ToString(), consoleOutputResult.GetOuput());
            }

            Assert.AreEqual(currentConsoleOut, Console.Out);
        }

    }
}
