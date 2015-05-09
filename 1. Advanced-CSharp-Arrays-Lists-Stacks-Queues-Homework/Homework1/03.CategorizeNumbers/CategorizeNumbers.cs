using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.CategorizeNumbers
{
    class CategorizeNumbers
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input == null)
            {
                input = Console.ReadLine();
            }
            double[] nums = input.Split().Select(double.Parse).ToArray();
            List<double> roundNumbers = new List<double>();
            List<double> floatingPointNumbers = new List<double>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 1 != 0)
                {
                    floatingPointNumbers.Add(nums[i]);
                }
                else
                {
                    roundNumbers.Add(nums[i]);
                }
            }
            if (floatingPointNumbers.Count != 0)
            {
                Console.Write("[");
                foreach (var fP in floatingPointNumbers)
                {
                    Console.Write(fP + " ");
                }
                Console.Write("] - > ");
                Console.Write("min:{0:f2}, ", floatingPointNumbers.Min());
                Console.Write("max:{0:f2}, ", floatingPointNumbers.Max());
                Console.Write("sum:{0:f2}, ", floatingPointNumbers.Sum());
                Console.WriteLine("avg:{0:f2}", floatingPointNumbers.Average());
            }
            else
            {
                Console.WriteLine("No flaotingPointNumbers!");
            }

            if(roundNumbers.Count != 0)
            {
                Console.Write("[");
                foreach (var round in roundNumbers)
                {
                    Console.Write(round + " ");
                }
                Console.Write("] - > ");
                Console.Write("min:{0}, ", roundNumbers.Min());
                Console.Write("max:{0}, ", roundNumbers.Max());
                Console.Write("sum:{0}, ", roundNumbers.Sum());
                Console.WriteLine("avg:{0:f2}", roundNumbers.Average());
            }
            else
            {
                Console.WriteLine("No roundNumbers!");
            }
        }
    }
}
