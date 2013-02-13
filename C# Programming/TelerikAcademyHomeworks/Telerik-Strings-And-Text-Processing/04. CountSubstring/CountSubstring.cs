/* Write a program that finds how many times a substring 
 * is contained in a given text (perform case insensitive search).
*/
namespace _04.CountSubstring
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    class CountSubstring
    {
        static void Main(string[] args)
        {
            string textToTest =
                   "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            textToTest.ToLower();
            Console.WriteLine("Enter the substring you want to count:");
            string searchString = Console.ReadLine();
            searchString.ToLower();
            int count = Regex.Matches(textToTest, searchString, RegexOptions.IgnoreCase).Count;

            Console.WriteLine(count);
            
        }
    }
}
