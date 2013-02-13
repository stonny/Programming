using System;
using System.Numerics;
class fibonacciSequence
{
    static void Main()
    {
        Console.WriteLine("Enter The Amount of Fibonacci Numbers you want to calculate!");
        uint N = uint.Parse(Console.ReadLine());
        BigInteger firstNum=0;
        BigInteger secNum=1;
        BigInteger currentNum=1;
        BigInteger sum = 1 ;
        for (int i = 3; i <= N; i++)
        {
            currentNum = firstNum + secNum;
            firstNum = secNum;
            secNum = currentNum;
            sum += currentNum;
        }
        Console.WriteLine("The Sum is:{0}",sum);
    }
}

