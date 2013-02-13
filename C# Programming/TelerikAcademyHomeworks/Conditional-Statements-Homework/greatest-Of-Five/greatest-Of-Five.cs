using System;

class greatestOfFive
{
    static void Main()
    {
        int[] arr = new int[5];
        for (int i = 0; i <5; i++)
        {
            Console.WriteLine("Please Enter Number {0}:",i+1);
            arr[i] = int.Parse(Console.ReadLine());
        }
        int max = arr[0];
        for (int i = 0; i <5; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }
        Console.WriteLine("The Greatest Number is {0}",max);
    }
}

