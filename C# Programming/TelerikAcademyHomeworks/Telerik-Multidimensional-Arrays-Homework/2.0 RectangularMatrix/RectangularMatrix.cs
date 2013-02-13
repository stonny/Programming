/* Write a program that reads a rectangular 
 * matrix of size N x M and finds in it the 
 * square 3 x 3 that has maximal sum of its elements.
*/
namespace _2._0_RectangularMatrix
{
    using System;
    using System.Linq;

    public class RectangularMatrix
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter matrix rows:");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Enter matrix columns:");
            int col = int.Parse(Console.ReadLine());
             /* Testing  with this Array
              * int[,] myArray = new int[,]{
              * {0, 2, 4, 0, 9, 5},
              * {7, 1, 3, 3, 2, 1},
              * {1, 3, 9, 8, 5, 6},
              * {4, 6, 7, 9, 1, 0},};
              * */
            int[,] myArray = new int [row, col];

            // myArrayay input
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write("myArray[{0}][{1}]=", i, j);
                    myArray[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int maxSum = 0;
            int rowElement = 0;
            int colElement = 0;

            // checking for maxSum in platfrom 3x3
            for (int i = 0; i < row - 2; i++)
            {
                for (int j = 0; j < col - 2; j++)
                {
                    int sum = myArray[i, j] + myArray[i, j + 1] + myArray[i, j + 2] +
                    myArray[i + 1, j] + myArray[i + 1, j + 1] + myArray[i + 1, j + 2] +
                    myArray[i + 2, j] + myArray[i + 2, j + 1] + myArray[i + 2, j + 2];
                    if (maxSum < sum)
                    {
                        maxSum = sum;
                        rowElement = i;
                        colElement = j;
                    }

                    sum = 0;
                }
            }

            // Printing On The Console
            Console.WriteLine("Best Platform(3x3):");
            Console.WriteLine("{0} {1} {2}",
                myArray[rowElement, colElement], 
                myArray[rowElement, colElement + 1], 
                myArray[rowElement, colElement + 2]);
            Console.WriteLine("{0} {1} {2}",
                myArray[rowElement + 1, colElement],
                myArray[rowElement + 1, colElement + 1],
                myArray[rowElement + 1, colElement + 2]);
            Console.WriteLine("{0} {1} {2}",
                myArray[rowElement + 2, colElement],
                myArray[rowElement + 2, colElement + 1],
                myArray[rowElement + 2, colElement + 2]);
            Console.WriteLine("Max Sum is: {0}", maxSum);
        }
    }
}
