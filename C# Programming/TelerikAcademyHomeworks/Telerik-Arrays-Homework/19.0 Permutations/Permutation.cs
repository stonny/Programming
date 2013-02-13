/* * Write a program that reads a number N 
 * and generates and prints all the permutations
 * of the numbers [1 … N]. Example:
 *	n = 3  {1, 2, 3}, {1, 3, 2}, {2, 1, 3}, {2, 3, 1}, {3, 1, 2}, {3, 2, 1}
*/
namespace _19._0_Permutations
{
    using System;
    using System.Linq;

    public class Permutation
    {
        public static void Main(string[] args)
        {
            Console.Write("N=");
            int n = int.Parse(Console.ReadLine());
            int size = n + 1;
            int[] myArray = new int[size];
            bool[] used = new bool[size];
            Permute(myArray, used, 0, n, size);
        }

        public static void Print(int[] myArray, int n)
        {
            Console.Write("{");
            for (int i = 0; i < n; i++)
            {
                if (i == n - 1)
                {
                    Console.Write(myArray[i]);
                }
                else
                {
                    Console.Write(myArray[i] + ", ");
                }
            }

            Console.Write("}");
            Console.WriteLine();
        }

        public static void Permute(int[] myArray, bool[] used, int i, int n, int size)
        {
            if (i == n)
            {
                Print(myArray, n);
            }

            for (int k = 1; k < size; k++)
            {
                if (used[k] == false)
                {
                    used[k] = true;
                    myArray[i] = k;
                    Permute(myArray, used, i + 1, n, size);
                    used[k] = false;
                }
            }
        }
    }
}
