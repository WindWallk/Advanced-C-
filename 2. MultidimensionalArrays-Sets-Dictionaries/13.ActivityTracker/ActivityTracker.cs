using System;
using System.Collections.Generic;

namespace _13.ActivityTracker
{
    class ActivityTracker
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SortedDictionary<int, SortedDictionary<string, int>> activityTracker = new SortedDictionary<int, SortedDictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(new char[] {'/', ' '}, StringSplitOptions.RemoveEmptyEntries);
                int month = int.Parse(input[1]);
                string name = input[3];
                int distance = int.Parse(input[4]);

                if (!activityTracker.ContainsKey(month))
                {
                    activityTracker[month] = new SortedDictionary<string, int>();
                }
                if (!activityTracker[month].ContainsKey(name))
                {
                    activityTracker[month][name] = distance;
                }
                else
                {
                    activityTracker[month][name] += distance;
                }
            }

            foreach (var pair in activityTracker)
            {
                Console.Write("{0}: ",pair.Key);
                bool first = true;

                foreach (var person in pair.Value)
                {
                    if (first)
                    {
                        Console.Write("{0}({1})", person.Key, person.Value);
                        first = false;
                    }
                    else
                    {
                        Console.Write(", {0}({1})", person.Key, person.Value);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}