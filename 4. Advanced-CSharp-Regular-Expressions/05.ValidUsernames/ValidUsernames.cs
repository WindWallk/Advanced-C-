using System;
using System.Text.RegularExpressions;

namespace _05.ValidUsernames
{
    class ValidUsernames
    {
        static void Main(string[] args)
        {
            string usernames = Console.ReadLine();
            string pattern = @"\b[a-zA-Z]\w{2,24}\b";
            Regex userRegex = new Regex(pattern);
            MatchCollection usernameCollection = userRegex.Matches(usernames);

            int firstIndex = 0;
            int secondIndex = 1;
            int bestSum = int.MinValue;

            for (int i = 0; i < usernameCollection.Count - 1; i++)
            {
                int sum = usernameCollection[i].Length + usernameCollection[i + 1].Length;
                if (sum > bestSum)
                {
                    bestSum = sum;
                    firstIndex = i;
                    secondIndex = i + 1;
                }
            }

            Console.WriteLine(usernameCollection[firstIndex].Groups[0]);
            Console.WriteLine(usernameCollection[secondIndex].Groups[0]);
        }
    }
}
