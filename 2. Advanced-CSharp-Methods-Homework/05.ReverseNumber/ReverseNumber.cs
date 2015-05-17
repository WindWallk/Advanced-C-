using System;
using System.Linq;
using System.Text;

namespace _05.ReverseNumber
{
    class ReverseNumber
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double[] nums = new double[n];

            for (int i = 0; i < n; i++)
            {
                nums[i] = Double.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(GetReversedNumber(nums[i]));                
            }
        }

        private static double GetReversedNumber(double num)
        {
            string ToReverse = num.ToString();
            StringBuilder reverser = new StringBuilder();

            for (int i = ToReverse.Length - 1; i >= 0; i--)
            {
                reverser.Append(ToReverse[i]);
            }
            string reversed = reverser.ToString();

            return double.Parse(reversed);
        }
    }
}
