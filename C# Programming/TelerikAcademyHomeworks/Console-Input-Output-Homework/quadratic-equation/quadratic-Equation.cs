using System;


class quadraticEquation
{
    static void Main()
    {
        Console.WriteLine("Enter the following coefficients for  ax^2+bx+c=0 (a,b!=0)");
        Console.Write("a=");
        int firstCoef = int.Parse(Console.ReadLine());
        Console.Write("b=");
        int secCoef = int.Parse(Console.ReadLine());
        Console.Write("c=");
        int thirdCoef = int.Parse(Console.ReadLine());
        if (secCoef * secCoef - 4 * firstCoef * thirdCoef < 0)
        {
            Console.WriteLine("No real roots for {0}x^2+{1}x+{2}=0", firstCoef, secCoef, thirdCoef);
        }
        else if (secCoef * secCoef - 4 * firstCoef * thirdCoef == 0)
        {
            Console.WriteLine("There is 1 real root for {0}x^2+{1}x+{2}=0",firstCoef, secCoef ,thirdCoef );
            Console.WriteLine("x1=x2= {0}", -secCoef / 2 * firstCoef);

        }
        else
        {
            Console.WriteLine("There are 2 real roots for {0}x^2+{1}x+{2}=0", firstCoef, secCoef, thirdCoef);
            Console.WriteLine("x1={0}",(-secCoef + Math.Sqrt(secCoef * secCoef - 4 * firstCoef * thirdCoef ))/(2*firstCoef) );
            Console.WriteLine("x2={0}", (-secCoef - Math.Sqrt(secCoef * secCoef - 4 * firstCoef * thirdCoef)) / (2 * firstCoef));
        }
    }
}
