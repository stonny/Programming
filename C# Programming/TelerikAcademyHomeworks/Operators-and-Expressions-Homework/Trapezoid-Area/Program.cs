using System;


class recArea
{
    static void Main()
    {
        Console.WriteLine("Enter the side of the Trapezoid: ");
        double sideOne = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the other side of the Trapezoid: ");
        double sideTwo = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the height of the Trapezoid: ");
        double height = double.Parse(Console.ReadLine());
        double trapArea = ((sideOne + sideTwo) / 2) * height;
        Console.WriteLine("The Area of the Trapezoid is: {0}", trapArea);
    }
}

