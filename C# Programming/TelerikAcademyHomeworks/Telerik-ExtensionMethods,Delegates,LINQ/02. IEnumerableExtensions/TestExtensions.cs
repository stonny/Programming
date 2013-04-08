 /* Implement a set of extension methods for IEnumerable<T>
  * that implement the following group functions: sum, product, min, max, average.
 */
using System;

class TestExtensions
{
    static void Main(string[] args)
    {
        // Intializing a simple integer array to test out the methods
        int[] testArray = new int[]
        {
            5, 4, 2, 6, 10, 18, 35
        };

        // Testing the 5 extension methods
        Console.WriteLine("The Product is: {0}", testArray.Product());
        Console.WriteLine("The Sum is: {0}", testArray.Sum());
        Console.WriteLine("The Minimal element is: {0}", testArray.Min());
        Console.WriteLine("The Maximal is: {0}", testArray.Max());
        Console.WriteLine("The Average is: {0}", testArray.Average());
    }
}

