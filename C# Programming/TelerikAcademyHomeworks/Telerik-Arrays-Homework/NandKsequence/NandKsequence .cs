/* Write a program that reads two integer numbers N and K
 * and an array of N elements from the console.
 * Find in the array those K elements that have maximal sum.
*/
namespace NandKsequence
{
    using System;
    using System.Linq;

    public class NandKsequence 
    {
        public static void Main(string[] args)
        {
            Console.Write("N=");
            int n = int.Parse(Console.ReadLine());
            Console.Write("K=");
            int k = int.Parse(Console.ReadLine());
            int[] myArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("arr[{0}]=", i);
                myArray[i] = int.Parse(Console.ReadLine());
            }

            string bestSeq = string.Empty;
            int sum = 0;
            int maxSum = 0;
            for (int i = 0; i < n; i++)
            {
                string currentSeq = string.Empty;

                if (i + k > n)
                {
                    break;
                }

                for (int j = i; j < i + k; j++)
                {
                    sum = sum + myArray[j];
                    currentSeq = currentSeq + "+" + myArray[j];
                }

                if (sum > maxSum)
                {
                    bestSeq = currentSeq;
                    maxSum = sum;
                }

                sum = 0;
            }
            
            Console.WriteLine(bestSeq.Remove(0, 1) + "->" + maxSum);
        }
    }
}
