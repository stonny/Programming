using System;


class greaterNumber
{
    static void Main()
    {
        Console.WriteLine("Enter the first Number:");
        int firstNum = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second Number:");
        int secNum = int.Parse(Console.ReadLine());
        Console.WriteLine("The greater number is : {0}",Math.Max(firstNum,secNum ));
    }
}

