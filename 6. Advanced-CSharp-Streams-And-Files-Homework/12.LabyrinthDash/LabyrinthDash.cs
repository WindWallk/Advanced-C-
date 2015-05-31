using System;

namespace _12.LabyrinthDash
{
    class LabyrinthDash
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string obstacles = "@#*";

            char[][] labyrinth = new char[N][];

            for (int i = 0; i < N; i++)
            {
                labyrinth[i] = Console.ReadLine().ToCharArray();
            }

            int lives = 3;
            int movesMade = 0;
            int row = 0;
            int col = 0;

            string directions = Console.ReadLine();

            foreach (var direction in directions)
            {
                int previousRow = row;
                int previousCol = col;

                switch (direction)
                {
                    case '<': col--; break;
                    case '>': col++; break;
                    case 'v': row++; break;
                    case '^': row--; break;
                }

                if (!IsCellInsideLabyrinth(row, col, labyrinth) || labyrinth[row][col] == ' ')
                {
                    Console.WriteLine("Fell off a cliff! Game Over!");
                    movesMade++;
                    break;
                }
                else if (obstacles.Contains(labyrinth[row][col].ToString()))
                {
                    Console.WriteLine("Ouch! That hurt! Lives left: {0}", --lives);
                    movesMade++;

                    if (lives <= 0)
                    {
                        Console.WriteLine("No lives left! Game Over!");
                        break;
                    }
                }
                else if (labyrinth[row][col] == '_' || labyrinth[row][col] == '|')
                {
                    Console.WriteLine("Bumped a wall.");
                    row = previousRow;
                    col = previousCol;

                }
                else if (labyrinth[row][col] == '$')
                {
                    lives++;
                    movesMade++;
                    labyrinth[row][col] = '.';
                    Console.WriteLine("Awesome! Lives left: {0}", lives);
                }
                else
                {
                    movesMade++;
                    Console.WriteLine("Made a move!");
                }
            }

            Console.WriteLine("Total moves made: {0}", movesMade);
        }

        private static bool IsCellInsideLabyrinth(int row, int col, char[][] matrix)
        {
            bool isRowInsideMatrix = 0 <= row && row < matrix.Length;
            if (!isRowInsideMatrix)
            {
                return false;
            }

            return 0 <= col && col < matrix[row].Length;
        }
    }
}
