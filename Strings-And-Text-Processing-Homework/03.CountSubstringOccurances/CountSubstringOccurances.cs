using System;

namespace _03.CountSubstringOccurances
{
    class CountSubstringOccurances
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string substring = Console.ReadLine();
            int occurances = 0;
            int startIndex = 0;

            while (input.IndexOf(substring, startIndex, StringComparison.OrdinalIgnoreCase) >= 0)
            {
                occurances++;
                startIndex = input.IndexOf(substring, startIndex, StringComparison.OrdinalIgnoreCase) + 1;
            }

            Console.WriteLine(occurances);
        }
    }
}
