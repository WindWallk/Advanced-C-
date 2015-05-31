using System;

namespace _10.PaintBall
{
    class PaintBall
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = 1023;
            }

            string shot = Console.ReadLine();
            bool isBlack = true;

            do
            {
                int radius = int.Parse(shot.Substring(4));
                int row = int.Parse(shot[0].ToString());
                int bitPosition = int.Parse(shot[2].ToString());

                for (int i = GetStartPos(row, radius); i <= GetEndPos(row, radius, numbers.Length); i++)
                {
                    if (isBlack)
                    {
                        for (int j = GetStartPos(bitPosition, radius); j <= GetEndPos(bitPosition, radius, numbers.Length); j++)
                        {
                            numbers[i] &= ~(1 << j);
                        }
                    }
                    else
                    {
                        for (int j = GetStartPos(bitPosition, radius); j <= GetEndPos(bitPosition, radius, numbers.Length); j++)
                        {
                            numbers[i] |= (1 << j);
                        }
                    }
                }

                isBlack = !isBlack;
                shot = Console.ReadLine();
            } while (shot != "End");

            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine(sum);
        }

        static int GetStartPos(int n, int radius)
        {
            return n - radius >= 0 ? n - radius : 0;
        }

        static int GetEndPos(int n, int radius, int lenght)
        {
            return n + radius < lenght ? n + radius : lenght - 1;
        }
    }
}
