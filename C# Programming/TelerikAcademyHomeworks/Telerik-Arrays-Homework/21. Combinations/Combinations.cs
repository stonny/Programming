/* Write a program that reads two numbers N and K and
 * generates all the combinations of K distinct elements 
 * from the set [1..N]. Example:
 * N = 5, K = 2  {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}
 * */
namespace _21_Combination
{
    using System;
    using System.Linq;

    public class Combinations
    {
        public static void Variations(int[] myArray, int index, int n, int currentNum)
        {
            if (index == myArray.Length)
            {
                Print(myArray);
            }
            else
            {
                for (int i = currentNum; i <= n; i++)
                {
                    myArray[index] = i;
                    Variations(myArray, index + 1, n, i + 1);
                }
            }
        }

        public static void Print(int[] myArray)
        {
            Console.Write("{");
            for (int i = 0; i < myArray.Length; i++)
            {
                if (i == myArray.Length - 1)
                {
                    Console.Write(myArray[i]);
                }
                else
                {
                    Console.Write(myArray[i] + ",");
                }
            }

            Console.Write("}");
            Console.WriteLine();
        }

        public static void Main(string[] args)
        {
            Console.Write("N=");
            int n = int.Parse(Console.ReadLine());
            Console.Write("K=");
            int k = int.Parse(Console.ReadLine());
            int[] myArray = new int[k];
            Variations(myArray, 0, n, 1);
        }
    }
}