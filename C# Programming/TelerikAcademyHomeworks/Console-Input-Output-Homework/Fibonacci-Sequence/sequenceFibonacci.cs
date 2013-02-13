using System;
using System.Numerics;

class sequenceOfFibonacci
{
    static void Main()
    {
        BigInteger  currentNum, firstNum, secNum;

        firstNum = 0;
        secNum = 1;

        Console.WriteLine("The first 100 members of the Fibonacci sequence are: ");
        Console.WriteLine("1->{0}\r\n2->{1} ", firstNum, secNum);

        for (int i = 3; i < 101; i++)
        {
            currentNum  = firstNum  + secNum ;
            firstNum  = secNum ;
            secNum  = currentNum ;

            Console.WriteLine("{0}->{1} ",i, currentNum );
        }
    }
}

