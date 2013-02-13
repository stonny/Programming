/* Write methods that calculate the surface of a triangle by given:
Side and an altitude to it; Three sides; Two sides and an angle between them. Use System.Math.
*/
namespace _04.SurfaceOfTriangle
{
    using System;
    using System.Linq;

    public class SurfaceTriangle
    {
        public static void Menu()
        {
            Console.WriteLine("MENU");
            Console.WriteLine(new string('-', 25));
            Console.WriteLine("Find the Surface of a triangle by:");
            Console.WriteLine("1. Side and an Altitude to it.");
            Console.WriteLine("2. Three sides.");
            Console.WriteLine("3. Two sides and an angle between them.");
            Console.WriteLine(new string('-', 25));
            Console.Write("Choose an option(1-3):");
            sbyte userChoice= sbyte.Parse(Console.ReadLine());
            switch (userChoice)
            {
                case 1: SideAndAltitute();
                    break;
                case 2: ThreeSides();
                    break;
                case 3: TwoSidesAngle();
                    break;
                default: Console.WriteLine("Wrong Input! Please try again !");
                    break;
            }

        }

        public static void SideAndAltitute()
        {
            Console.Write("Enter side of the triangle:");
            double sideTriangle = double.Parse(Console.ReadLine());
            Console.Write("Enter altitude to the side:");
            double altTriangle = double.Parse(Console.ReadLine());
            Console.Write("The Triangle surface is:");
            Console.WriteLine((sideTriangle * altTriangle) / 2);
        }
        public static void ThreeSides()
        {
            Console.Write("Enter first side:");
            double firstSide = double.Parse(Console.ReadLine());
            Console.Write("Enter second side:");
            double secSide = double.Parse(Console.ReadLine());
            Console.Write("Enter thirdside:");
            double thirdSide = double.Parse(Console.ReadLine());
            Console.Write("The Triangle Surface is:");
            double halfPerimeter = (firstSide + secSide + thirdSide) / 2;
            double surfaceTriangle = Math.Sqrt(halfPerimeter * ((halfPerimeter - firstSide) * (halfPerimeter - secSide) * (halfPerimeter - thirdSide)));
            Console.WriteLine(surfaceTriangle);
        }
        public static void TwoSidesAngle()
        {
            Console.Write("Enter first Side:");
            double firstSide = double.Parse(Console.ReadLine());
            Console.Write("Enter second Side:");
            double secSide = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Angle between the sides(in degrees):");
            double angle = double.Parse(Console.ReadLine());
            angle = (angle * Math.PI) / 180;
            Console.WriteLine("The surface ot the triangle is:");
            Console.WriteLine((firstSide*secSide*Math.Sin(angle))/2);
        }
        public static void Main(string[] args)
        {
            Menu();
        }
    }
}
