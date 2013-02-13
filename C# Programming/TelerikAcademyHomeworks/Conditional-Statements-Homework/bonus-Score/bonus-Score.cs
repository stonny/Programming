using System;

class bonusScores
{
    static void Main()
    {
        Console.WriteLine("Enter a digit (1-9):");
        short digit = short.Parse(Console.ReadLine());
        switch (digit)
        {
            case 1:
            case 2:
            case 3:
                digit *= 10;
                break;
            case 4:
            case 5:
            case 6:
                digit *= 100;
                break;
            case 7:
            case 8:
            case 9:
                digit *= 1000;
                break;
            case 0:
            default:
                Console.WriteLine("Incorrect Input! Try Again!");
                break;
        }
        Console.WriteLine("The new digit is {0}", digit);
    }
}

