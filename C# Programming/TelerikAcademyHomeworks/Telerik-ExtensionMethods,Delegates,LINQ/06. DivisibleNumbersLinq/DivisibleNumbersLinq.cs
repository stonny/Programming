using System;
using System.Linq;

class DivisibleNumbersLinq
{
    static void Main(string[] args)
    {
        // Initializing a array with integers
        int[] numberArray = new[]
        {
            5, 6, 2, 7, 21, -48, 36, 42, 56, 63, 28, -21
        };
        // Genereting Linq
        var divisbleNumbers =
            from number in numberArray
            where number % 21 == 0
            select number;
        // Prinitng the result
        Console.WriteLine("Numbers divisible by 3 and 7:");
        foreach (var item in divisbleNumbers)
        {
            Console.WriteLine(item);
        }
    }
}

