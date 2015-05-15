using System;
using System.Collections.Generic;

namespace _06.Palindromes
{
    class Palindromes
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(new char[] {' ', '.', ',', '!', '?'}, StringSplitOptions.RemoveEmptyEntries);
            SortedSet<string> palindromes = new SortedSet<string>();

            for (int i = 0; i < words.Length; i++)
            {
                string reversed = Reverse(words[i]);

                if (words[i] == reversed)
                {
                    palindromes.Add(words[i]);
                }
            }

            Console.WriteLine(string.Join(", ", palindromes));
        }

        static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}