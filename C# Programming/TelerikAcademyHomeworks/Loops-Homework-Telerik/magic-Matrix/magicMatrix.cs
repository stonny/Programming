using System;
class magicMatrix
{
    static void Main()
    {
        Console.WriteLine("Enter N [0<N<20]:");
        byte N = byte.Parse(Console.ReadLine());
        int[,]myArray=new int [N,N];
        for (int i = 0; i < N; i++)
        {
            int temp = i + 1;
            for (int k = 0; k < N; k++)
            {
                myArray[i, k] = temp;
                temp++;
            }
        }
        for (int i = 0; i < N; i++)
        {
            for (int k = 0; k < N; k++)
            {

                Console.Write("{0,3}", myArray[i, k]);
            }
            Console.WriteLine();
        }
    }
}
