using System;


class descendingSort
{
    static void Main()
    {
        Console.WriteLine("Enter The First Number: ");
        int firstNum = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter The Second Number: ");
        int secNum = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter The Third Number: ");
        int thirdNum = int.Parse(Console.ReadLine());
        int temp;
        if (secNum > firstNum)
        {
            temp = firstNum;
            firstNum = secNum ;
            secNum  = temp;
            if (thirdNum > secNum )
            {
                temp = thirdNum;
                thirdNum = secNum ;
                secNum  = temp;
            }
            if (secNum  > firstNum)
            {
                temp = firstNum;
                firstNum = secNum ;
                secNum  = temp;
            }
        }
        if (thirdNum > secNum )
        {
            temp = thirdNum;
            thirdNum = secNum ;
            secNum  = temp;
            if (secNum  > firstNum)
            {
                temp = firstNum;
                firstNum = secNum ;
                secNum  = temp;
            }
        }
        Console.WriteLine("Sorting...\r\n The Descended sorting is complete!");
        Console.WriteLine("{0}\r\n{1}\r\n{2}", firstNum, secNum , thirdNum);
    }
}
