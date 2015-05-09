using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace _05.LongestIncreasingSequence
{
    class LongestIncreasingSequence
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input == null)
            {
                input = Console.ReadLine();
            }

            int[] nums = input.Split().Select(int.Parse).ToArray();
            int currentLength = 1;
            int end = 0;
            int maxLength = 1;

            Console.Write(nums[0]+ " ");
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > nums[i - 1])
                {
                    currentLength++;
                    Console.Write(nums[i] + " ");
                }
                else
                {
                    currentLength = 1;
                    Console.WriteLine();
                    Console.Write(nums[i] + " ");
                }

                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                    end = i;
                }
            }
            
            Console.WriteLine();
            Console.WriteLine("Longest increasing sequence is:");
            for (int i = end - maxLength + 1; i <= end ; i++)
            {
                Console.Write(nums[i]+ " ");
            }
            Console.WriteLine();
        }
    }
}
