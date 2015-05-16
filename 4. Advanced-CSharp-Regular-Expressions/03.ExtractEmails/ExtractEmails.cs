using System;
using System.Text.RegularExpressions;

namespace _03.ExtractEmails
{
    class ExtractEmails
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(?<=\s|^)[a-z0-9]+[_.-]?[a-z0-9]*@[a-z]+\-?[a-z]+(\.[a-z]+)+\b";
            Regex regexMail = new Regex(pattern);
            MatchCollection matches = regexMail.Matches(input);
            Console.WriteLine("Matches:{0}", matches.Count);
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Groups[0]);
            }
        }
    }
}

