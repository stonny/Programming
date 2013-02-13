/* Write a program that extracts from a 
 * given text all palindromes, e.g. "ABBA", "lamal", "exe".
 * */

namespace _20.ExtractPalindromes
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    class ExtractPalindromes
    {
        static void Main(string[] args)
        {
            string text = "ABBA hello wazuup dude abcdedcba";
            MatchCollection palindromes = Regex.Matches(text, @"\b(?<N>.)+.?(?<-N>\k<N>)+(?(N)(?!))\b");
            foreach (Match pali in palindromes)
            {
                Console.WriteLine(pali);
            }
        }
    }
}
