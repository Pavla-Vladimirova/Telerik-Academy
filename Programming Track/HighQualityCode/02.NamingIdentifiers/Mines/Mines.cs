using System;
using System.Collections.Generic;
using System.Linq;

namespace MinesGame
{
    public class Mines
    {
        private const int GAME_FIELD_ROWS = 5;
        private const int GAME_FIELD_COLS = 10;

        public class User
        {
            private string name;
            private int gainedPoints;

            public User()
            {
            }

            public User(string userName, int points)
            {
                this.Name = userName;
                this.GainedPoints = points;
            }

            public string Name
            {
                get { return this.name; }
                set { this.name = value; }
            }

            public int GainedPoints
            {
                get { return this.gainedPoints; }
                set { this.gainedPoints = value; }
            }
        }

        static void Main(string[] arguments)
        {
            string currentCommand = string.Empty;
            char[,] gameField = CreateGameField();
            char[,] gameFieldWithMines = LoadMines();
            int userPoints = 0;
            bool isDestroyed = false;
            List<User> topScoringUsers = new List<User>(6);
            int row = 0;
            int col = 0;
            bool gameOver = true;
            const int MAX_POINTS = 35;
            bool hasMaxPoints = false;

            do
            {
                if (gameOver)
                {
                    Console.WriteLine("Let's play “Mines”. Try to open cells without hitting the mines." +
                    "Command name: 'usersRatings' shows the top scoring users' rating, 'restart' begin new game, 'exit' exit the game!");
                    DrawGameField(gameField);
                    gameOver = false;
                }

                Console.Write("Write row and column : ");
                currentCommand = Console.ReadLine().Trim();
                if (currentCommand.Length >= 3)
                {
                    if (int.TryParse(currentCommand[0].ToString(), out row) &&
                        int.TryParse(currentCommand[2].ToString(), out col) &&
                        row <= gameField.GetLength(0) && col <= gameField.GetLength(1))
                    {
                        currentCommand = "turn";
                    }
                }

                switch (currentCommand)
                {
                    case "usersRatings":
                        ShowTopUsersRating(topScoringUsers);
                        break;
                    case "restart":
                        gameField = CreateGameField();
                        gameFieldWithMines = LoadMines();
                        DrawGameField(gameField);
                        isDestroyed = false;
                        gameOver = false;
                        break;
                    case "exit":
                        Console.WriteLine("Bye, bye, bye!");
                        break;
                    case "turn":
                        if (gameFieldWithMines[row, col] != '*')
                        {
                            if (gameFieldWithMines[row, col] == '-')
                            {
                                MakeUserTurn(gameField, gameFieldWithMines, row, col);
                                userPoints++;
                            }

                            if (MAX_POINTS == userPoints)
                            {
                                hasMaxPoints = true;
                            }
                            else
                            {
                                DrawGameField(gameField);
                            }
                        }
                        else
                        {
                            isDestroyed = true;
                        }

                        break;
                    default:
                        Console.WriteLine("\nError! Invalid Command Name\n");
                        break;
                }

                if (isDestroyed)
                {
                    DrawGameField(gameFieldWithMines);
                    Console.Write("\nGame Over! You have finished with {0} points. " + "Please,write your name: ", userPoints);
                    string userNickName = Console.ReadLine();
                    User currentUser = new User(userNickName, userPoints);

                    if (topScoringUsers.Count < 5)
                    {
                        topScoringUsers.Add(currentUser);
                    }
                    else
                    {
                        for (int i = 0; i < topScoringUsers.Count; i++)
                        {
                            if (topScoringUsers[i].GainedPoints < currentUser.GainedPoints)
                            {
                                topScoringUsers.Insert(i, currentUser);
                                topScoringUsers.RemoveAt(topScoringUsers.Count - 1);
                                break;
                            }
                        }
                    }

                    topScoringUsers.Sort((User user1, User user2) => user2.Name.CompareTo(user1.Name));
                    topScoringUsers.Sort((User user1, User user2) => user2.GainedPoints.CompareTo(user1.GainedPoints));
                    ShowTopUsersRating(topScoringUsers);

                    gameField = CreateGameField();
                    gameFieldWithMines = LoadMines();
                    userPoints = 0;
                    isDestroyed = false;
                    gameOver = true;
                }

                if (hasMaxPoints)
                {
                    Console.WriteLine("\nCongratulations! You've opened 35 cells without hitting any mines.");
                    DrawGameField(gameFieldWithMines);
                    Console.WriteLine("Please write your name: ");
                    string currentUserName = Console.ReadLine();
                    User currentUser = new User(currentUserName, userPoints);
                    topScoringUsers.Add(currentUser);
                    ShowTopUsersRating(topScoringUsers);
                    gameField = CreateGameField();
                    gameFieldWithMines = LoadMines();
                    userPoints = 0;
                    hasMaxPoints = false;
                    gameOver = true;
                }
            } while (currentCommand != "exit");

            Console.WriteLine("Made in Bulgaria");
            Console.Read();
        }

