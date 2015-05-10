using System;
using System.Collections.Generic;

namespace _06.CountSymbols
{
    class CountSymbols
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            SortedDictionary<char, int> symbolsCount = new SortedDictionary<char, int>();

            foreach (char symbol in text)
            {
                if (symbolsCount.ContainsKey(symbol))
                {
                    symbolsCount[symbol]++;
                }
                else
                {
                    symbolsCount.Add(symbol, 1);
                }
            }

            foreach (KeyValuePair<char, int> pair in symbolsCount)
            {
                Console.WriteLine("{0}: {1} time/s", pair.Key, pair.Value);
            }
        }
    }
}
