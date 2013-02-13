using System;

class findBitAtP
{
    static void Main()
    {
        Console.WriteLine("Enter a number: ");
        int v = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the position of the bit you want to check: ");
        int p = int.Parse(Console.ReadLine());
        int mask = 1 << p;
        int vAndMask = v & mask;
        bool value= true;
        if (vAndMask >> p == 0)
        {
             value = false;
        }

        Console.WriteLine("Does the bit at position {0} have a value of 1 ?-> {1}",p,value);
    }
}

