using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _06.ExtractHyperlinks
{
    class ExtractHyperlinks
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder lines = new StringBuilder();
            while (input != "END")
            {
                lines.Append(input);
                input = Console.ReadLine();
            }
            string allLineslines = lines.ToString();
            string pattern = @"<a\s+(?:[^>]+\s+)?href\s*=\s*(?:'([^']*)'|""([^""]*)""|([^\s>]+))[^>]*>";
            Regex hyperlinks = new Regex(pattern);
            MatchCollection hyperlinkMaches = hyperlinks.Matches(allLineslines);
            foreach (Match match in hyperlinkMaches)
            {
                for (int i = 1; i < 3; i++)
                {
                    if (match.Groups[i].Length > 0)
                    {
                        Console.WriteLine(match.Groups[i]);
                    }
                }
            }
        }
    }
}
