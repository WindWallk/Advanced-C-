using System;

namespace _01.BiggerNumber
{
    class BiggerNumber
    {
        private static int GetMax(int firstNumber, int secondNumber)
        {
            if (firstNumber > secondNumber)
            {
                return firstNumber;
            }
            return secondNumber;
        }

        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            int max = GetMax(firstNumber, secondNumber);

            Console.WriteLine(max);
        }
    }
}