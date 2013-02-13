using System;


class biggestOfThree
{
    static void Main()
    {
        Console.WriteLine("Enter The First Number: ");
        int firstNum = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter The Second Number: ");
        int secNum = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter The Third Number: ");
        int thirdNum = int.Parse(Console.ReadLine());

        if (firstNum > secNum && firstNum > thirdNum)
        {
            Console.WriteLine("{0} is the Biggest Number!",firstNum);
        }
        else if (firstNum < secNum && secNum > thirdNum)
        {
            Console.WriteLine("{0} is the Biggest Number!", secNum);
        }
        else
        {
            Console.WriteLine("{0} is the Biggest Number!", thirdNum);
        }
    }
}

