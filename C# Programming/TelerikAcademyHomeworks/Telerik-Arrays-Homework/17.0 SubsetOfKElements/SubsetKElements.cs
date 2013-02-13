/* * Write a program that reads three integer numbers N, K and S 
 * and an array of N elements from the console.
 * Find in the array a subset of K elements
 * that have sum S or indicate about its absence.
 */
namespace _17._0_SubsetOfKmyArray
{
    using System;
    using System.Linq;

    public class SubsetKmyArray
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

            Console.Write("Enter K:");
            int k = int.Parse(Console.ReadLine());
            Console.Write("Enter the sum:");
            int sum = int.Parse(Console.ReadLine());
            bool isSubset = false;
            string subset = string.Empty;
            int maxSubsets = (int)Math.Pow(2, arraySize);
            for (int i = 1; i < maxSubsets; i++)
            {
                subset = string.Empty;
                int checkSum = 0;
                int lenCounter = 0;
                for (int j = 0; j <= arraySize; j++)
                {
                    int mask = 1 << j;
                    int andMask = i & mask;
                    int bit = andMask >> j;
                    if (bit == 1)
                    {
                        checkSum = checkSum + myArray[j];
                        subset = subset + "+" + myArray[j];
                        lenCounter++;
                    }
                }

                if (checkSum == sum && lenCounter == k)
                {
                    subset = subset.Remove(0, 1);
                    Console.WriteLine("Yes({0})", subset);
                    isSubset = true;
                }
            }

            if (isSubset == false)
            {
                Console.WriteLine("There is no such subset!");
            }
        }
    }
}
