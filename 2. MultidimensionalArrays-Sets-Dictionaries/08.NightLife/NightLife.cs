using System;
using System.Collections.Generic;

namespace _08.NightLife
{
    class NightLife
    {
        static void Main(string[] args)
        {
            Dictionary<string, SortedDictionary<string, SortedSet<string>>> nightLife=
                new Dictionary<string, SortedDictionary<string, SortedSet<string>>>();

            string information = Console.ReadLine();

            while (information != "END")
            {
                string[] eventInfo = information.Split(new char[] {';'}, StringSplitOptions.RemoveEmptyEntries);

                string city = eventInfo[0];
                string place = eventInfo[1];
                string performer = eventInfo[2];

                if (!nightLife.ContainsKey(city))
                {
                    nightLife[city] = new SortedDictionary<string, SortedSet<string>>();
                }
                if (!nightLife[city].ContainsKey(place))
                {
                    nightLife[city][place] = new SortedSet<string>();
                }

                nightLife[city][place].Add(performer);
                information = Console.ReadLine();
            }

            foreach (KeyValuePair<string, SortedDictionary<string, SortedSet<string>>> pair in nightLife)
            {
                Console.WriteLine(pair.Key);
                foreach (KeyValuePair<string, SortedSet<string>> valuePair in pair.Value)
                {
                    Console.WriteLine("->{0}: {1}", valuePair.Key, string.Join(", ", valuePair.Value));
                }
            }
        }
    }
}
