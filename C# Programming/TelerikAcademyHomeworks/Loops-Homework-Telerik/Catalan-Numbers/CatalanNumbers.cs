using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        Console.WriteLine("Calculate the Nth Catalan Number!");
        Console.WriteLine("Enter N:");
        int N;
        BigInteger divisor=1;
        BigInteger numerator=1;
        bool isNumber = Int32.TryParse(Console.ReadLine(),out N);
        if (isNumber)
        {
            for (int i = 1; i <= N; i++)
            {
                divisor *= i;
            }

            // Numerator
            for (int i = 2 * N; i > N + 1; i--)
            {
                numerator *= i;
            }

            Console.WriteLine("{0}-th Catalan number is: {1}", N, numerator / divisor);
        }
        else
        {
            Console.WriteLine("Invalid Input!");
        }
       

    }
}

