/* You are given a sequence of positive integer 
 * values written into a string, separated by spaces.
 * Write a function that reads these values from given string and calculates their sum. Example:
 * string = "43 68 9 23 318" -> result = 461
*/
namespace _06.SumFromString
{
    using System;
    using System.Linq;

    public class SumFromString
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers separeted with spaces:");
            string[] myNumber = Console.ReadLine().Split(' ');
            int sum = 0;
            for (int i = 0; i < myNumber.Length; i++)
            {
                sum += int.Parse(myNumber[i]);
            }
            Console.WriteLine("The sum is -> {0}", sum);
        }
    }
}
