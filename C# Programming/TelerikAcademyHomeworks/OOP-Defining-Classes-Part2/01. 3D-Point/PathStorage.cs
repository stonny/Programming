using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public static class PathStorage
{
    // Method that saves current paths to a text file
    public static void SavePath(Path path)
    {
        // Setting the location of the file that will hold the Points
        using (StreamWriter writer = new StreamWriter(@"../../SavedPaths.txt"))
        {
            // Writing to the file
            foreach (var point in path.pointHolder)
            {
                writer.WriteLine(point);
            }
        }
    }

    // Static method that loads Points from a file
    public static List<Path> LoadPath()
    {
        Path loadPath = new Path();
        List<Path> pathsLoaded = new List<Path>();
        // Setting the path of the file from which will be loaded Points
        using (StreamReader reader = new StreamReader(@"../../PathLoader.txt"))
        {
            // Reading lines while we reach a non empty line
            string line = reader.ReadLine();
            while (line != null)
            {
                    // Spliting the string and assigning each value to its representive coordinates in the structure Point
                    Point3D point = new Point3D();
                    string[] points = line.Split(',');
                    point.xPoint = int.Parse(points[0]);
                    point.yPoint = int.Parse(points[1]);
                    point.zPoint = int.Parse(points[2]);
                    // After assigning the values we create a new point and add it to the List
                    loadPath.AddPoint(point);
                    // Continue reading from the file
                    line = reader.ReadLine();
            }
        }
        pathsLoaded.Add(loadPath);
        return pathsLoaded;
    }
}

