using System;

class isPointWithinCircle
{
    static void Main()
    {
        int xCircle = 0;
        int yCircle = 5;
        Console.WriteLine("Enter The Following data to check if Point(x,y) is within the circle K(0,5):");
        Console.WriteLine("Enter the X coordinate of the point:");
        int xPoint = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the Y coordinate of the point:");
        int yPoint = int.Parse(Console.ReadLine());
        if ((xPoint < 5) && (yPoint < 5))
        {
            Console.WriteLine("The point({0},{1}) is within the circle K(0,5) !", xPoint, yPoint);
        }
        else
        {
            Console.WriteLine("The point({0},{1}) is NOT within the circle K(0,5) !", xPoint, yPoint);
        }

    }
}

