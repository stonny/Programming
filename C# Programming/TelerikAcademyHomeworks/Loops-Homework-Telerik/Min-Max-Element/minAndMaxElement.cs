using System;

class minAndMaxElement
{
    static void Main()
    {
        
        Console.WriteLine("Please Enter The Size Of The Sequence You Wish to Input:");
        int N=int.Parse(Console.ReadLine());
        int[] myArray = new int[N];
        for (int i = 0; i < N; i++)
        {
            Console.WriteLine("Enter Element {0}:",i);
            myArray[i] = int.Parse(Console.ReadLine());
        }
        int maxNumber = myArray[0];
        int minNumber = myArray[1];
        for (int i = 0; i < N; i++)
        {
            if (maxNumber < myArray[i])
            {
                maxNumber = myArray[i];
            }
            else
            {
                minNumber = myArray[i];
            }
        }
        Console.WriteLine("The Minimal Element of the Sequence is:{0}",minNumber);
        Console.WriteLine("The Max Element of the Sequence is:{0}", maxNumber);
    }
}

