using System;


class areaAndPerimeterCircle
{
    static void Main()
    {
        Console.WriteLine("Enter the radius of the circle: ");
        int rCircle = int.Parse(Console.ReadLine());
        Console.WriteLine("The Area of the Circle with radius= {0} is {1}", rCircle,Math.PI*rCircle*rCircle );
        Console.WriteLine("The Perimeter of the Circle with radius= {0} is {1}", rCircle , Math.PI*rCircle*2);
    }
}

