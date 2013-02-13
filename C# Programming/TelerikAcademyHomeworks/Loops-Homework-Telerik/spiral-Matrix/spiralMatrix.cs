using System;

class spiralMatrix
{
    static void Main()
    {
        Console.WriteLine("Enter N:");
        byte N = byte.Parse(Console.ReadLine());
        int[,] myArray=new int [N,N];
        int i = N;
        int j = N;
        int final = N * N;
        int rowStart = 0;
        int rowEnd = N - 1;
        int colStart = 0;
        int colEnd =N - 1;
        int current = 0;
        myArray[0, 0] = 0;
        string dir = "right";
        do
        {
            switch (dir)
            {
                case "right":
                    for (j = colStart; j <= colEnd; j++)
                    {
                        current++;
                        myArray[rowStart, j] = current;
                    }
                    dir = "down";
                    rowStart++;
                    break;
                case "down":
                    for (i = rowStart; i <= rowEnd; i++)
                    {
                        current++;
                        myArray[i, colEnd] = current;
                    }
                    dir = "left";
                    colEnd--;
                    break;
                case "left":
                    for (j = colEnd; j >= colStart; j--)
                    {
                        current++;
                        myArray[rowEnd, j] = current;
                    }
                    dir = "up";
                    rowEnd--;
                    break;
                case "up":
                    for (i = rowEnd; i >= rowStart; i--)
                    {
                        current++;
                        myArray[i, colStart] = current;
                    }
                    dir = "right";
                    colStart++;
                    break;
                default:
                    Console.WriteLine("Unknown error");
                    break;
            }
        } while (current < final);
        for (i = 0; i < N; i++)
        {
            for (j = 0; j < N; j++)
            {
                Console.Write("{0,3} ", myArray[i, j]);
            }
            Console.WriteLine();
        }
    }
}

