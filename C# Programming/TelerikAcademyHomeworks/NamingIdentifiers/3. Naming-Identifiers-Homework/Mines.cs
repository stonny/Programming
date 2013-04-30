using System;
using System.Collections.Generic;
using System.Linq;

namespace Minesweeper
{
    public class Mines
    {
        public static void Main(string[] аргументи)
        {
            string command = string.Empty;
            char[,] playField = CreatePlayField();
            char[,] bombField = SetBombPosition();
            int counter = 0;
            bool isPlayerDead = false;
            List<Points> topPlayers = new List<Points>(6);
            int row = 0;
            int col = 0;
            bool isNewGameStarted = true;
            const int MaxPoints = 35;
            bool isMaxPointsReached = false;

            do
            {
                if (isNewGameStarted)
                {
                    Console.WriteLine("Lets play Minesweeper. Try your luck and find the fields without mines." +
                    " Command:\r\n 'top' shows the ranking\r\n 'restart' starts a new game \r\n 'exit' to quit the game");
                    DrawPlayField(playField);
                    isNewGameStarted = false;
                }

                Console.Write("Enter row and col or execute a command: ");
                command = Console.ReadLine().Trim();
                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                    int.TryParse(command[2].ToString(), out col) &&
                        row <= playField.GetLength(0) && col <= playField.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        Ranking(topPlayers);
                        break;
                    case "restart":
                        playField = CreatePlayField();
                        bombField = SetBombPosition();
                        DrawPlayField(playField);
                        isPlayerDead = false;
                        isNewGameStarted = false;
                        break;
                    case "exit":
                        Console.WriteLine("Bye!");
                        break;
                    case "turn":
                        if (bombField[row, col] != '*')
                        {
                            if (bombField[row, col] == '-')
                            {
                                NextMove(playField, bombField, row, col);
                                counter++;
                            }

                            if (MaxPoints == counter)
                            {
                                isMaxPointsReached = true;
                            }
                            else
                            {
                                DrawPlayField(playField);
                            }
                        }
                        else
                        {
                            isPlayerDead = true;
                        }

                        break;
                    default:
                        Console.WriteLine("\nError! Invalid Command !\n");
                        break;
                }

                if (isPlayerDead)
                {
                    DrawPlayField(bombField);
                    Console.Write("\nYou died like a hero with : {0} points. ");
                    Console.Write("Please enter your nickname: ", counter);
                    string currentPlayerNickname = Console.ReadLine();
                    Points currentPlayerPoints = new Points(currentPlayerNickname, counter);
                    if (topPlayers.Count < 5)
                    {
                        topPlayers.Add(currentPlayerPoints);
                    }
                    else
                    {
                        for (int i = 0; i < topPlayers.Count; i++)
                        {
                            if (topPlayers[i].PlayerPoints < currentPlayerPoints.PlayerPoints)
                            {
                                topPlayers.Insert(i, currentPlayerPoints);
                                topPlayers.RemoveAt(topPlayers.Count - 1);
                                break;
                            }
                        }
                    }

                    topPlayers.Sort((Points firstPlayer, Points secondPlayer)
                        => secondPlayer.PlayerName.CompareTo(firstPlayer.PlayerName));
                    topPlayers.Sort((Points firstPlayer, Points secondPlayer)
                        => secondPlayer.PlayerPoints.CompareTo(firstPlayer.PlayerPoints));
                    Ranking(topPlayers);

                    playField = CreatePlayField();
                    bombField = SetBombPosition();
                    counter = 0;
                    isPlayerDead = false;
                    isNewGameStarted = true;
                }

                if (isMaxPointsReached)
                {
                    Console.WriteLine("\nCongratulations! You opened 35 cells without loosing a drop of blood !");
                    DrawPlayField(bombField);
                    Console.WriteLine("Please enter your nickname: ");
                    string currentPlayerNickname = Console.ReadLine();
                    Points currentPlayerPoints = new Points(currentPlayerNickname, counter);
                    topPlayers.Add(currentPlayerPoints);
                    Ranking(topPlayers);
                    playField = CreatePlayField();
                    bombField = SetBombPosition();
                    counter = 0;
                    isMaxPointsReached = false;
                    isNewGameStarted = true;
                }
            }
            while (command != "exit");
            Console.WriteLine("This game was made in Bulgaria.");
            Console.WriteLine("Bye !");
            Console.Read();
        }

