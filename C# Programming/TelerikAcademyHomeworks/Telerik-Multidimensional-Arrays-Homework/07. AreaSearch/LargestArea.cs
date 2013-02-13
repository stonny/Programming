/* Write a program that finds the largest
 * area of equal neighbor elements in a
 * rectangular matrix and prints its size
 */
namespace _07.AreaSearch
{
    using System;
    using System.Linq;

    public class LargestArea
    {
        private static int[,] matrix;
        private static bool[,] usedElements;
        private static int largestArea = 0;
        private static int tempAreaSize;
        private static int n;
        private static int m;
        private static int pattern;

        public static void Main()
        {
            /* Testing
            Console.Write("N = ");
            int N = int.Parse(Console.ReadLine());
            Console.Write("M = ");
            int M = int.Parse(Console.ReadLine());
            matrix = new int[N, M];
            for (int i = 0; i < N; i++)
            {
            for (int y = 0; y < M; y++)
            {
            Console.Write("[{0},{1}] = ", i, y);
            matrix[i, y] = int.Parse(Console.ReadLine());
            }
            }
            */
            n = 5;

            m = 5;

            int element = 0;

            matrix = new int[,]

            {
                { 3, 0, 4, 2, 2 },
                { 3, 0, 2, 2, 2 },
                { 0, 0, 0, 8, 8 },
                { 0, 3, 0, 0, 9 },
                { 7, 1, 2, 0, 0 }
            }; 

            usedElements = new bool[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int y = 0; y < m; y++)
                {
                    if (usedElements[i, y] == false) 
                    {
                        tempAreaSize = 1;

                        pattern = matrix[i, y];

                        FindArea(i, y);

                        if (tempAreaSize > largestArea)
                        {
                            largestArea = tempAreaSize;

                            element = pattern;
                        }
                    }
                }
            }

            Console.WriteLine("{0} -> {1} times", element, largestArea);
        }

        private static void FindArea(int row, int col)
        {
            int[] neighRow = new int[] { -1, 1, 0, 0 };
            int[] neighCol = new int[] { 0, 0, 1, -1 };
            usedElements[row, col] = true; 

            for (int i = 0; i < 4; i++)
            {
                if (row + neighRow[i] >= 0 &&
                    row + neighRow[i] < n &&
                    col + neighCol[i] >= 0 &&
                    col + neighCol[i] < m)
                {
                    if (matrix[row + neighRow[i], col + neighCol[i]] == pattern &&
                        usedElements[row + neighRow[i], col + neighCol[i]] == false)
                    {
                        tempAreaSize++;
                        FindArea(row + neighRow[i], col + neighCol[i]);
                    }
                }
            }
        }
    }
}