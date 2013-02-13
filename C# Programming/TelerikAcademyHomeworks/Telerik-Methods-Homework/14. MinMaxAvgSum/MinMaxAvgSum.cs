/* Write methods to calculate
 * minimum, maximum, average, sum and product 
 * of given set of integer numbers. Use variable number of arguments.
*/
namespace _14.MinMaxAvgSum
{
    using System;
    using System.Linq;

    public class MinMaxAvgSum
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Minimal Element is: {0}", Minimal(6, 7, 3, -15, 35, 60));
            Console.WriteLine("Maximal Element is: {0}", Maximal(6, 7, 3, -15, 35, 60));
            Console.WriteLine("The Average is: {0}", Average(6, 7, 3, -15, 35, 60));
            Console.WriteLine("The Sum is: {0}", Sum(6, 7, 3, -15, 35, 60));
            Console.WriteLine("The Product is: {0}", Product(6, 7, 3, -15, 35, 60));
        }

        public static int Minimal(params int[] myArray)
        {
            int min = myArray[0];
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] < min)
                {
                    min = myArray[i];
                }
            }

            return min;
        }

        public static int Maximal(params int[] myArray)
        {
            int max = myArray[0];
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] > max)
                {
                    max = myArray[i];
                }
            }

            return max;
        }

        public static double Average(params int[] myArray)
        {
            return myArray.Average();
        }

        public static int Sum(params int[] myArray)
        {
            int sum = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                sum += myArray[i];
            }

            return sum;
        }

        public static long Product(params long[] myArray)
        {
            long product = 1;
            for (int i = 0; i < myArray.Length; i++)
            {
                product *= myArray[i];
            }

            return product;
        }
    }
}
