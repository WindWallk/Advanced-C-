using System;
using System.Text;

namespace _09.TerroristsWin_
{
    class TerroristsWin
    {
        static void Main(string[] args)
        {
            string bombText = Console.ReadLine();

            StringBuilder bombedText = new StringBuilder(bombText);

            int startIndex = bombText.IndexOf('|');
            int endIndex = 0;
            int bombedArea = 0;

            while (startIndex != -1)
            {
                int sum = 0;
                endIndex = bombText.IndexOf('|', startIndex + 1);
                if (startIndex >= endIndex)
                {
                    break;
                }

                for (int i = startIndex + 1; i <= endIndex - 1; i++)
                {
                    sum += bombText[i];
                    bombedText[i] = '.';
                }
                bombedArea = sum % 10;

                for (int i = startIndex; i >= startIndex - bombedArea; i--)
                {
                    bombedText[i] = '.';
                }
                for (int i = endIndex; i <= endIndex + bombedArea && i < bombedText.Length ; i++)
                {
                    bombedText[i] = '.';
                }

                startIndex = bombText.IndexOf('|', endIndex + 1);
            }

            Console.WriteLine(bombedText);
        }
    }
}
