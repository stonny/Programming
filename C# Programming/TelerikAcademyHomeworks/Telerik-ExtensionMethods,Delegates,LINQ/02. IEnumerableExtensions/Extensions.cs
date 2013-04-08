using System;
using System.Collections.Generic;

// Extennsion class which holds Methods for Product, Sum, Min, Max, Average
public static class IEnumerableExtension
{
    // Method which sums up the elements using dynamic
    public static T Sum<T>(this IEnumerable<T> input) where T : IComparable
    {
        dynamic sum = 0;
        foreach (var item in input)
        {
            sum += item;
        }
        return sum;
    }
    // Method which calculates the Product using dynamic
    public static T Product<T>(this IEnumerable<T> input) where T : IComparable
    {
        dynamic product = 1;
        foreach (var item in input)
        {
            product *= item;
        }
        return product;
    }
    // Method which gets the Minimal element using dynamic
    public static T Min<T>(this IEnumerable<T> input) where T : IComparable
    {
        dynamic min = int.MaxValue;
        foreach (var item in input)
        {
            if (item < min)
            {
                min = item;
            }
        }
        return min;
    }
    // Method which gets the Maximal element using dynamic
    public static T Max<T>(this IEnumerable<T> input) where T : IComparable
    {
        dynamic max = int.MinValue;
        foreach (var item in input)
        {
            if (item > max)
            {
                max = item;
            }
        }
        return max;
    }
    // Method which calculates the Average using dynamic... AGAIN
    public static decimal Average<T>(this IEnumerable<T> input) where T : IComparable
    {
        dynamic sum = 0;
        decimal count = 0;
        foreach (var item in input)
        {
            sum += item;
            count++;
        }
        return sum / count;
    }
}