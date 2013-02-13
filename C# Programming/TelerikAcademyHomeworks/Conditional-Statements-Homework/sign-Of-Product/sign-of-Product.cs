using System;


class signProduct
{
    static void Main()
    {
        Console.WriteLine("Enter First Number: ");
        double firstNum = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter Second Number: ");
        double secNum = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter Third Number: ");
        double thirdNum = double.Parse(Console.ReadLine());

        if (firstNum == 0 || secNum == 0 || thirdNum == 0)
        {
            Console.WriteLine("The Product is 0");
        }
        else
        {
            if (Math.Sign(firstNum) * Math.Sign(secNum) * Math.Sign(thirdNum) > 0)
            {
                Console.WriteLine("The Product's sign is [+]!");
            }
            if (Math.Sign(firstNum) * Math.Sign(secNum) * Math.Sign(thirdNum) < 0)
            {
                Console.WriteLine("The Product's sign is [-]!");
            }
        }
      
    }
}

