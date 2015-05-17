using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.GenericArraySort
{
    class GenericArraySort
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input ints:");
            string input = Console.ReadLine();
            int[] nums = input.Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine("Input strings:");
            input = Console.ReadLine();
            string[] strs = input.Split(' ').ToArray();

            DateTime[] dates =
            {
                new DateTime(2002, 3, 1),
                new DateTime(2015, 5, 6),
                new DateTime(2014, 1, 1)
            };

            Sort(strs);
            Sort(nums);
            Sort(dates);
        }

        static void Sort<T>(T[] value) where T : IComparable
        {
            List<T> list = new List<T>();
            for (int i = 0; i < value.Length; i++)
            {
                list.Add(value[i]);
            }

            T temp;

            for (int i = 0; i < list.Count; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[i].CompareTo(list[j]) > 0)
                    {
                        temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }
            }

            Console.WriteLine("{0}", string.Join(", ", list));
        }
    }
}