using System;

namespace _05.UnicodeCharacters
{
    class UnicodeCharacters
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                Console.Write("\\u{0}", GetUnicodeLiteral(input[i]));
            }
            Console.WriteLine();
        }

        private static string GetUnicodeLiteral(char c)
        {
            return ((int)c).ToString("X4");
        }
    }
}
