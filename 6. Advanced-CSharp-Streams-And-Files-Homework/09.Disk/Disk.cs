using System;

namespace _09.Disk
{
    class Disk
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int R = int.Parse(Console.ReadLine());

            int center_x = N/2;
            int center_y = N/2;

            for (int row = 0; row < N; row++)
            {
                for (int col = 0; col < N; col++)
                {
                    bool insideCircle = Math.Pow((col - center_x), 2) + Math.Pow((row - center_y), 2) <= Math.Pow(R, 2);

                    if (insideCircle)
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write('.');
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
