using System;

namespace _01.FillTheMatrix
{
    class FillTheMatrix
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            int[,] matrix = new int[n, n];

            Console.WriteLine("PaternA:");
            PaternA(matrix, n);
            Console.WriteLine("PaternB:");
            PaternB(matrix, n);
        }

        private static void PaternA(int[,] matrix, int n)
        {
            int number = 1;
            for (int col = 0; col < n; col++)
            {
                for (int row = 0; row < n; row++)
                {
                    matrix[row, col] = number;
                    number ++;
                }
            }
            PrintMatrix(matrix, n);
        }

        private static void PrintMatrix(int[,] matrix, int n)
        {
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write("{0,2} ", matrix[row, col]);
                }
                Console.WriteLine();
            }
        }

        private static void PaternB(int[,] matrix, int n)
        {
            int number = 1;
            for (int col = 0; col < n; col++)
            {
                if (col%2 == 0)
                {
                    for (int row = 0; row < n; row++)
                    {
                        matrix[row, col] = number;
                        number++;
                    }
                }
                else
                {
                    for (int row = n - 1; row >= 0; row--)
                    {
                        matrix[row, col] = number;
                        number++;
                    }
                }
            }

            PrintMatrix(matrix, n);
        }
    }
}
