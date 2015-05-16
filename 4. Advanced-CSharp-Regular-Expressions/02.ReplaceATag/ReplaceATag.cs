using System;
using System.Text.RegularExpressions;

namespace _02.ReplaceATag
{
    class ReplaceATag
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(<a href=)(.*(?=>))(>)(.*(?=<))(</a>)";
            string replace = @"[URL href=$2]$4[[/URL]";

            Console.WriteLine(Regex.Replace(input, pattern, replace));
        }
    }
}
