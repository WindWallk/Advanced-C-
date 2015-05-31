using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.CouplesFrequency
{
    internal class CouplesFrequency
    {
        static void Main(string[] args)
        {
            string[] sequence = Console.ReadLine().Split(new char[] {' '});

            Dictionary<string, int> couples = new Dictionary<string, int>();

            for (int i = 0; i < sequence.Length - 1; i++)
            {
                string couple = string.Join(" ", sequence.Skip(i).Take(2));

                if (!couples.ContainsKey(couple))
                {
                    couples.Add(couple, 0);
                }
                couples[couple]++;
            }

            foreach (var couple in couples)
            {
                Console.WriteLine("{0} -> {1}", couple.Key, ((double)couple.Value / (sequence.Length - 1)).ToString("0.00%"));
            }
        }
    }
}
