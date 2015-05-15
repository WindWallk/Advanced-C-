using System;

namespace _02.StringLength
{
    class StringLength
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] output = new char[20];

            for (int i = 0; i < 20; i++)
            {
                if (i < input.Length)
                {
                    output[i] = input[i];
                }
                else
                {
                    output[i] = '*';
                }
            }

            Console.WriteLine(new string(output));
        }
    }
}
