using System;
using System.Security.Claims;

namespace _05.CollectTheCoins
{
    class CollectTheCoins
    {
        static void Main(string[] args)
        {
            char[][] board = new char[4][];

            Input(board, 4);

            int currentRow = 0;
            int currentCol = 0;
            int coinsHit = 0;
            int wallsHit = 0;
            string movement = Console.ReadLine();

            foreach (char direction in movement)
            {
                if (direction == 'V')
                {
                    currentRow ++;
                    if (currentRow >= 4)
                    {
                        currentRow--;
                        wallsHit++;
                        continue;
                    }
                    else if (currentCol >= board[currentRow].Length)
                    {
                        currentRow--;
                        wallsHit++;
                        continue;
                    }
                }
                else if (direction == '^')
                {
                    currentRow--;
                    if (currentRow < 0)
                    {
                        currentRow++;
                        wallsHit++;
                        continue;
                    }
                    else if (currentCol >= board[currentRow].Length)
                    {
                        currentRow++;
                        wallsHit++;
                        continue;
                    }
                }
                else if (direction == '<')
                {
                    currentCol--;
                    if (currentCol < 0)
                    {
                        currentCol++;
                        wallsHit++;
                        continue;
                    }
                }
                else if (direction == '>')
                {
                    currentCol++;
                    if (currentCol >= board[currentRow].Length)
                    {
                        currentCol--;
                        wallsHit++;
                        continue;
                    }
                }

                if (board[currentRow][currentCol].Equals('$'))
                {
                    coinsHit++;
                }
            }

            Console.WriteLine("Coins collected: {0}", coinsHit);
            Console.WriteLine("Walls hit: {0}", wallsHit);
        }

        private static void Input(char[][] board, int rows)
        {
            for (int row = 0; row < rows; row++)
            {
                string input = Console.ReadLine();
                board[row] = new char[input.Length];

                for (int col = 0; col < input.Length; col++)
                {
                    board[row][col] = input[col];
                }
            }
        }
    }
}