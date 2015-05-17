using System;
using System.Linq;

namespace _06.NumberCalculations
{
    class NumberCalculations
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input double nums:");
            string input1 = Console.ReadLine();

            double[] nums1 = input1.Split(' ').Select(double.Parse).ToArray();

            Console.WriteLine("Input decimal nums:");
            string input2 = Console.ReadLine();

            decimal[] nums2 = input2.Split(' ').Select(decimal.Parse).ToArray();

            Min(nums1);
            Min(nums2);
            Max(nums1);
            Max(nums2);
            Sum(nums1);
            Sum(nums2);
            Avg(nums1);
            Avg(nums2);
            Product(nums1);
            Product(nums2);
        }

        private static void Min(double[] nums1)
        {
            double min = nums1[0];
            for (int i = 0; i < nums1.Length; i++)
            {
                if (min > nums1[i])
                {
                    min = nums1[i];
                }
            }

            Console.WriteLine("Double min:{0}", min);
        }

        private static void Min(decimal[] nums2)
        {
            decimal min = nums2[0];
            for (int i = 0; i < nums2.Length; i++)
            {
                if (min > nums2[i])
                {
                    min = nums2[i];
                }
            }

            Console.WriteLine("Decimal min:{0}", min);
        }

        private static void Max(double[] nums2)
        {
            double max = 0;
            for (int i = 0; i < nums2.Length; i++)
            {
                if (nums2[i] > max)
                {
                    max = nums2[i];
                }
            }

            Console.WriteLine("Double max:{0}", max);
        }

        private static void Max(decimal[] nums2)
        {
            decimal max = 0;
            for (int i = 0; i < nums2.Length; i++)
            {
                if (nums2[i] > max)
                {
                    max = nums2[i];
                }
            }

            Console.WriteLine("Decimal max:{0}", max);
        }

        private static void Sum(double[] nums2)
        {
            double sum = 0;
            for (int i = 0; i < nums2.Length; i++)
            {
                sum += nums2[i];
            }

            Console.WriteLine("Double sum:{0}", sum);
        }

        private static void Sum(decimal[] nums2)
        {
            decimal sum = 0;
            for (int i = 0; i < nums2.Length; i++)
            {
                sum += nums2[i];
            }

            Console.WriteLine("Decimal sum:{0}", sum);
        }

        private static void Avg(double[] nums2)
        {
            double sum = 0, avg;
            for (int i = 0; i < nums2.Length; i++)
            {
                sum += nums2[i];
            }

            avg = sum / nums2.Length;

            Console.WriteLine("Double average:{0}", avg);
        }

        private static void Avg(decimal[] nums2)
        {
            decimal sum = 0, avg;
            for (int i = 0; i < nums2.Length; i++)
            {
                sum += nums2[i];
            }

            avg = sum / nums2.Length;

            Console.WriteLine("Decimal average:{0}", avg);
        }

        private static void Product(double[] nums2)
        {
            double product = 1;
            for (int i = 0; i < nums2.Length; i++)
            {
                product *= nums2[i];
            }

            Console.WriteLine("Double product:{0}", product);
        }

        private static void Product(decimal[] nums2)
        {
            decimal product = 1;
            for (int i = 0; i < nums2.Length; i++)
            {
                product *= nums2[i];
            }

            Console.WriteLine("Decimal product:{0}", product);
        }
    }
}
