// Write a program to convert decimal numbers to their hexadecimal representation.

namespace _03.DecimalToHex
{
    using System;

    public class DecToHex
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a decimal number:");
            try
            {
                int myNumber = int.Parse(Console.ReadLine());
                ConvertToHex(myNumber);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Input Data!");
            }
        }

        public static void ConvertToHex(int myNumber)
        {
            string result = string.Empty;
            while (myNumber > 0)
            {
                int remainder = myNumber % 16;
                switch (remainder)
                {
                    case 10: result = "A" + result;
                        break;
                    case 11: result = "B" + result;
                        break;
                    case 12: result = "C" + result;
                        break;
                    case 13: result = "D" + result;
                        break;
                    case 14: result = "E" + result;
                        break;
                    case 15: result = "F" + result;
                        break;
                    default: result = (myNumber % 16) + result;
                        break;
                }

                myNumber /= 16;
            }

            Console.WriteLine(result);
        }
    }
}
