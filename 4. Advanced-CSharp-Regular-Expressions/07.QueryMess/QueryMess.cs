using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _07.QueryMess
{
    class QueryMess
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(?:%20|\+)*([^?]*?)(?:%20|\+)*=(?:%20|\+)*(.*?)(?:%20|\+)*(?:&|$|\s)";
            Regex whiteSpace = new Regex(@"((%20|\+)+)");
            Regex extract = new Regex(pattern);
            while(input != "END")
            {
                MatchCollection matches = extract.Matches(input);
                Dictionary<string, List<string>> output = new Dictionary<string, List<string>>();
                foreach (Match match in matches)
                {
                    string key = whiteSpace.Replace(match.Groups[1].ToString().ToString(), " ").Trim();
                    string value = whiteSpace.Replace(match.Groups[2].ToString().ToString(), " ").Trim();

                    if (!output.ContainsKey(key))
                    {
                        output.Add(key, new List<string>());
                    }
                    output[key].Add(value);
                }

                foreach (var line in output)
                {
                    Console.Write(line.Key);
                    Console.Write("=[" + string.Join(", ", line.Value) + "]");
                }
                Console.WriteLine();
                input = Console.ReadLine();
            }
        }
    }
}
