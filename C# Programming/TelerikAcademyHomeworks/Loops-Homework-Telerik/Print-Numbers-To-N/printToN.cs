using System;

class printToN
{
    static void Main()
    {
        Console.WriteLine("Please Enter How Much Numbers You Want To Print On The Console:");
        uint N = uint.Parse(Console.ReadLine());
        for (int i = 1; i < N+1; i++)
        {
            Console.WriteLine(i);
        }
    }
}

