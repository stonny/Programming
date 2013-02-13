using System;

class countZeros
{
    static void Main()
    {
        Console.WriteLine("Calculates the trailing zeroes in N!");
        Console.Write("Enter N = ");
        int n;
        bool  isNumber = Int32.TryParse(Console.ReadLine(),out n);
        int result = 0;
        if (isNumber)
        {

            for (int i = 5; i <= n; i *= 5)
            {
                result = result + (n / i);
            }
            Console.WriteLine("{0}! -> {1} trailing zeros", n, result);
        }
        else
        {
            Console.WriteLine("Invalid Input !");
        }
    }
}

