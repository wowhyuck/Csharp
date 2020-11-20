using System;

namespace DataStructure
{
    class Program
    {
        class Map
        {
            int[,] tiles =
            {
                { 1, 1, 1, 1, 1 },
                { 1, 0, 0, 0, 1 },
                { 1, 0, 0, 0, 1 },
                { 1, 0, 0, 0, 1 },
                { 1, 1, 1, 1, 1 },
            };

            public void Render()
            {
                var defaultColor = Console.ForegroundColor;

                for (int y = 0; y < tiles.GetLength(1); y++)
                {
                    for (int x = 0; x < tiles.GetLength(0); x++)
                    {
                        if (tiles[y, x] == 1)
                            Console.ForegroundColor = ConsoleColor.Red;
                        else
                            Console.ForegroundColor = ConsoleColor.Green;

                        Console.Write("\u25cf");
                    }
                    Console.WriteLine();
                }
                Console.ForegroundColor = defaultColor;
            }
        }

        static void Main(string[] args)
        {
            Map map = new Map();
            map.Render();

            // 가변 배열
            int[][] a = new int[3][];
            a[0] = new int[3];
            a[1] = new int[6];
            a[2] = new int[2];

            a[0][0] = 1;
        }
    }
}
