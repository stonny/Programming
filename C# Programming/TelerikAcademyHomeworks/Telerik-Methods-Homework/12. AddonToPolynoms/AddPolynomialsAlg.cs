namespace _12.AddonToPolynoms
{
    /*
  *  11.Write a method that adds two polynomials. 
  *  Represent them as arrays of their coefficients as in the example below:
  *
  *  x^2 + 5 = 1x^2 + 0x + 5 -> 5 0 1
  *  
  *  12.Extend the program to support also subtraction and multiplication of polynomials.
  */

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
            decimal[] sum = AddPoly(firstPoly, secondPoly);
            Console.WriteLine("Sum: {0} ", PolyToString(sum));
            decimal[] substr = SubstrPoly(firstPoly, secondPoly);
            Console.WriteLine("Substraction: {0} ", PolyToString(substr));
            decimal[] multiply = MultiplyPoly(firstPoly, secondPoly);
            Console.WriteLine("Multiplication: {0} ", PolyToString(multiply));
        }

        private static decimal[] MultiplyPoly(decimal[] first, decimal[] second)
        {
            decimal[] result = new decimal[first.Length + second.Length];

            for (int i = 0; i < first.Length; i++)
            {
                for (int y = 0; y < second.Length; y++)
                {
                    result[i + y] = result[i + y] + (first[i] * second[y]);
                }
            }

            return result;
        }

        private static decimal[] SubstrPoly(decimal[] first, decimal[] second)
        {
            decimal[] newPolynomial = new decimal[Math.Max(first.Length, second.Length)];

            for (int i = 0; i < first.Length; i++)
            {
                newPolynomial[i] = first[i];
            }

            for (int i = 0; i < second.Length; i++)
            {
                newPolynomial[i] = newPolynomial[i] - second[i];
            }

            return newPolynomial;
        }

        private static decimal[] AddPoly(decimal[] first, decimal[] second)
        {
            decimal[] newPolynomial = new decimal[Math.Max(first.Length, second.Length)];

            for (int i = 0; i < first.Length; i++)
            {
                newPolynomial[i] = first[i];
            }

            for (int i = 0; i < second.Length; i++)
            {
                newPolynomial[i] = newPolynomial[i] + second[i];
            }

            return newPolynomial;
        }

        private static string PolyToString(decimal[] polynomial)
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
