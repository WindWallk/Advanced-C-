using System;

namespace _04.FirstLeargerThanNeighbours
{
    class FirstLeargerThanNeighbours
    {
        static void Main(string[] args)
        {
            int[] sequenceOne = { 1, 3, 4, 5, 1, 0, 5 };
            int[] sequenceTwo = { 1, 2, 3, 4, 5, 6, 6 };
            int[] sequenceThree = { 1, 1, 1 };

            Console.WriteLine(GetIndexOfFirstElementLargerThenNeighbours(sequenceOne));
            Console.WriteLine(GetIndexOfFirstElementLargerThenNeighbours(sequenceTwo));
            Console.WriteLine(GetIndexOfFirstElementLargerThenNeighbours(sequenceThree));
        }

        private static int GetIndexOfFirstElementLargerThenNeighbours(int[] nums)
        {
            for (int i = 1; i < nums.Length - 1; i++)
            {
                if (nums[i] > nums[i - 1] && nums[i] > nums[i + 1])
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
