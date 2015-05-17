using System;
using System.Runtime.InteropServices;

namespace _02.LastDigitOfNumber
{
    class LastDigitOfNumber
    {
        static string GetLastDigitAsWord(int number)
        {
            int lastDigit = number % 10;

            if (lastDigit == 0)
            {
                return "zero";
            }
            if (lastDigit == 1)
            {
                return "one";
            }
            if (lastDigit == 2)
            {
                return "two";
            }
            if (lastDigit == 3)
            {
                return "three";
            }
            if (lastDigit == 4)
            {
                return "four";
            }
            if (lastDigit == 5)
            {
                return "five";
            }
            if (lastDigit == 6)
            {
                return "six";
            }
            if (lastDigit == 7)
            {
                return "seven";
            }
            if (lastDigit == 8)
            {
                return "eight";
            }
                return "nine";
        }

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
                Console.WriteLine(GetLastDigitAsWord(nums[i]));
            }
        }
    }
}
