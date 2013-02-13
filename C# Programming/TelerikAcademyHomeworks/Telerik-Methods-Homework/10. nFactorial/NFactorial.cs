/* Write a program to calculate n! for 
 * each n in the range [1..100]. 
 * Hint: Implement first a method that multiplies a
 * number represented as array of digits by given integer number. 
*/
namespace _10.NFactorial
{
    using System;
    using System.Numerics;

    public class NFactorial
    {
        public static void Main()
        {
            int[] myArray = new int[100];

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = i + 1;
            }

            FactorialN(myArray);
        }

        public static void FactorialN(int[] myArray)
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                BigInteger factorial = Factorial(i);
                Console.WriteLine("{0}! -> {1}", i, factorial);
            }
        }

        public static BigInteger Factorial(int i)
        {
            BigInteger factorial = i;
            while (i > 0)
            {
                factorial *= i;
                i--;
            }

            return factorial;
        }
    }
}
