using System;
using System.Linq;

namespace _02.MaximumSum
{
    class MaximumSum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input rows:");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Input cols:");
            int cols = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] rowNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowNumbers[col];
                }
            }

            GetBestSum(matrix, rows, cols);        
        }

        static void GetBestSum(int[,] matrix, int rows, int cols)
        {
            int bestSum = int.MinValue;
            int sum = 0;
            int startRowBestSum = 0;
            int startColBestSum = 0;

            for (int row = 0; row < rows - 2; row++)
            {
                for (int col = 0; col < cols - 2; col++)
                {
                    sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                          matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                          matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                    if (sum > bestSum)
                    {
                        bestSum = sum;
                        startRowBestSum = row;
                        startColBestSum = col;
                    }
                }
            }

            Console.WriteLine("Sum = {0}",bestSum);

            for (int row = startRowBestSum; row < startRowBestSum + 3; row++)
            {
                for (int col = startColBestSum; col < startColBestSum + 3; col++)
                {
                    Console.Write("{0, 2} ", matrix[row, col]);
                }
                Console.WriteLine();
            }

        }

    }
}