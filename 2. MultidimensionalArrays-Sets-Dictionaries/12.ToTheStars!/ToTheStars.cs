using System;
using System.Collections.Generic;

namespace _12.ToTheStars_
{
    class ToTheStars
    {
        static void Main(string[] args)
        {
            Dictionary<string, Tuple<int, int>> stars = new Dictionary<string, Tuple<int, int>>();

            for (int i = 0; i < 3; i++)
            {
                string[] inputStars = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                string starName = inputStars[0];
                int starX = int.Parse(inputStars[1]);
                int starY = int.Parse(inputStars[2]);

                stars[starName] = new Tuple<int, int>(starX, starY);
            }

            string[] spaceshipStart = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            int moves = int.Parse(Console.ReadLine());
            int spaceshipX = int.Parse(spaceshipStart[0]);
            int spaceshipY = int.Parse(spaceshipStart[1]);

            while (moves >= 0)
            {
                bool arroundStar = false;

                foreach (var star in stars)
                {
                    if (isArroundStar(star.Value.Item1, star.Value.Item2, spaceshipX, spaceshipY))
                    {
                        arroundStar = true;
                        Console.WriteLine(star.Key);
                        break;
                    }
                }

                if (!arroundStar)
                {
                    Console.WriteLine("space");
                }

                spaceshipY++;
                moves--;
            }
        }

        private static bool isArroundStar(int starX, int starY, int spaceshipX, int spaceshipY)
        {
            if (spaceshipX >= starX - 1 && spaceshipX <= starX + 1 && spaceshipY >= starY - 1 && spaceshipY <= starY + 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
