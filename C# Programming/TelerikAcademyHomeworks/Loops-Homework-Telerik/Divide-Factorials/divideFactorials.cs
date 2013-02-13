using System;
using System.Numerics;

class divideFactorials
{
    static void Main()
    {
        Console.WriteLine("Divide Factorial Of N and Factorial Of K! (1<K<N)");
        Console.WriteLine("Enter N:");
        BigInteger N = BigInteger.Parse(Console.ReadLine());
        Console.WriteLine("Enter K:");
        BigInteger K = BigInteger.Parse(Console.ReadLine());
        BigInteger result = 1;
        BigInteger temp = 1;
        for (BigInteger i = (K + 1); i <= N; i++)
        {
            result = temp * i;
            temp = result;
        }
        Console.WriteLine("The Result is: {0} ",result);
    }
}

