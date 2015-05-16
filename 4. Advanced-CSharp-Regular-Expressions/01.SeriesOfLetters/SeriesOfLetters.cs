using System;
using System.Text.RegularExpressions;

namespace _01.SeriesOfLetters
{
    class SeriesOfLetters
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            for (int i = 0; i < text.Length; i++)
            {
                string pattern = string.Format(@"{0}+", text[i]);
                string replace = string.Format(@"{0}", text[i]);

                Regex regex = new Regex(pattern);
                text = regex.Replace(text, replace);
            }
            Console.WriteLine(text);
        }
    }
}
