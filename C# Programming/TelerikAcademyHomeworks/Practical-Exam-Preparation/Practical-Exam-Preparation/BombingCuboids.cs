using System;
using System.Collections.Generic;
using System.Linq;

class BombingCuboids
{
    static int width;
    static int height;
    static int depth;
    static char[, ,] cuboid;
    static int N;
    static int[,] bombs;
    static Dictionary<char, int> letters = new Dictionary<char, int>();
    static int lettersCount = 0;
    static int startDepth;
    static int endDepth;
    static int startWidth;
    static int endWidth;
    static int startHeight;

    static void GetInput()
    {
        string[] input = Console.ReadLine().Split();
        width = int.Parse(input[0]);
        height = int.Parse(input[1]);
        depth = int.Parse(input[2]);
        cuboid = new char[width, height, depth];
        for (int h = 0; h < height; h++)
        {
            input = Console.ReadLine().Split();
            for (int d = 0; d < depth; d++)
            {
                for (int w = 0; w < width; w++)
                {
                    cuboid[w, h, d] = input[d][w];
                }
            }
        }
        N = int.Parse(Console.ReadLine());
        bombs = new int[N, 4];
        for (int i = 0; i < N; i++)
        {
            input = Console.ReadLine().Split();
            bombs[i, 0] = int.Parse(input[0]);
            bombs[i, 1] = int.Parse(input[1]);
            bombs[i, 2] = int.Parse(input[2]);
            bombs[i, 3] = int.Parse(input[3]);
        }
    }
    static void BringCubesDown()
    {
        for (int d = startDepth; d < endDepth; d++)
        {
            for (int w = startWidth; w < endWidth; w++)
            {
                int count = 0;
                int startH = startHeight;
                bool isFound = false;
                for (int h = startHeight; h < height; h++)
                {
                    if (cuboid[w, h, d] == '1')
                    {
                        if (!isFound)
                        {
                            startH = h;
                            isFound = true;
                        }
                        count++;
                    }
                    if (isFound && cuboid[w, h, d] != '1')
                    {
                        break;
                    }
                }
                if (isFound)
                {
                    for (int i = startH; i < height - count; i++)
                    {
                        cuboid[w, i, d] = cuboid[w, i + count, d];
                    }
                    for (int i = height - count; i < height; i++)
                    {
                        cuboid[w, i, d] = '1';
                    }
                }
            }
        }
    }
    static void BombExplode(int[,] bombs, int i)
    {
        int bombW = bombs[i, 0];
        int bombH = bombs[i, 1];
        int bombD = bombs[i, 2];
        int perimeter = bombs[i, 3];
        startDepth = Math.Max(bombD - perimeter, 0);
        endDepth = Math.Min(bombD + perimeter + 1, depth);
        startHeight = Math.Max(bombH - perimeter, 0);
        int endHeight = Math.Min(bombH + perimeter + 1, height);
        startWidth = Math.Max(bombW - perimeter, 0);
        endWidth = Math.Min(bombW + perimeter + 1, width);
        for (int d = startDepth; d < endDepth; d++)
        {
            for (int h = startHeight; h < endHeight; h++)
            {
                for (int w = startWidth; w < endWidth; w++)
                {
                    int W = (w - bombW) * (w - bombW);
                    int H = (h - bombH) * (h - bombH);
                    int D = (d - bombD) * (d - bombD);
                    int distance = W + H + D;
                    int P = perimeter * perimeter;
                    if (distance <= P)
                    {
                        int value;
                        if (letters.TryGetValue(cuboid[w, h, d], out value))
                        {
                            letters[cuboid[w, h, d]] = value + 1;
                        }
                        else
                        {
                            letters.Add(cuboid[w, h, d], 1);
                        }
                        if (cuboid[w, h, d] != '1')
                        {
                            lettersCount++;
                            cuboid[w, h, d] = '1';
                        }
                    }
                }
            }
        }
    }
    static void PrintResult()
    {
        letters = letters.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
        Console.WriteLine(lettersCount);
        foreach (var item in letters)
        {
            if (item.Key != '1')
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
        }
    }
    static void Main()
    {
        GetInput();
        for (int i = 0; i < N; i++)
        {
            BombExplode(bombs, i);
            BringCubesDown();
        }
        PrintResult();
    }
}