/* Write a program for extracting all email addresses 
 * from given text. All substrings that match the format 
 * <identifier>@<host>…<domain> should be recognized as emails.
 */

namespace _18.ExtractEmail
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    class ExtractMail
    {
        static void Main(string[] args)
        {
            string text = "g.georgiev@yahoo.com some textivan.peshkov@gmail.com some text pesho@abv.bg";
            MatchCollection emails = Regex.Matches(text, @"\b\w+(\w|\.|_)*@[a-zA-Z]+\.[a-zA-Z]{2,}?\b");
            foreach (Match email in emails)
            {
                Console.WriteLine(email);
            }
        }
    }
}
