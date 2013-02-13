/* Write a method that returns the last digit of given integer
 * as an English word. Examples: 512  "two", 1024  "four", 12309  "nine".
 */

namespace _03.LastDigitMethod
{
    using System;
    using System.Linq;

    public class LastDigit
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter a number:");
            int number = int.Parse(Console.ReadLine());
            Console.Write("{0} -> ", number);
            LastDigitCheck(number);
        }

        private static void LastDigitCheck(int number)
        {
            int remainder = number % 10;
            switch (remainder)
            {
                case 0: Console.WriteLine("Zero"); 
                    break;
                case 1: Console.WriteLine("One");
                    break;
                case 2: Console.WriteLine("Two"); 
                    break;
                case 3: Console.WriteLine("Three"); 
                    break;
                case 4: Console.WriteLine("Four"); 
                    break;
                case 5: Console.WriteLine("Five"); 
                    break;
                case 6: Console.WriteLine("Six"); 
                    break;
                case 7: Console.WriteLine("Seven"); 
                    break;
                case 8: Console.WriteLine("Eight"); 
                    break;
                case 9: Console.WriteLine("Nine"); 
                    break;
                default: Console.WriteLine("Unknown Error has occured !"); 
                    break;
            }
        }
    }
}
