using System;
using System.Text;

namespace _04.TextFilter
{
    class TextFilter
    {
        static void Main(string[] args)
        {
            string[] wordsToFilter = Console.ReadLine().Split(new string[] {", "}, StringSplitOptions.RemoveEmptyEntries);
            string textToFilter = Console.ReadLine();
            StringBuilder filteredText = new StringBuilder(textToFilter);

            foreach (var word in wordsToFilter)
            {
                string mask = new string('*', word.Length);
                filteredText.Replace(word, mask);
            }
            Console.WriteLine(filteredText.ToString());
        }
    }
}
