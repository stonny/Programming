using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shape
{
    /// <summary>
    /// Class targe is to create a Circle figure
    /// </summary>
    class Circle : Shape
    {
        // Constructor that sets the width and height by the properties from the class that inherits
        public Circle(int width, int height)
            : base(width, width)
        {

        }

        // Overrided method that has different behaviour for this Shape
        public override double CalculateSurface()
        {
            return Math.PI * Width;
        }
    }
}
