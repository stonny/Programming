/* Write a program to convert decimal 
 * numbers to their binary representation.
*/
namespace _01.DecimalToBinary
{
    using System;
    using System.Linq;

    public class DecimalToBin
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a decimal number:");
            try
            {
                int myNumber = int.Parse(Console.ReadLine());
                ConvertToBin(myNumber);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Input Data!");
            }
        }

        public static void ConvertToBin(int myNumber)
        {
            string result = string.Empty;
            while (myNumber > 0)
            {
                result = (myNumber % 2) + result;
                myNumber /= 2;
            }

            Console.WriteLine(result);
        }
    }
}