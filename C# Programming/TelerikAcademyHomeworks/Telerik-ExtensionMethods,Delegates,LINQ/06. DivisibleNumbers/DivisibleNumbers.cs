/* Write a program that prints from given array of integers
 * all numbers that are divisible by 7 and 3.
 * Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.
 */
using System;
using System.Linq;

class DivisibleNumbers
{
    static void Main(string[] args)
    {
        // Initializing a array with integers
        int[] numberArray = new[]
        {
            5, 6, 2, 7, 21, -48, 36, 42, 56, 63, 28, -21
        };
        // Generating the Lambda Expression
        var divisibleNumbers = numberArray.Where(number => number % 21 == 0);
        // Printing the result
        Console.WriteLine("Numbers divisible by 3 and 7:");
        foreach (var item in divisibleNumbers)
        {
            Console.WriteLine(item);
        }
    }
}

