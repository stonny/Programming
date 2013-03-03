using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Display
{
    // Fields
    private double? displaySize;
    private double? displayColours;


    // Constructors
    public Display(double? displaySize, double? displayColours)
    {
        this.Size = displaySize;
        this.Colours = displayColours;
    }

    public Display(double? displaySize)
        : this(displaySize, 0)
    {
    }

    // Properties
    public double? Size
    {
        get { return this.displaySize; }
        set
        {
            if (value >= 0 || value == null)
            {
                this.displaySize = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }

    public double? Colours
    {
        get { return this.displayColours; }
        set
        {
            if (value >= 0 || value == null)
            {
                this.displayColours = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}