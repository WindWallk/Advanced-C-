using System;

namespace _04.SequencesOfStrings
{
    class SequencesOfStrings
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            for (int i = 0; i < words.Length - 1; i++)
            {
                Console.Write(words[i]);
                if (words[i].Equals(words[i + 1]))
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine(words[words.Length-1]);
        }
    }
}
