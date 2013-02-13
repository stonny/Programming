using System;

class isPointCircleRect
{
    static void Main()
    {
        Console.WriteLine("Enter the X coordinates of the point (X,y):");
        int pointX = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the Y coordinates of the point (x,Y):");
        int pointY = int.Parse(Console.ReadLine());
        bool inRect = ((pointX > -1 && pointX < 5) && (pointY > -1 && pointY < 1));
        bool inCircle = (pointX - 1) * (pointX - 1) + (pointY - 1) * (pointY - 1) <= 9;
        if (inCircle == true && inRect == false)
        {
            Console.WriteLine("The point ({0},{1}) is within the circle and out of the rectangle", pointX, pointY);
        }
        else
        {
            Console.WriteLine("The point ({0},{1}) is NOT the circle", pointX, pointY);
        }
    }
}
