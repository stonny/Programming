using System;

class isGreater
{
    static void Main()
    {
        Console.WriteLine("Enter the First Number:");
        int firstNum = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the Second Number:");
        int secNum = int.Parse(Console.ReadLine());
        int temp;
        if (firstNum > secNum)
        {
            temp = firstNum;
            firstNum = secNum;
            secNum = temp;
            Console.WriteLine("The Greater Number is {0}!",secNum );
        }
        else
        {
            Console.WriteLine("The Greater Number is {0} !",secNum );
        }

    }
}

