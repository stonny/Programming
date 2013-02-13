using System;

class oddorEven
{
    static void Main()
    {
        string n = "y";
        while (n == "y")
        {
            Console.WriteLine("Enter an integer number:");
            int isOddorEven = int.Parse(Console.ReadLine());
           
            if (isOddorEven%2==0)
            {
                Console.WriteLine("The number {0} is even!",isOddorEven);
            }
            else
            {
                Console.WriteLine("The number {0} is odd!", isOddorEven);
            }
            Console.WriteLine("Do you want to check another number?(y/n)");
            n = Console.ReadLine();
        }

    }
}

