using System;
using System.Linq;

namespace _09.StuckNumbers
{
    class StuckNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool result = false;

            string input = Console.ReadLine();
            int[] nums = input.Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    for (int k = 0; k < nums.Length; k++)
                    {
                        for (int l = 0; l < nums.Length; l++)
                        {
                            if (i != j && i != k && i != l && j != k && j != l && k != l)
                            {
                                string a = "" + nums[i] + nums[j];
                                string b = "" + nums[k] + nums[l];

                                if (a.Equals(b))
                                {
                                    result = true;
                                    Console.WriteLine("{0}|{1}=={2}|{3}", nums[i], nums[j], nums[k], nums[l]);
                                }
                            }

                        }
                    }
                }
            }

            if (!result)
            {
                Console.WriteLine("No");
            }
        }
    }
}
