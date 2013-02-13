/* Write a method ReadNumber(int start, int end) 
 * that enters an integer number in given range [start…end].
 * If an invalid number or non-number text is entered,
 * the method should throw an exception.
 * Using this method write a program that enters 10 numbers:
 * a1, a2, … a10, such that 1 < a1 < … < a10 < 100
*/
namespace _02.NumbersInRange
{
    using System;
    using System.Linq;

    class NumbersInRange
    {
        static void Main(string[] args)
        {
            Console.Write("Enter start range:");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Enter end range:");
            int end = int.Parse(Console.ReadLine());
            ReadNumber(start, end);
        }
        static void ReadNumber(int start, int end)
        {
            Console.WriteLine("Please Enter a number in range [{0}, {1}]:", start, end);
            try
            {
                int myNumber = int.Parse(Console.ReadLine());
                if (myNumber < start || myNumber > end)
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
