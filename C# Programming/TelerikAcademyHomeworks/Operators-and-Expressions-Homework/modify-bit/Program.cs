using System;

class modifyInt
{
    static void Main()
    {
        Console.Write("Enter an integer number: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter the position of the bit:");
        int p = int.Parse(Console.ReadLine());
        Console.Write("Enter value (0/1): ");
        int v = int.Parse(Console.ReadLine());



            if (v == 0)
            {
                int mask = ~(1 << p);
                int nAndMask = n & mask;
                Console.WriteLine("{0} -> {1}", n, Convert.ToString(n, 2).PadLeft(32, '0'));
                Console.WriteLine("Calculating ...");
                Console.WriteLine("After modification the number is:\n{0}->{1}", nAndMask, Convert.ToString(nAndMask, 2).PadLeft(32, '0'));
            }
            else if (v==1)
            {
                int mask = 1 << p;
                int nAndMask = n | mask;
                Console.WriteLine("{0} -> {1}", n, Convert.ToString(n, 2).PadLeft(32, '0'));
                Console.WriteLine("Calculating ...");
                Console.WriteLine("After modification the number is:\n{0}-> {1}", nAndMask, Convert.ToString(nAndMask, 2).PadLeft(32, '0'));
            }
            else
            {
                Console.WriteLine("Invalid Input! Try again !");
            }

        
    }
}
