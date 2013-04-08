using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _01.Shape
{
    /// <summary>
    /// The target of the class is to create a Shape with width and height
    /// </summary>
    public abstract class Shape
    {
        // Fields initializing the width and height
        public int Width{ get; protected set; }
        public int Height { get; protected set; }

        // Constructor that sets values to the width and height
        protected Shape(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }

        // Virtual Method that can  be overriden by its child classes
        public virtual double CalculateSurface()
        {
            return 0;
        }
    }
}
