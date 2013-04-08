using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shape
{
    /// <summary>
    /// Class target is to create a Triangle figure
    /// </summary>
    class Triangle :  Shape
    {
        // Constructor that sets the width and height by the properties from the class that inherits
        public Triangle(int width, int height)
            : base(width,height)
        {
        }

        // Overrided method that has different behaviour for this Shape
        public override double CalculateSurface()
        {
            return (Height * Width) / 2;
        }

    }
}
