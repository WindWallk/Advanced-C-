using System;
using System.Text.RegularExpressions;

namespace _09.SemanticHTML
{
    class SemanticHTML
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string patternOpenTag = @"(\s*)<div(.*?)(?:id|class)\s*=\s*""(\w+)""(.*?)>";
            string patternCloseTag = @"(\s*)<\/div>\s*<!--\s*(.*?)\s*-->";
            Regex openTag = new Regex(patternOpenTag);
            Regex closeTag = new Regex(patternCloseTag);

            while (line != "END")
            {
                Match html = openTag.Match(line);
                string output = ("<" + html.Groups[3] + html.Groups[2] + html.Groups[4]).TrimEnd() + ">";

                output = Regex.Replace(output, @"\s+", " ");

                if (output != "<>")
                {
                    Console.WriteLine(html.Groups[1] + output);
                }
                else
                {
                    html = closeTag.Match(line);

                    output = "</" + html.Groups[2] + ">";

                    if (output != "</>")
                    {
                        Console.WriteLine(html.Groups[1] + output);
                    }
                    else
                    {
                        Console.WriteLine(line);
                    }
                }
                
                line = Console.ReadLine();
            }
        }
    }
}
