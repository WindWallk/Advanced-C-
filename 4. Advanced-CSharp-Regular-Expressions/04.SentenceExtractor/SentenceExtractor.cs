using System;
using System.Text.RegularExpressions;

namespace _04.SentenceExtractor
{
    class SentenceExtractor
    {
        static void Main(string[] args)
        {
            string keyword = Console.ReadLine();
            string text = Console.ReadLine();
            string pattern = string.Format(@"(?<=\s|^)(.*?\b{0}\b.*?(?=\!|\.|\?)[?.!])", keyword);
            Regex regexKey = new Regex(pattern);
            MatchCollection sentences = regexKey.Matches(text);
            foreach (Match sentence in sentences)
            {
                Console.WriteLine(sentence.Groups[0]);
            }
        }
    }
}
