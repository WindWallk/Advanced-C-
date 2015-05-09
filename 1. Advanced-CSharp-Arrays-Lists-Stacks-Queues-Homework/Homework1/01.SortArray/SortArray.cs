using System;
using System.Linq;

namespace _01.SortArray
{
    class SortArray
    {
        static void Main(string[] args)
        {
            
            string input = Console.ReadLine();
            while (input == null)
            {
                input = Console.ReadLine();
            }

            int[] nums = input.Split().Select(int.Parse).ToArray();

            Array.Sort(nums);

            foreach (var num in nums)
            {
                Console.Write(num + " ");
            }
        }
    }
}