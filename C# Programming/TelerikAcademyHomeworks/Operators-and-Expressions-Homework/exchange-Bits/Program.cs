using System;


class exchangeBits
{
    static void Main()
    {
        Console.WriteLine("Enter uint:");
        uint n = uint.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
        uint thirdBit = (1 << 3) & n;// Gets the third bit
        uint fourthBit = (1 << 4) & n;//Gets the fourth bit
        uint fifthBit = (1 << 5) & n;// Gets the fifth Bit
        uint twfrBit = (1 << 24) & n;// Gets the 24 Bit
        uint twfvBit = (1 << 25) & n;// Gets the 25 Bit
        uint twsxBit = (1 << 26) & n;// Gets the 26 Bit
        // Checks if every bit is 0 or 1 and swaps
        if (thirdBit  == 0)
        {
            n = (uint)(~(1 << 24) & n);
        }
        else
        {
            n = (1 << 24) | n;
        }
        if (fourthBit == 0)
        {
            n = (uint)(~(1 << 25) & n);
        }
        else
        {
            n = (1 << 25) | n;
        }
        if (fifthBit  == 0)
        {
            n = (uint)(~(1 << 26) & n);
        }
        else
        {
            n = (1 << 26) | n;
        }
        if (twfrBit == 0)
        {
            n = (uint)(~(1 << 3) & n);
        }
        else
        {
            n = (1 << 3) | n;
        }
        if (twfvBit  == 0)
        {
            n = (uint)(~(1 << 4) & n);
        }
        else
        {
            n = (1 << 4) | n;
        }
        if (twsxBit  == 0)
        {
            n = (uint)(~(1 << 5) & n);
        }
        else
        {
            n = (1 << 5) | n;
        }
        Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
    }
}

