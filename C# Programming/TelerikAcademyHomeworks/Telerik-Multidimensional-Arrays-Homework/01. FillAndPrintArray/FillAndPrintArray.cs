// Write a program that fills and prints a matrix of size (n, n)
namespace _01.FillAndPrintArray
{
    using System;
    using System.Linq;

    public class FillAndPrintArray
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine(new string('-', 20));
            Console.WriteLine("1  PrintArrayA");
            Console.WriteLine("2. PrintArrayB");
            Console.WriteLine("3. PrintArrayC");
            Console.WriteLine("4. PrintArrayD");
            Console.WriteLine("Enter option(1-4):");
            Console.WriteLine(new string('-', 20));
            int choice = int.Parse(Console.ReadLine());
            Console.Write("Enter size of the array:");
            int n = int.Parse(Console.ReadLine());
            int[,] myArray = new int[n, n];
            switch (choice)
            {
                case 1: FillAndPrintArrayA(myArray, n);
                    break;
                case 2: FillAndPrintArrayB(myArray, n);
                    break;
                case 3: FillAndPrintArrayC(myArray, n);
                    break;
                case 4: FillAndPrintArrayD(myArray, n);
                    break;
                default: Console.WriteLine("Wrong option! Try again!");
                    break;
            }
        }

        private static void FillAndPrintArrayA(int[,] myArray, int n)
        {
            int index = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    myArray[i, j] = index;
                    index++;
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,3} ", myArray[j, i]);
                }
            }

            Console.WriteLine();
        }

        private static void FillAndPrintArrayB(int[,] myArray, int n)
        {
            int index = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    myArray[i, j] = index;
                    index++;
                }
            }

            index = n;
            int lastI = 0;
            for (int i = 0; i < n; i++)
            {
                index--;
                lastI = i;
                Console.WriteLine();
                for (int j = 0; j < n; j++)
                {
                    if (j != 0)
                    {
                        if (j % 2 == 1)
                        {
                            i = index;
                        }
                        else
                        {
                            i = lastI;
                        }
                    }

                    Console.Write("{0,3} ", myArray[j, i]);
                    i = lastI;
                }
            }
        }

        private static void FillAndPrintArrayC(int[,] myArray, int n)
        {
            int counter = 1;

            for (int i = 0; i <= n - 1; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    myArray[n - i + j - 1, j] = counter++;
                }
            }

            for (int i = n - 2; i >= 0; i--)
            {
                for (int j = i; j >= 0; j--)
                {
                    myArray[i - j, n - j - 1] = counter++;
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,3} ", myArray[i, j]);
                }

                Console.WriteLine();
            }
        }

        private static void FillAndPrintArrayD(int[,] myArray, int n)
        {
            int i = n;
            int j = n;
            int final = n * n;
            int rowStart = 0;
            int rowEnd = n - 1;
            int colStart = 0;
            int colEnd = n - 1;
            int index = 0;
            myArray[0, 0] = 0;
            int dir = 4;
            do
            {
                if (dir == 4)
                {
                    for (j = colStart; j <= colEnd; j++)
                    {
                        index++;
                        myArray[rowStart, j] = index;
                    }

                    dir = 2;
                    rowStart++;
                }

                if (dir == 2)
                {
                    for (i = rowStart; i <= rowEnd; i++)
                    {
                        index++;
                        myArray[i, colEnd] = index;
                    }

                    dir = 3;
                    colEnd--;
                }

                if (dir == 3)
                {
                    for (j = colEnd; j >= colStart; j--)
                    {
                        index++;
                        myArray[rowEnd, j] = index;
                    }

                    dir = 1;
                    rowEnd--;
                }
                
                if (dir == 1)
                {
                    for (i = rowEnd; i >= rowStart; i--)
                    {
                        index++;
                        myArray[i, colStart] = index;
                    }

                    dir = 4;
                    colStart++;
                }
                else
                {
                    Console.WriteLine("Unknown error");
                }
            }
            while (index < final);

            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("{0,3} ", myArray[j, i]);
                }

                Console.WriteLine();
            }
        }
    }
}
