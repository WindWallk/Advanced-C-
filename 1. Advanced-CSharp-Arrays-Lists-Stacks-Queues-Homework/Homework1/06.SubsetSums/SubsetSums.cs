using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.SubsetSums
{
    class SubsetSums
    {
        private static int[] nums;
        private static bool solution = false;
        private static int result;

        static void Subsets(int index, List<int> subset) //I looked at the code of KatyaMarincheva for this part and tried to write it myself
        {
            if (subset.Sum() == result && subset.Count > 0)
            {
                Console.WriteLine("{0} = {1}", String.Join("+",subset), result);
                solution = true;
            }

            for (int i = index; i < nums.Length; i++)
            {
                subset.Add(nums[i]);
                Subsets(i+1, subset);
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

            if (!solution)
            {
                Console.WriteLine("No matching solutions");
            }
        }
    }
}
