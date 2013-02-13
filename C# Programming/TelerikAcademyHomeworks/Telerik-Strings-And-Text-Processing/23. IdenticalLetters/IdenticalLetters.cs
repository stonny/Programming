/* Write a program that reads a string from the console and 
 * replaces all series of consecutive identical letters with a single one. 
 * Example: "aaaaabbbbbcdddeeeedssaa"  "abcdedsa".
*/
using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _23.IdenticalLetters
{
    class IdenticalLetters
    {
        static void Main()
        {
            string text = "aaaaabbbbbcdddeeeedssaa";
            text = Regex.Replace(text, @"(.)\1*", "$1");
            Console.WriteLine(text);
        }
    }
}
