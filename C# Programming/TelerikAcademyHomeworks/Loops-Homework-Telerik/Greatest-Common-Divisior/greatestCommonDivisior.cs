using System;

    class greatestCommonDivisior
    {
        static int greatComDiv(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }
            else
            {
                return greatComDiv(b, a % b);
            }
        }
        static void Main()
        {
            Console.WriteLine("Enter The \"A\" number:");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The \"N\" number:");
            int B = int.Parse(Console.ReadLine());
            Console.WriteLine(greatComDiv(A, B));
        }
    }

