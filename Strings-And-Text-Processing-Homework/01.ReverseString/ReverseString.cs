using System;

namespace _01.ReverseString
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            string stringToReverse = Console.ReadLine();
            string reversedString = StringReverse(stringToReverse);
            Console.WriteLine(reversedString);
        }

        private static string StringReverse(string stringToReverse)
        {
            char[] charArray = stringToReverse.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
