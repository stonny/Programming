/* Write a program that finds all prime numbers
 * in the range [1...10 000 000].
 * Use the sieve of Eratosthenes algorithm (find it in Wikipedia).
*/
namespace _15._0_SieveOfEratosthenes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SieveOfEratosthenes
    {
        public static void Main(string[] args)
        {
            bool[] myArray = new bool[10000000];
            for (int i = 2; i < Math.Sqrt(10000000); i++)
            {
                if (myArray[i] == false)
                {
                    for (int j = i * i; j < 10000000; j += i)
                    {
                        myArray[j] = true;
                    }
                }
            }

            for (int i = 2; i < 10000000; i++)
            {
                if (myArray[i] == false)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}