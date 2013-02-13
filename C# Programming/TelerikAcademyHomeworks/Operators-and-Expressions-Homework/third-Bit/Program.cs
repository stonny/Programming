using System;

class findThirdBit
{
    static void Main()
    {
        Console.Write("Enter a number:");
        int num = int.Parse(Console.ReadLine());
        int numBit = (num >> 3);
        int thirdBit = numBit % 2;
        if (thirdBit == 1)
        {
            Console.WriteLine("The third bit is 1");
        }
        else
        {
            Console.WriteLine("The third bit is 0");
        }

    }
}
