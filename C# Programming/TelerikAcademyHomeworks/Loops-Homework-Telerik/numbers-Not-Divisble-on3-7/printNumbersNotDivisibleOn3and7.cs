using System;

class printNumbersNotDivisibleOn3and7
{
    static void Main()
    {
        Console.WriteLine("Print Numbers from 1 to N:");
        uint N = uint.Parse(Console.ReadLine());
        for (int i = 1; i < N+1; i++)
        {
            if (i % 3 == 0 && i % 7 == 0)
            {
                continue;
            }
            Console.WriteLine(i);
        }
    }
}

