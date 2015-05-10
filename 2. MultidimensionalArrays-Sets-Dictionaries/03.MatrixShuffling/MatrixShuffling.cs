using System;
using System.ComponentModel;
using System.ComponentModel.Design;

namespace _03.MatrixShuffling
{
    class MatrixShuffling
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            string [,] matrix = new string[rows, cols];

            Input(matrix, rows, cols);

            string command = Console.ReadLine();

            while (command != "END")
            {
                TrySwap(command, matrix, rows, cols);

                command = Console.ReadLine();
            }
        }

        private static void TrySwap(string command, string[,] matrix, int rows, int cols)
        {
            string temp;
            int x1;
            int y1;
            int x2;
            int y2;

            string[] commands = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (commands.Length == 5 && commands[0] == "swap")
            {
                x1 = int.Parse(commands[1]);
                y1 = int.Parse(commands[2]);
                x2 = int.Parse(commands[3]);
                y2 = int.Parse(commands[4]);

                if (x1 >= 0 && x1 <= rows && x2 >= 0 && x2 <= rows
                    && y1 >= 0 && y1 <= cols && y2 >= 0 && y2 <= cols)
                {
                    temp = matrix[x1, y1];
                    matrix[x1, y1] = matrix[x2, y2];
                    matrix[x2, y2] = temp;

                    for (int row = 0; row < rows; row++)
                    {
                        for (int col = 0; col < cols; col++)
                        {
                            Console.Write("{0,2} ", matrix[row, col]);
                        }
                        Console.WriteLine();
                    }

                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
        }

        private static void Input(string[,] matrix, int rows, int cols)
        {
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = Console.ReadLine();
                }
            }
        }
    }
}
