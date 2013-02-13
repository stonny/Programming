// Write a method that adds two polynomials. 
namespace _12.AddonToPolynoms
{
    using System;
    using System.Linq;
    using System.Text;

    public class AddPolynomialsAlg
    {
        public static void Main()
        {
            decimal[] firstPoly = new decimal[] { 4, -2, 1, -1, 1 };
            decimal[] secondPoly = new decimal[] { 6, 1, 4 };
            Console.WriteLine("First polynomial: {0}", PolyToString(firstPoly));
            Console.WriteLine("Second polynomial: {0}", PolyToString(secondPoly));
        }

        public static string PolyToString(decimal[] polynomial)
        {
            StringBuilder returnString = new StringBuilder();

            for (int i = polynomial.Length - 1; i >= 0; i--)
            {
                if (polynomial[i] != 0)
                {
                    returnString.Append(polynomial[i] > 0 ? " + " : " - ");
                    returnString.Append(Math.Abs(polynomial[i]));
                    if (i != 0)
                    {
                        returnString.Append(i > 1 ? "x^" + i : "x");
                    }
                }
            }

            if (returnString[1] != '-')
            {
                returnString.Remove(0, 3);
            }
            else
            {
                returnString.Remove(0, 1);
            }

            return returnString.ToString();
        }
    }
}
