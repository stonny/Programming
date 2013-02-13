using System;

class digitName
{
    static void Main()
    {
        Console.WriteLine("Please Enter Digit:(0-9)");
        byte digit = byte.Parse(Console.ReadLine());
        Console.Write("{0}->",digit);
        switch (digit)
        {
            case 0:
                Console.WriteLine("Zero");
                break;
            case 1: 
                Console.WriteLine("One"); 
                break;
            case 2: 
                Console.WriteLine("Two");
                break;
            case 3:
                Console.WriteLine("Three");
                break;
            case 4:
                Console.WriteLine("Four");
                break;
            case 5:
                Console.WriteLine("Five");
                break;
            case 6:
                Console.WriteLine("Six");
                break;
            case 7:
                Console.WriteLine("Seven");
                break;
            case 8: 
                Console.WriteLine("Eight");
                break;
            case 9:
                Console.WriteLine("Nine");
                break;
            default:
                Console.WriteLine("Incorrect Input!Try Again !");
                break;
        }
    }
}

