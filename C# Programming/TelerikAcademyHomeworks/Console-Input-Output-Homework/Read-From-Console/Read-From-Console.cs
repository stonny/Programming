using System;


class readConsole
{
    static void Main()
    {
        Console.WriteLine("Enter First Number: ");
        int firstNum = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter First Number: ");
        int secNum = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter First Number: ");
        int thirdNum = int.Parse(Console.ReadLine());
        Console.WriteLine("The Sum of {0}+ {1}+ {2}= {3}" , firstNum, secNum , thirdNum,firstNum+secNum+thirdNum);
    }
}

