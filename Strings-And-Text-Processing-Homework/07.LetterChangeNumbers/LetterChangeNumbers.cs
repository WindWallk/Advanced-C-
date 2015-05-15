using System;
using System.Text;

namespace _07.LetterChangeNumbers
{
    class LetterChangeNumbers
    {
        static void Main(string[] args)
        {
            string[] sequences = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            double sum = 0;

            for (int i = 0; i < sequences.Length; i++)
            {
                double result;
                char firstLetter = sequences[i][0];
                double num = GetNumberBetweenLetters(sequences[i]);
                if (firstLetter >= 'A' && firstLetter <= 'Z')
                {
                    result = num/(firstLetter - 'A' + 1);
                }
                else
                {
                    result = num*(firstLetter - 'a' + 1);
                }
                char lastLetter = sequences[i][sequences[i].Length - 1];
                if (lastLetter >= 'A' && lastLetter <= 'Z')
                {
                    result -= lastLetter - 'A' + 1;
                }
                else
                {
                    result += lastLetter - 'a' + 1;
                }

                sum += result;
            }

            Console.WriteLine("{0:f2}", sum);
        }

        private static double GetNumberBetweenLetters(string sequence)
        {
            StringBuilder number = new StringBuilder();
            for (int i = 1; i < sequence.Length - 1; i++)
            {
                number.Append(sequence[i]);
            }

            return double.Parse((number.ToString()));
        }
    }
}
