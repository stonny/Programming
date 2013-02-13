// Write a method that reverses the digits of given decimal number. Example: 256 -> 652
namespace _07.ReverseDigits
{
    using System;
    using System.Linq;

    public class ReverseNumber
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            decimal myNumber = decimal.Parse(Console.ReadLine());
            Reversion(myNumber);
        }

        private static void Reversion(decimal myNumber)
        {
            string numberString = myNumber.ToString();
            Console.Write("{0} -> ", myNumber);
            for (int i = numberString.Length - 1; i >= 0; i--)
            {
                Console.Write(numberString[i]);
            }

            Console.WriteLine();
        }
    }
}
