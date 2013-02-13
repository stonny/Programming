using System;

class zeroSubset
{
    static void Main()
    {
        Console.WriteLine("Enter First Number");
        int firstNum = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Second Number");
        int sectNum = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Third Number");
        int thirdNum = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Fourth Number");
        int fourthNum = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Fifth Number");
        int fifthNum = int.Parse(Console.ReadLine());
        int sum = 0;
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                for (int k = 0; k < 2; k++)
                {
                    for (int p = 0; p < 2; p++)
                    {
                        for (int q = 0; q < 2; q++)
                        {
                            if ((i != 0) || (j != 0) || (k != 0) || (p != 0) || (q != 0))
                            {
                                sum = firstNum * i + sectNum * j + thirdNum * k + fourthNum * p + fifthNum * q;
                                if (sum == 0)
                                {
                                    Console.WriteLine("At least one subset is zero!");
                                    return;

                                }
                            }
                        }
                    }
                }
            }
        }
    }
}