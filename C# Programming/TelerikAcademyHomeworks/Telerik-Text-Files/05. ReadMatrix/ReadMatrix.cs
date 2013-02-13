/* Write a program that reads a text file containing 
 * a square matrix of numbers and finds in the matrix an 
 * area of size 2 x 2 with a maximal sum of its elements.
 * The first line in the input file contains the size of matrix N.
 * Each of the next N lines contain N numbers separated by space. 
 * The output should be a single number in a separate text file. 
 */
namespace _05.ReadMatrix
{
    using System;
    using System.Linq;
    using System.IO;

    class ReadMatrix
    {
        static void Main(string[] args)
        {
            using(StreamWriter sw = new StreamWriter("../../output.txt"))
            {
                using (StreamReader sr = new StreamReader("../../input.txt"))
                {
                    string row = sr.ReadLine();
                    int n = int.Parse(row);
                    int[,] myArray = new int[n, n];
                    int j = 0;
                    while (row != null)
                    {
                        row = sr.ReadLine();
                        if (row != null)
                        {
                            string[] elements = row.Split(new[] {' '});
                            for (int i = 0; i < n; i++)
                            {

                                myArray[j, i] = int.Parse(elements[i]);
                            }
                            j++;
                        }
                    }
                    int sum = GetArea(myArray, n, n);
                    sw.WriteLine(sum);
                }
            }
        }
        public static int GetArea(int[,] myArray, int row, int col)
        {
            int maxSum = 0;
            for (int i = 0; i < row - 1; i++)
            {
                for (int j = 0; j < col - 1; j++)
                {
                    int sum = myArray[i, j] + myArray[i, j + 1] + 
                    myArray[i + 1, j] + myArray[i + 1, j + 1];
                    if (maxSum < sum)
                    {
                        maxSum = sum;
                    }

                    sum = 0;
                }
            }
            return maxSum;
        }
    }
}
