using System;
using System.Numerics;
//Calculate N!*K! / (K-N)!
class divideProductWithSumOfFactorials
{
    static void Main()
    {
        Console.WriteLine("Calculate N!*K! / (K-N)! (1<N<K)");
        Console.Write("Enter the first number N:");
        BigInteger N = BigInteger.Parse(Console.ReadLine());
        Console.Write("Enter the second number K:");
        BigInteger K= BigInteger.Parse(Console.ReadLine());
        BigInteger result = 1;
            for (int i = 1; i < K + 1; i++)
            {
                if (N > (K - N))
                {
                    result = result * i;
                    if (i < (N + 1))
                    {
                        result = result * i;
                    }
                }
                else if (N < (K - N))
                {
                    if (i <= N)
                    {
                        result = result * i;
                    }
                    if (i > (K - N))
                    {
                        result = result * i;
                    }
                }
                else
                {
                    result = result * i;
                }
            }
            Console.WriteLine("The result is: {0}", result);
       
    }
}