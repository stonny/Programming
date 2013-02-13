/* Write a program that reads a number and prints it as a decimal number,
 * hexadecimal number, percentage and in scientific notation. 
 * Format the output aligned right in 15 symbols.
 * */

namespace _11.NumberInVariousFormats
{
    using System;
    using System.Linq;

    class NumberInVariousFormats
    {
        static void Main(string[] args)
        {
            Console.Write("Input a number: ");
            int myNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Number in Decimal:");
            Console.WriteLine("{0,15:D}", myNumber);
            Console.WriteLine("Number in Hexadecimal");
            Console.WriteLine("{0,15:X}", myNumber);
            Console.WriteLine("Number in Percentage");
            Console.WriteLine("{0,15:P0}", myNumber);
            Console.WriteLine("Number in Scientific");
            Console.WriteLine("{0,15:E2}", myNumber);
        }
    }
}
