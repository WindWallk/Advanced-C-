using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.SortedSubsetSums
{
    class SortedSubsetSums
    {
        private static int[] nums;
        private static bool solution = false;
        private static int result;
        private static List<List<int>> subsets = new List<List<int>>(); 

        static void Subsets(int index, List<int> subset) //I looked at the code of KatyaMarincheva for this part and tried to write it myself
        {
            if (subset.Sum() == result && subset.Count > 0)
            {
                subsets.Add(new List<int>(subset));
                solution = true;
            }

            for (int i = index; i < nums.Length; i++)
            {
                subset.Add(nums[i]);
                Subsets(i + 1, subset);
                subset.RemoveAt(subset.Count - 1);
            }
        }

        static void Main(string[] args)
        {
            result = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            nums = input.Split(' ').Select(int.Parse).ToArray();

            List<int> subset = new List<int>();

            Subsets(0, subset);

            for (int i = 0; i < subsets.Count; i++)
            {
                subsets[i].Sort();
            }

            var uniqueSubsets = subsets.Distinct().ToList();

            var sorted = uniqueSubsets.OrderBy(list => list.Count).ThenBy(list => list[0]);

            foreach (var item in sorted)
            {
                Console.WriteLine("{0} = {1}", string.Join("+", item), result);
            }
                
            if (!solution)
            {
                Console.WriteLine("No matching solutions");
            }
        }
    }
}
