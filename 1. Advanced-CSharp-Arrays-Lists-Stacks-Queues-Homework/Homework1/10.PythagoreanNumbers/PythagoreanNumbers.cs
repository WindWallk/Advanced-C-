using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.PythagoreanNumbers
{
    class PythagoreanNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] nums = new int[n];
            int result;
            bool solution = false;

            for (int i = 0; i < n; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }

            List<int> squares = nums.Select(a => a*a).ToList();

            for (int i = 0; i < squares.Count; i++)
            {
                for (int j = 0; j < squares.Count; j++)
                {
                    result = squares[i] + squares[j];
                    if (squares[j] >= squares[i] && squares.Contains(result))
                    {
                        Console.WriteLine("{0}*{0} + {1}*{1} = {2}*{2}", (int)Math.Sqrt(squares[i]), (int)Math.Sqrt(squares[j]), (int)Math.Sqrt(result));
                        solution = true;
                    }
                }
            }

            if (!solution)
            {
                Console.WriteLine("No");
            }
        }
    }
}
