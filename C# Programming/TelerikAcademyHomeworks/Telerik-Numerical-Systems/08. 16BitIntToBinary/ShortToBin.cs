/* Write a program that shows the binary
 * representation of given 16-bit signed integer number (the C# type short).
*/
namespace _08._16BitIntToBinary
{
    using System;
    using System.Linq;

    public class ShortToBin
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter 16 bit number: ");
            short myNumber = short.Parse(Console.ReadLine());
            short sign = myNumber;

            if (sign <= 0)
            {
                myNumber = (short)(myNumber + 1); 
            }

            Console.Write("Number in binary:");

            for (int i = 15; i >= 0; i--)
            {
                short exponent = (short)Math.Pow(2, i);
                short digit = (short)(myNumber / exponent);
                myNumber = (short)(myNumber % exponent);

                if (sign < 0) 
                { 
                    Console.Write(1 + digit);
                }
                else 
                { 
                    Console.Write(digit); 
                }
            }
            Console.WriteLine();
        }
    }
}
