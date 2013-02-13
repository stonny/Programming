using System;
//Calculate  S = 1 + 1!/X + 2!/X2 + … + N!/XN

class CalculateXandN
{
    static void Main()
    {
        string strNum;
        int n;
        int x;
        decimal factorial = 1M;
        decimal power = 1M;
        decimal sum = 1M;
        Console.WriteLine("Calculate  S = 1 + 1!/X + 2!/X2 + … + N!/XN");
        do
        {
            Console.Write("Enter N:");
        }
        while (!int.TryParse(strNum = Console.ReadLine(), out n));

        do
        {
            Console.Write("Enter X:");
        }
        while (!(int.TryParse(strNum = Console.ReadLine(), out x)) || x == 0);

        if (n == 0)
        {
            sum += 1M / (decimal)x; 
        }
        else
        {
            for (int i = 1; i <= n; i++)
            {
                factorial *= (decimal)i;
                power *= (decimal)x;
                sum += factorial / power;
            }
        }
        Console.WriteLine("For n={0}, x={1} the sum is: {2}", n, x, sum);
    }
}

