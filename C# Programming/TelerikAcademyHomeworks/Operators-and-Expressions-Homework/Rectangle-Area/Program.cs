using System;


class recArea
{
    static void Main()
    {
        Console.WriteLine("Enter the width of the Rectangle: ");
        double widthRec = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the height of the Rectangle: ");
        double heightRec = double.Parse(Console.ReadLine());
        double recArea = widthRec*heightRec;
        Console.WriteLine("The Area of the Rectangle is: {0}",recArea);
    }
}

