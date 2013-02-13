using System;


class multitudeBits
{
    static void Main()
    {
        uint mask1, mask2;
        Console.Write("n=");
        uint n = uint.Parse(Console.ReadLine());
        Console.Write("k=");
        byte k = byte.Parse(Console.ReadLine());
        Console.Write("p=");
        byte p = byte.Parse(Console.ReadLine());
        Console.Write("q=");
        byte q = byte.Parse(Console.ReadLine());
        for (uint i = 0; i <= k - 1; i++)
        {
            mask1 = 1;
            mask2 = 1;
            mask1 = mask1 << p;
            mask2 = mask2 << q;
            mask1 = mask1 & n;
            mask2 = mask2 & n;
            mask1 = mask1 >> p;
            mask2 = mask2 >> q;
            if (mask1 != mask2)
            {
                if (mask1 == 1)
                {
                    mask2 = 1;
                    mask2 = mask2 << p;
                    mask2 = ~(mask2);
                    n = n & (mask2);
                    mask1 = mask1 << q;
                    n = n | mask1;
                }
                else
                {
                    mask2 = mask2 << p;
                    n = n | mask2;
                    mask1 = 1;
                    mask1 = mask1 << q;
                    mask1 = ~(mask1);
                    n = n & (mask1);
                }
            }
            p++;
            q++;
        }
        Console.WriteLine("The modified number is: {0}", n);
    }

}