        private static void Ranking(List<Points> currentPlayerPoints)
        {
            Console.WriteLine("\nPoints:");
            if (currentPlayerPoints.Count > 0)
            {
                for (int i = 0; i < currentPlayerPoints.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} Cells",
                        i + 1,
                        currentPlayerPoints[i].PlayerName,
                        currentPlayerPoints[i].PlayerPoints);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Empty Ranking!\n");
            }
        }

        private static void NextMove(char[,] playField, char[,] bombField, int row, int col)
        {
            char bombCounter = GetSurroundingBombCount(bombField, row, col);
            bombField[row, col] = bombCounter;
            playField[row, col] = bombCounter;
        }

        private static void DrawPlayField(char[,] playField)
        {
            int fieldRows = playField.GetLength(0);
            int fieldCols = playField.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < fieldRows; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < fieldCols; j++)
                {
                    Console.Write(string.Format("{0} ", playField[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreatePlayField()
        {
            int fieldRows = 5;
            int fieldCols = 10;
            char[,] playField = new char[fieldRows, fieldCols];
            for (int i = 0; i < fieldRows; i++)
            {
                for (int j = 0; j < fieldCols; j++)
                {
                    playField[i, j] = '?';
                }
            }

            return playField;
        }

        private static char[,] SetBombPosition()
        {
            int rows = 5;
            int cols = 10;
            char[,] playField = new char[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    playField[i, j] = '-';
                }
            }

            List<int> bombMap = new List<int>();
            while (bombMap.Count < 15)
            {
                Random randomGenerator = new Random();
                int asfd = randomGenerator.Next(50);
                if (!bombMap.Contains(asfd))
                {
                    bombMap.Add(asfd);
                }
            }

            foreach (int bombPosition in bombMap)
            {
                int col = (bombPosition / cols);
                int row = (bombPosition % cols);
                if (row == 0 && bombPosition != 0)
                {
                    col--;
                    row = cols;
                }
                else
                {
                    row++;
                }

                playField[col, row - 1] = '*';
            }

            return playField;
        }

        private static char GetSurroundingBombCount(char[,] playField, int row, int col)
        {
            int bombCounter = 0;
            int rows = playField.GetLength(0);
            int cols = playField.GetLength(1);

            if (row - 1 >= 0)
            {
                if (playField[row - 1, col] == '*')
                {
                    bombCounter++;
                }
            }

            if (row + 1 < rows)
            {
                if (playField[row + 1, col] == '*')
                {
                    bombCounter++;
                }
            }

            if (col - 1 >= 0)
            {
                if (playField[row, col - 1] == '*')
                {
                    bombCounter++;
                }
            }

            if (col + 1 < cols)
            {
                if (playField[row, col + 1] == '*')
                {
                    bombCounter++;
                }
            }

            if ((row - 1 >= 0) && (col - 1 >= 0))
            {
                if (playField[row - 1, col - 1] == '*')
                {
                    bombCounter++;
                }
            }

            if ((row - 1 >= 0) && (col + 1 < cols))
            {
                if (playField[row - 1, col + 1] == '*')
                {
                    bombCounter++;
                }
            }

            if ((row + 1 < rows) && (col - 1 >= 0))
            {
                if (playField[row + 1, col - 1] == '*')
                {
                    bombCounter++;
                }
            }

            if ((row + 1 < rows) && (col + 1 < cols))
            {
                if (playField[row + 1, col + 1] == '*')
                {
                    bombCounter++;
                }
            }

            return char.Parse(bombCounter.ToString());
        }
    }
}