        private static void ShowTopUsersRating(List<User> topScoringUsersList)
        {
            Console.WriteLine("\nGained Points:");
            if (topScoringUsersList.Count > 0)
            {
                for (int i = 0; i < topScoringUsersList.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} points", i + 1, topScoringUsersList[i].Name, topScoringUsersList[i].GainedPoints);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Empty Rating(No user has saved their's scores yet)!\n");
            }
        }

        private static void MakeUserTurn(char[,] gameField, char[,] gameFieldWithMines, int row, int col)
        {
            char minesCounter = CountMines(gameFieldWithMines, row, col);
            gameFieldWithMines[row, col] = minesCounter;
            gameField[row, col] = minesCounter;
        }

        private static void DrawGameField(char[,] gameField)
        {
            int numberOfRows = GAME_FIELD_ROWS;
            int numberOfCols = GAME_FIELD_COLS;
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < numberOfRows; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < numberOfCols; j++)
                {
                    Console.Write(string.Format("{0} ", gameField[i, j]));
                }
                Console.Write("|");
                Console.WriteLine();
            }
            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreateGameField()
        {
            int numberOfRows = GAME_FIELD_ROWS;
            int numberOfCols = GAME_FIELD_COLS;
            char[,] gameField = new char[numberOfRows, numberOfCols];
            for (int row = 0; row < numberOfRows; row++)
            {
                for (int col = 0; col < numberOfCols; col++)
                {
                    gameField[row, col] = '?';
                }
            }

            return gameField;
        }

        private static char[,] LoadMines()
        {
            int numberOfRows = GAME_FIELD_ROWS;
            int numberOfCols = GAME_FIELD_COLS;
            char[,] gameField = new char[numberOfRows, numberOfCols];

            for (int row = 0; row < numberOfRows; row++)
            {
                for (int col = 0; col < numberOfCols; col++)
                {
                    gameField[row, col] = '-';
                }
            }

            List<int> minesList = new List<int>();
            while (minesList.Count < 15)
            {
                Random randomNumber = new Random();
                int randomNumberOfMines = randomNumber.Next(50);
                if (!minesList.Contains(randomNumberOfMines))
                {
                    minesList.Add(randomNumberOfMines);
                }
            }

            foreach (int mine in minesList)
            {
                int row = mine % numberOfCols;
                int col = mine / numberOfCols;
                
                if (row == 0 && mine != 0)
                {
                    col--;
                    row = numberOfCols;
                }
                else
                {
                    row++;
                }

                gameField[col, row - 1] = '*';
            }

            return gameField;
        }

        private static char CountMines(char[,] gameField, int row, int col)
        {
            int minesCounter = 0;
            int numberOfRows = GAME_FIELD_ROWS;
            int numberOfCols = GAME_FIELD_COLS;

            if (row - 1 >= 0)
            {
                if (gameField[row - 1, col] == '*')
                { 
                    minesCounter++; 
                }
            }

            if (row + 1 < numberOfRows)
            {
                if (gameField[row + 1, col] == '*')
                { 
                    minesCounter++; 
                }
            }

            if (col - 1 >= 0)
            {
                if (gameField[row, col - 1] == '*')
                { 
                    minesCounter++;
                }
            }

            if (col + 1 < numberOfCols)
            {
                if (gameField[row, col + 1] == '*')
                { 
                    minesCounter++;
                }
            }

            if ((row - 1 >= 0) && (col - 1 >= 0))
            {
                if (gameField[row - 1, col - 1] == '*')
                { 
                    minesCounter++; 
                }
            }

            if ((row - 1 >= 0) && (col + 1 < numberOfCols))
            {
                if (gameField[row - 1, col + 1] == '*')
                { 
                    minesCounter++; 
                }
            }

            if ((row + 1 < numberOfRows) && (col - 1 >= 0))
            {
                if (gameField[row + 1, col - 1] == '*')
                { 
                    minesCounter++; 
                }
            }

            if ((row + 1 < numberOfRows) && (col + 1 < numberOfCols))
            {
                if (gameField[row + 1, col + 1] == '*')
                { 
                    minesCounter++; 
                }
            }

            return char.Parse(minesCounter.ToString());
        }
    }
}
