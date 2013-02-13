using System;

class findNumbersBetweenInt
{
    static void Main()
    {
        Console.WriteLine("Please enter the first Number:");
        int firstNum = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the second Number:");
        int secNum = int.Parse(Console.ReadLine());
        int count = 0;
        for (int i = firstNum; i <= secNum; i++)
        {
            if (i % 5 == 0)
            {
                count += 1; 
            }
        }
        Console.WriteLine("The amount of Numbers in the interval ({0},{1})\r\nwhich divides by 5 without reminder is: {2}",
                                                           firstNum ,secNum , count );
    }
}


