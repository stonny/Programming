using System;


class printNnumbers
{
    static void Main()
    {
        Console.WriteLine("Enter the amount of numbers you want to input: ");
        Console.Write("n=");
        int n=int.Parse(Console.ReadLine());
        int sum = 0;
        int sumInput;
        for (uint i = 1; i <=n; i++)
        {
            Console.Write("Enter number [{0}]: ",i);
            sumInput=int.Parse(Console.ReadLine());
            sum += sumInput;
        }
        Console.WriteLine("The Sum of all the numbers you have entered is: {0}", sum);
    }
}

