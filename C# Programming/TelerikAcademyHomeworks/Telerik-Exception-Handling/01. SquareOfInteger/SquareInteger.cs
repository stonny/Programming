/* Write a program that reads an integer
 * number and calculates and prints its square root. 
 * If the number is invalid or negative, print "Invalid number". 
 * In all cases finally print "Good bye". Use try-catch-finally.
*/
using System;
using System.Linq;

namespace _01.SquareOfInteger
{
    class SquareInteger
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter integer number:");

            try
            {
                int myNumber = int.Parse(Console.ReadLine());
                if (myNumber < 0)
                {
                    throw new Exception("Negative numbers are not allow for Square Root!");
                }
                Console.WriteLine(Math.Sqrt(myNumber));
            }
           
            catch (OverflowException)
            {
                Console.Error.WriteLine("Invalid number!");
            }
            catch (FormatException)
            {
                Console.Error.WriteLine("Invalid number!");
            }
            catch (ArgumentNullException)
            {
                Console.Error.WriteLine("Invalid number!");
            }
            finally
            {
                Console.WriteLine("Good bye!");
            }
        }
    }
}
