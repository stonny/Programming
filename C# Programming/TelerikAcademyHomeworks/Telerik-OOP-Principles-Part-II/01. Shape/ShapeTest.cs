using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shape
{
    /// <summary>
    /// Class target is to test the current classes
    /// </summary>
    class ShapeTest
    {
        static void Main(string[] args)
        {
            // Creating new instances of the objects
            Shape testTriangle = new Triangle(5, 3);
            Shape testRectangle = new Rectangle(4, 2);
            Shape testCircle = new Circle(2, 3);


            // Writing to the console the test results
            Console.Write("Surface Area of Circle is:");
            Console.WriteLine(testCircle.CalculateSurface());
            Console.Write("Surface Area of Rectangle is:");
            Console.WriteLine(testRectangle.CalculateSurface());
            Console.Write("Surface Area of Triangle is:");
            Console.WriteLine(testTriangle.CalculateSurface());
        }
    }
}
