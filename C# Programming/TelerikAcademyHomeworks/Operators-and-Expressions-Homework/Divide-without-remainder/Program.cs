using System;
class Divide
{
    static void Main()
    {
       
        bool isRemainder;
        string n="y";
       
        while (n == "y")
        {
            Console.WriteLine("Input a number: ");
            int numberOne = int.Parse(Console.ReadLine());
            if ((numberOne % 5 == 0) && (numberOne % 7 == 0))
            {
                isRemainder = true;
            }
            else
            {
                isRemainder = false;
            }
            Console.WriteLine("Can the number {0} be divided by 5 and 7 without Remainder? -> {1}", numberOne, isRemainder);
            Console.WriteLine("Do you want to check another number?(y/n)");
            n = Console.ReadLine();
        }
    }
}

