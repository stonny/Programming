/* * We are given an array of integers and a number S.
 * Write a program to find if there exists a subset of the
 * elements of the array that has a sum S. Example:
 *	arr={2, 1, 2, 4, 3, 5, 2, 6}, S=14  yes (1+2+5+6)
 */
namespace _16._0_SumOfSubset
{
    using System;
    using System.Linq;

    public class SubsetOfmyArray
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Size of the array:");
            int arraySize = int.Parse(Console.ReadLine());
            int[] myArray = new int[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                Console.Write("arr[{0}]=", i);
                myArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter the sum:");
            int sum = int.Parse(Console.ReadLine());
            string subset = string.Empty;
            int maxSubsets = (int)Math.Pow(2, arraySize) - 1;
            for (int i = 1; i <= maxSubsets; i++)
            {
                subset = string.Empty;
                int checkSum = 0;
                for (int j = 0; j <= arraySize; j++)
                {
                    int mask = 1 << j;
                    int andMask = i & mask;
                    int bit = andMask >> j;
                    if (bit == 1)
                    {
                        checkSum = checkSum + myArray[j];
                        subset = subset + "+" + myArray[j];
                    }
                }

                if (checkSum == sum)
                {
                    subset = subset.Remove(0, 1);
                    Console.WriteLine("Yes({0})", subset);
                }
            }
        }
    }
}
