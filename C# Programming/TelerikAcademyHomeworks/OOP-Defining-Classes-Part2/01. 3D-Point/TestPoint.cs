using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class TestPoint
{
    public static void Main()
    {
        // Instances of a few points to test out the program
        Point3D testPointOne = new Point3D(3, 6, 8);
        Point3D testPointTwo = new Point3D(6, 7, 13);
        Point3D testPointThree = new Point3D(-5, 4, 0);

        // Testing ToString Method
        Console.WriteLine(testPointThree);
        Console.WriteLine(testPointTwo);
        Console.WriteLine(new string('-', 25));

        // Printing the O point
        Console.WriteLine(Point3D.oPoint);
        Console.WriteLine(new string('-', 25));

        // Testing the GetDistance Method
        Console.Write("Distance between \r\n{0} and \r\n{1} is: ", testPointOne, testPointTwo);
        Console.WriteLine(CalculateDistance.GetDistance(testPointOne, testPointTwo));
        Console.WriteLine(new string('-', 25));
        
        // Testing the Add Point Method
        Path pointOption = new Path();
        pointOption.AddPoint(testPointThree);
        pointOption.AddPoint(testPointOne);
        pointOption.AddPoint(testPointOne);
        pointOption.AddPoint(testPointOne);
        pointOption.AddPoint(testPointThree);

        // Printing the Points after Add method
        foreach (var point in pointOption.pointHolder)
        {
            Console.WriteLine(point);
        }

        // Testing Save Method
        PathStorage.SavePath(pointOption);
        Console.WriteLine(new string('-', 25));

        // Testing Load Method
        List<Path> pathList = PathStorage.LoadPath();
        foreach (var path in pathList)
        {
            foreach (var point in pointOption.pointHolder)
            {
                Console.WriteLine(point);
            }
        }   
    }
}

