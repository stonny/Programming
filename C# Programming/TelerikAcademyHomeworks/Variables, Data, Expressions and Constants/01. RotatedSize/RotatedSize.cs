﻿using System;
using System.Linq;

namespace _01.RotatedSize
{
    public class RotatedSize
    {
        public static Size GetRotatedSize(Size initialSize, double angleOfRotating)
        {
            double newCosWidthSize = Math.Abs(Math.Cos(angleOfRotating)) * initialSize.Width;
            double newSinHeightSize = Math.Abs(Math.Sin(angleOfRotating)) * initialSize.Height;
            double newSinWidthSize = Math.Abs(Math.Sin(angleOfRotating)) * initialSize.Width;
            double newCosHeightSize = Math.Abs(Math.Cos(angleOfRotating)) * initialSize.Height;
            double fullWidthSize = newCosWidthSize + newSinWidthSize;
            double fullHeightSize = newCosHeightSize + newSinHeightSize;
            Size newSize = new Size(fullWidthSize, fullHeightSize);
            return newSize;
        }

        public static void Main(string[] args)
        {
        }
    }
}
