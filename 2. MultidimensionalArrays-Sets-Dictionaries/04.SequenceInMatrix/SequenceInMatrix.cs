using System;

namespace _04.SequenceInMatrix
{
    class SequenceInMatrix
    {
        private static int rows;
        private static int cols;

        static void Main(string[] args)
        {
            rows = int.Parse(Console.ReadLine());
            cols = int.Parse(Console.ReadLine());

            string[,] matrix = new string[rows, cols];

            InputMatrix(matrix, rows, cols);

            int currentLength = 1;
            int bestSequenceLength = 1;
            string bestSequenceString = String.Empty;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    currentLength = CheckVerticalSequence(matrix, row, col, matrix[row,col]);
                    if (currentLength > bestSequenceLength)
                    {
                        bestSequenceLength = currentLength;
                        bestSequenceString = matrix[row, col];
                    }

                    currentLength = CheckHorizontalSequence(matrix, row, col, matrix[row, col]);
                    if (currentLength > bestSequenceLength)
                    {
                        bestSequenceLength = currentLength;
                        bestSequenceString = matrix[row, col];
                    }

                    currentLength = CheckDiagonalSequence(matrix, row, col, matrix[row, col]);
                    if (currentLength > bestSequenceLength)
                    {
                        bestSequenceLength = currentLength;
                        bestSequenceString = matrix[row, col];
                    }
                }
            }

            Console.Write(bestSequenceString);
            for (int i = 1; i < bestSequenceLength; i++)
            {
                Console.Write(", {0}", bestSequenceString);
            }
            Console.WriteLine();
        }

        private static int CheckDiagonalSequence(string[,] matrix, int row, int col, string valueToCheck)
        {
            int length = 1;
            for (int i = 0, j = 0; i < rows - 1 && j < cols - 1; i++, j++)
            {
                if (matrix[i + 1, j + 1].Equals(valueToCheck))
                {
                    length++;
                }
                else
                {
                    break;
                }
            }

            return length;
        }

        private static int CheckHorizontalSequence(string[,] matrix, int row, int col, string valueToCheck)
        {
            int length = 1;

            for (int i = 0; i < cols - 1; i++)
            {
                if (matrix[row, i + 1].Equals(valueToCheck))
                {
                    length ++;
                }
                else
                {
                    break;
                }
            }

            return length;
        }

        private static int CheckVerticalSequence(string[,] matrix, int row, int col, string valueToCheck)
        {
            int length = 1;

            for (int i = 0; i < rows - 1; i++)
            {
                if (matrix[i + 1, col].Equals(valueToCheck))
                {
                    length++;
                }
                else
                {
                    break;
                }
            }

            return length;
        }

        private static void InputMatrix(string[,] matrix, int rows, int cols)
        {
            for (int row = 0; row < rows; row++)
            {
                string[] input = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = input[col];
                }
            }
        }
    }
}
