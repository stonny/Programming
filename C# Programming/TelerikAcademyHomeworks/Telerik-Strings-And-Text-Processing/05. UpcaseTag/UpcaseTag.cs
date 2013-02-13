/* You are given a text. 
 * Write a program that changes the text in all regions 
 * surrounded by the tags <upcase> and </upcase> to uppercase. 
 * The tags cannot be nested
 * */

namespace _05.UpcaseTag
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    class UpcaseTag
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Please enter text:");
            // string textToProcess = Console.ReadLine();
            string textToProcess = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
            int posTagOpen = 0;
            int posTagClose = 0;

            Console.WriteLine(Regex.Replace(textToProcess, "<upcase>(.*?)</upcase>", m => m.Groups[1].Value.ToUpper()));
        }
    }
}
