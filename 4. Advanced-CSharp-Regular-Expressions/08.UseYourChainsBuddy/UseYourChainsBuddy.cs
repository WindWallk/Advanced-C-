using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _08.UseYourChainsBuddy
{
    class UseYourChainsBuddy
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"<p>(.*?)<\/p>";
            Regex extract = new Regex(pattern);
            MatchCollection matches = extract.Matches(input);
            string text = String.Empty;

            foreach (Match match in matches)
            {
                text += match.Groups[1];
            }

            text = Regex.Replace(text, @"[^a-z0-9]", " ");
            text = Regex.Replace(text, @"\s+", " ");

            StringBuilder decryptedMessage = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] >= 'a' && text[i] < 'n')
                {
                    decryptedMessage.Append((char)(text[i] + 13));
                }
                else if (text[i] >= 'n' && text[i] <= 'z')
                {
                    decryptedMessage.Append((char) (text[i] - 13));
                }
                else
                {
                    decryptedMessage.Append((char)text[i]);
                }
            }

            Console.WriteLine(decryptedMessage.ToString());
        }
    }
}
