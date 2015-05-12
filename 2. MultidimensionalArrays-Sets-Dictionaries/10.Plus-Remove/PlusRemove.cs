using System;
using System.Collections.Generic;

namespace _10.Plus_Remove
{
    class PlusRemove
    {
        static void Main(string[] args)
        {
            List<List<char>> charMatrix = new List<List<char>>();

            string input = Console.ReadLine();
            int row = 0;

            while (input != "END")
            {
                charMatrix.Add(new List<char>(input.Length));
                for (int col = 0; col < input.Length; col++)
                {
                    charMatrix[row].Add(input[col]);
                }

                row++;
                input = Console.ReadLine();
            }

            HashSet<KeyValuePair<int, int>> plusCordinates = new HashSet<KeyValuePair<int, int>>();

            for (row = 1; row < charMatrix.Count - 1; row++)
            {
                for (int col = 1; col < charMatrix[row].Count - 1; col++)
                {
                    char currentChar = char.ToUpper(charMatrix[row][col]);
                    if (currentChar.Equals(char.ToUpper(charMatrix[row - 1][col])) &&
                        currentChar.Equals(char.ToUpper(charMatrix[row][col - 1])) &&
                        currentChar.Equals(char.ToUpper(charMatrix[row + 1][col])) &&
                        currentChar.Equals(char.ToUpper(charMatrix[row][col + 1])))
                    {
                        plusCordinates.Add(new KeyValuePair<int, int>(row, col));
                        plusCordinates.Add(new KeyValuePair<int, int>(row - 1, col));
                        plusCordinates.Add(new KeyValuePair<int, int>(row, col - 1));
                        plusCordinates.Add(new KeyValuePair<int, int>(row + 1, col));
                        plusCordinates.Add(new KeyValuePair<int, int>(row, col + 1));
                    }
                }
            }

            for (row = 0; row < charMatrix.Count; row++)
            {
                for (int col = 0; col < charMatrix[row].Count; col++)
                {
                    KeyValuePair<int, int> currentCoordinates = new KeyValuePair<int, int>(row, col);
                    if (!plusCordinates.Contains(currentCoordinates))
                    {
                        Console.Write(charMatrix[row][col]);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
