using System;

namespace _03.LargerThanNeighbours
{
    class LargerThanNeighbours
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] nums = new int[n];

            for (int i = 0; i < n; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(IsLeargerThanNeighbours(nums, i));
            }
        }

        private static string IsLeargerThanNeighbours(int[] nums, int i)
        {
            if (i == 0)
            {
                if (nums[i] > nums[i + 1])
                {
                    return "True";
                }
                else
                {
                    return "False";
                }
            }
            else if (i == nums.Length - 1)
            {
                if (nums[i] > nums[i - 1])
                {
                    return "True";
                }
                else
                {
                    return "False";
                }
            }
            else
            {
                if (nums[i] > nums[i - 1] && nums[i] > nums[i + 1])
                {
                    return "True";
                }
                else
                {
                    return "False";
                }
            }
        }
    }
}
