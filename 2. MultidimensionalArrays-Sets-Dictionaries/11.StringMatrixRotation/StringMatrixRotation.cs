using System;
using System.Collections.Generic;

namespace _11.StringMatrixRotation
{
    class StringMatrixRotation
    {
        static void Main(string[] args)
        {
            string[] rotation = Console.ReadLine().Split(new char[] {'(', ')'}, StringSplitOptions.RemoveEmptyEntries);
            int degrees = int.Parse(rotation[1]) % 360;

            int maxRowLength = 0;

            Queue<string> matrixElements = new Queue<string>();
            string element = Console.ReadLine();

            while (!string.IsNullOrEmpty(element))
            {
                matrixElements.Enqueue(element);
                if (element.Length > maxRowLength)
                {
                    maxRowLength = element.Length;
                }

                element = Console.ReadLine();
            }

            char[,] matrix = new char[matrixElements.Count, maxRowLength];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string elementToAdd = matrixElements.Dequeue().PadRight(maxRowLength, ' ');
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = elementToAdd[col];
                }
            }


            if (degrees == 90)
            {
                char[,] rotatedMatrix = new char[matrix.GetLength(1), matrix.GetLength(0)];
                StringMatrixRotation90(matrix, rotatedMatrix);
                PrintMatrix(rotatedMatrix);
            }
            else if (degrees == 180)
            {
                char[,] rotatedMatrix = new char[matrix.GetLength(0), matrix.GetLength(1)];
                StringMatrixRotation180(matrix, rotatedMatrix);
                PrintMatrix(rotatedMatrix);
            }
            else if (degrees == 270)
            {
                char[,] rotatedMatrix = new char[matrix.GetLength(1), matrix.GetLength(0)];
                StringMatrixRotation270(matrix, rotatedMatrix);
                PrintMatrix(rotatedMatrix);
            }
            else if (degrees == 0)
            {
                PrintMatrix(matrix);
            }
        }

        private static void StringMatrixRotation270(char[,] matrix, char[,] rotatedMatrix)
        {
            for (int row = 0; row < rotatedMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < rotatedMatrix.GetLength(1); col++)
                {
                    rotatedMatrix[row, col] = matrix[col, matrix.GetLength(1) - row - 1];
                }
            }
        }

        private static void StringMatrixRotation180(char[,] matrix, char[,] rotatedMatrix)
        {
            for (int row = 0; row < rotatedMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < rotatedMatrix.GetLength(1); col++)
                {
                    rotatedMatrix[row, col] = matrix[matrix.GetLength(0) - row - 1, matrix.GetLength(1) - col - 1];
                }
            }
        }

        private static void StringMatrixRotation90(char[,] matrix, char[,] rotatedMatrix)
        {
            for (int row = 0; row < rotatedMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < rotatedMatrix.GetLength(1); col++)
                {
                    rotatedMatrix[row, col] = matrix[matrix.GetLength(0) - col - 1, row];
                }
            }
        }

        private static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
