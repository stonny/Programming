using System;


class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number: ");
        int i = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the position of the bit you want to check: ");
        int b = int.Parse(Console.ReadLine());
        int mask = 1 << b;
        int vAndMask = i & mask;
        int bit = vAndMask >> b;

        Console.WriteLine("The bit at position {0} is: {1} !", b, bit);
    }
}

