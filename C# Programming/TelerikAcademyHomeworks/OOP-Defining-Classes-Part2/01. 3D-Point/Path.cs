using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Path
{
    // Initializing a List that will hold all the points
    public List<Point3D> pointHolder = new List<Point3D>();

    // Property that only gives value
    public List<Point3D> Paths
    {
        get
        {
            return this.pointHolder;
        }
    }
    // Method that adds more points
    public void AddPoint(Point3D point)
    {
        pointHolder.Add(point);
    }
}

