/* We are given a matrix of strings of size N x M.
 * Sequences in the matrix we define as sets of several neighbor
 * elements located on the same line, column or diagonal. 
 * Write a program that finds the longest sequence of equal 
 * strings in the matrix.
 * */
namespace _03.SequenceInTheMatrix
{
    using System;
    using System.Linq;

    public class SequenceInTheMatrix
    {
        public static int GetMaxSequence(string[] myArray, ref string maxElement)
        {
            if (myArray.Length < 1)
            {
                return -1;
            }

            int count = 1, maxCount = 0;
            string element = string.Empty;
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] == null)
                {
                    continue;
                }

                if (element == myArray[i])
                {
                    count++;
                }

                if (element != myArray[i] || i == myArray.Length - 1)
                {
                    if (count > maxCount)
                    {
                        if (element == string.Empty)
                        {
                            element = myArray[i];
                        }

                        maxElement = element;
                        maxCount = count;
                    }

                    element = myArray[i];
                    count = 1;
                }
            }

            if (maxCount == 1 && maxElement != string.Empty)
            {
                maxCount = 0;
                maxElement = string.Empty;
            }

            return maxCount;
        }

        public static void Main()
        {
            Console.Write("Enter matrix rows:");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter matrix columns:");
            int m = int.Parse(Console.ReadLine());
            string[,] matrix = new string[n, m];
            string maxElement = string.Empty;
            int row = 0, col = 0, maxCount = 0;

            for (row = 0; row < n; row++)
            {
                for (col = 0; col < m; col++)
                {
                    Console.Write("arr[{0},{1}]=", row, col);
                    matrix[row, col] = Console.ReadLine();
                }
            }

            int count = 0;
            int arrIndex = 0;
            string element = string.Empty;
            string position = string.Empty;

            // Line
            for (row = 0; row < n; row++)
            {
                string[] arrTmp = new string[m];
                for (col = 0, arrIndex = 0; col < m; col++)
                {
                    arrTmp[arrIndex++] = matrix[row, col];
                }

                count = 0;
                element = string.Empty;

                count = GetMaxSequence(arrTmp, ref element);

                if (count == -1)
                {
                    continue;
                }

                if (count > maxCount)
                {
                    maxCount = count;
                    maxElement = element;
                    position = "Line";
                }
            }

            // Column
            for (col = 0; col < n; col++)
            {
                string[] arrTmp = new string[n];
                for (row = 0, arrIndex = 0; row < n; row++)
                {
                    arrTmp[arrIndex++] = matrix[row, col];
                }

                count = 0;
                element = string.Empty;

                count = GetMaxSequence(arrTmp, ref element);

                if (count == -1)
                {
                    continue;
                }

                if (count > maxCount)
                {
                    maxCount = count;
                    maxElement = element;
                    position = "Column";
                }
            }

            // MainDiagonal
            int mainIndex = n - 1, secIndex = 0;
            for (col = 0; col < m; col++)
            {
                while (true)
                {
                    if (mainIndex > 0)
                    {
                        mainIndex--;
                    }

                    if (mainIndex == 0)
                    {
                        secIndex = col;
                    }
                    else
                    {
                        secIndex = 0;
                    }

                    string[] arrTmp = new string[n];
                    arrIndex = 0;

                    for (row = mainIndex; row < n; row++, secIndex++)
                    {
                        if (secIndex == m)
                        {
                            break;
                        }

                        arrTmp[arrIndex++] = matrix[row, secIndex];
                    }

                    count = 0;
                    element = string.Empty;

                    count = GetMaxSequence(arrTmp, ref element);

                    if (count == -1)
                    {
                        continue;
                    }

                    if (count > maxCount)
                    {
                        maxCount = count;
                        maxElement = element;
                        position = "Diagonal";
                    }

                    if (mainIndex == 0)
                    {
                        break;
                    }
                }
            }

            // SecondaryDiagonal
            mainIndex = n - 1;
            secIndex = 0;
            for (col = m - 1; col >= 0; col--)
            {
                while (true)
                {
                    if (mainIndex > 0)
                    {
                        mainIndex--;
                    }

                    if (mainIndex == 0)
                    {
                        secIndex = col;
                    }
                    else
                    {
                        secIndex = m - 1;
                    }

                    string[] arrTmp = new string[n];
                    arrIndex = 0;

                    for (row = mainIndex; row < n; row++, secIndex--)
                    {
                        if (secIndex == -1)
                        {
                            break;
                        }

                        arrTmp[arrIndex++] = matrix[row, secIndex];
                    }

                    count = 0;
                    element = string.Empty;

                    count = GetMaxSequence(arrTmp, ref element);

                    if (count == -1)
                    {
                        continue;
                    }

                    if (count > maxCount)
                    {
                        maxCount = count;
                        maxElement = element;
                        position = "Diagonal";
                    }

                    if (mainIndex == 0)
                    {
                        break;
                    }
                }
            }

            if (maxCount > 0 && maxElement != string.Empty)
            {
                for (int i = 0; i < maxCount; i++)
                {
                    Console.Write("{0} ", maxElement);
                }

                Console.WriteLine("at {0}", position);
            }
            else
            {
                Console.WriteLine("No Repeating Elements found !");
            }
        }
    }
}
