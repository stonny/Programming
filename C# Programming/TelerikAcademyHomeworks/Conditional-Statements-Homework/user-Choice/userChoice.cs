using System;


class userChoice
{
    static void Main()
    {
        
        Console.WriteLine("Please Pick an Option:");
        Console.WriteLine("1-Integer\r\n2-Double\r\n3-String");
        Console.Write("Input:");
        sbyte userChoice = sbyte.Parse(Console.ReadLine());
        switch (userChoice)
        {
            case 1:
                Console.WriteLine("You have chosen Option 1!");
                Console.WriteLine("Enter an Integer number!");
                int firstOption = int.Parse(Console.ReadLine());
                Console.WriteLine(firstOption + 1);
                break;

            case 2:
                Console.WriteLine("You have chosen Option 2!");
                Console.WriteLine("Enter a Double number!");
                double secondCohise = double.Parse(Console.ReadLine());
                Console.WriteLine(secondCohise + 1);
                break;

            case 3:
                Console.WriteLine("You have chosen Option 3!");
                Console.WriteLine("Enter a String!");
                string thirdCohise = Console.ReadLine();
                Console.WriteLine(thirdCohise + "*");
                break;

            default:
                Console.WriteLine("Invalid input! Please try again!");
                break;
        }

    }
}

