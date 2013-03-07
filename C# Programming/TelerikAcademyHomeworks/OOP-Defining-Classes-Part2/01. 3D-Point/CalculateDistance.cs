using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Static class
public static class CalculateDistance
{
    // Static method that calculates the distance between 2 points
    public static double GetDistance(Point3D firstPoint, Point3D secondPoint)
    {
        return Math.Sqrt(Math.Pow(firstPoint.xPoint - secondPoint.xPoint, 2) + Math.Pow(firstPoint.yPoint - secondPoint.yPoint, 2));
    }
}

