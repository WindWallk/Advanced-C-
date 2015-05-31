using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _03.WordCount
{
    class WordCount
    {
        static Dictionary<string, int> ReadDictionary()
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            using (var reader = new StreamReader(@"..\..\words.txt"))
            {
                do
                {
                    string[] words = reader.ReadLine().ToLower().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (var word in words)
                    {
                        dictionary.Add(word, 0);
                    }
                } while (!reader.EndOfStream);
            }

            return dictionary;
        }

        static void CountWordsInLine(string line, Dictionary<string, int> dictionary)
        {
            string[] input = line.ToLower().Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string key in input)
            {
                if (dictionary.ContainsKey(key))
                {
                    dictionary[key]++;
                }
            }
        }

        static void Main(string[] args)
        {
            var dictionary = ReadDictionary();
            using (var reader = new StreamReader(@"..\..\text.txt"))
            {
                while (!reader.EndOfStream)
                {
                    CountWordsInLine(reader.ReadLine(), dictionary);
                }
            }
            using (var writer = new StreamWriter(@"..\..\result.txt"))
            {
                foreach (var item in dictionary.OrderByDescending(key => key.Value))
                {
                    writer.WriteLine("{0} - {1}", item.Key, item.Value);
                }
            }
        }
    }
}
