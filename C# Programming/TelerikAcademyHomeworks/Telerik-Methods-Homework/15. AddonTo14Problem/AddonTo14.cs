/* Modify your last program and try to make 
 * it work for any number type, not just integer 
 * (e.g. decimal, float, byte, etc.). 
 * Use generic method (read in Internet about generic methods in C#).
*/
namespace _15.AddonTo14Problem
{
    using System;
    using System.Linq;

    public class AddonTo14
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Minimal Element is: {0}", Minimal(6, 7, 3, -15, 35, 60));
            Console.WriteLine("Maximal Element is: {0}", Maximal(6, 7, 3, -15, 35, 60));
            Console.WriteLine("The Average is: {0}", Average(6, 7, 3, -15, 35, 60));
            Console.WriteLine("The Sum is: {0}", Sum(6, 7, 3, -15, 35, 60));
            Console.WriteLine("The Product is: {0}", Product(6, 7, 3, -15, 35, 60));
        }

        public static T Minimal<T>(params T[] myArray)
        {
            dynamic min = myArray[0];
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] < min)
                {
                    min = myArray[i];
                }
            }

            return min;
        }

        public static T Maximal<T>(params T[] myArray)
        {
            dynamic max = myArray[0];
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] > max)
                {
                    max = myArray[i];
                }
            }

            return max;
        }

        public static T Average<T>(params T[] myArray)
        {
            dynamic product = Sum(6, 7, 3, -15, 35, 60) / myArray.Length;
            return product;
        }

        public static T Sum<T>(params T[] myArray)
        {
            dynamic sum = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                sum += myArray[i];
            }

            return sum;
        }

        public static T Product<T>(params T[] myArray)
        {
            dynamic product = 1;
            for (int i = 0; i < myArray.Length; i++)
            {
                product *= myArray[i];
            }

            return product;
        }
    }
}