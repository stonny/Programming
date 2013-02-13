/* Write a program that reads two numbers N and K and generates
 * all the variations of K elements from the set [1..N]. Example:
 *	N = 3, K = 2  {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}
*/
namespace _20.Variations
{
    using System;
    using System.Linq;

    public class Variation
    {
       public static void Variations(int[] myArray, int index, int n)
        {
            if (index == myArray.Length)
            {
                Print(myArray);
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    myArray[index] = i;
                    Variations(myArray, index + 1, n);
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
            Variations(myArray, 0, n);
        }
    }
}
