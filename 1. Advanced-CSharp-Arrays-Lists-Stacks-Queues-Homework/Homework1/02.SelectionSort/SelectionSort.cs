using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SelectionSort
{
    class SelectionSort
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input == null)
            {
                input = Console.ReadLine();
            }

            int[] nums = input.Split().Select(int.Parse).ToArray();
            int temp;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
            }

            foreach (var num in nums)
            {
                Console.Write(num + " ");
            }
        }
    }
}
