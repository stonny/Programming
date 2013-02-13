/* Write a method GetMax() with two parameters that
 * returns the bigger of two integers. Write a program that reads 3 integers
 * from the console and prints the biggest of them using the method GetMax().
 */
namespace _02.GetMaxMethod
{
    using System;
    using System.Linq;

    public class GetMaxNumber
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter First Number: ");
            int numberOne = int.Parse(Console.ReadLine());
            Console.Write("Enter First Number: ");
            int numberTwo = int.Parse(Console.ReadLine());
            Console.Write("Enter First Number: ");
            int numberThree = int.Parse(Console.ReadLine());
            int temp;
            temp = GetMax(numberOne, numberTwo);
            Console.WriteLine("The Max number is: {0} !", GetMax(temp, numberThree));
        }

        private static int GetMax(int numOne, int numTwo)
        {
            if (numOne > numTwo)
            {
                return numOne;
            }
            else
            {
                return numTwo;
            }
        }
    }
}
