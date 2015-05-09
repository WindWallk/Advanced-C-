using System;
using System.Linq;

namespace _08.LegoBlocks
{
    class LegoBlocks
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[][] left = new string[n][];
            string[][] right = new string[n][];
            string row;
            bool match = true;

            char[] emtySpace = new char[]{' ', '\t'};

            for (int i = 0; i < n; i++)
            {
                row = Console.ReadLine().Trim();
                left[i] = row.Split(emtySpace, StringSplitOptions.RemoveEmptyEntries).ToArray();
            }

            for (int i = 0; i < n; i++)
            {
                row = Console.ReadLine().Trim();
                right[i] = row.Split(emtySpace, StringSplitOptions.RemoveEmptyEntries).ToArray();
                Array.Reverse(right[i]);     
            }

            int rowLength = left[0].Length + right[0].Length;
            int cells = rowLength;

            for (int i = 1; i < n; i++)
            {
                int leftLength = left[i].Length;
                int rightLength = right[i].Length;
                cells += leftLength + rightLength;

                if (leftLength + rightLength != rowLength)
                {
                    match = false;
                }
            }

            if (match)
            {
                string[][] lego = new string[n][];

                for (int i = 0; i < n; i++)
                {
                    lego[i] = left[i].Concat(right[i]).ToArray();
                }

                for (int i = 0; i < n; i++)
                {
                    Console.Write("[");
                    Console.Write(string.Join(", ", lego[i]));
                    Console.WriteLine("]");
                }
            }
            else
            {
                Console.WriteLine("The total number of cells is: {0}", cells);
            }
        }
    }
}