using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shape
{
    /// <summary>
    /// The class target is to create a rectangle figure
    /// </summary>
    class Rectangle : Shape
    {
        // Constructor that sets the width and height by the properties from the class that inherits
        public Rectangle(int width, int height)
            : base(width, height)
        {

        }

        // Overrided method that has different behaviour for this Shape
        public override double CalculateSurface()
        {
            return Width * Height;
        }

    }
}
