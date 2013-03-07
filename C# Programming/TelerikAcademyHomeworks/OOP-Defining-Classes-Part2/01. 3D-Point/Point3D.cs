using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Structure that holds the coordinates of a 3D Point
// and prints the information afterwards
public struct Point3D
{
    // Values of the points
    public int xPoint { get; set; }
    public int yPoint { get; set; }
    public int zPoint { get; set; }

    // Private readonly field to hold the point O
    public static readonly Point3D oPoint = new Point3D(0, 0, 0);

    // Constructor that creates a new Point
    public Point3D(int xPoint, int yPoint, int zPoint)
        : this()
    {
        this.xPoint = xPoint;
        this.yPoint = yPoint;
        this.zPoint = zPoint;
    }

    // Static property for the oPoint
    public static Point3D OCoordinate()
    {
        return oPoint;
    }

    // ToString method to print the information about the point that is created
    public override string ToString()
    {
        StringBuilder printText = new StringBuilder();
        printText.AppendFormat("Point with Coordinates [{0},{1},{2}]", this.xPoint, this.yPoint, this.zPoint);
        return printText.ToString();
    }
}


