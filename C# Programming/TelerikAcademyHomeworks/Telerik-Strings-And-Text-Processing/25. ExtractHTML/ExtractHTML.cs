/* Write a program that extracts from given HTML file its title 
 * (if available), and its body text without the HTML tags. Example:
*/
using System;
/* Write a program that extracts from given HTML file its title
 * (if available), and its body text without the HTML tags. Example:
 */
namespace _25.ExtractHTML
{
    using System.IO;
    using System.Linq;
    using System.Text.RegularExpressions;

    class ExtractHTML
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("..\\..\\test.html"))
            {

                string htmlCode = reader.ReadToEnd();

                string title = Regex.Match(htmlCode, @"(?<=<title>).*(?=</title>)").ToString();
                string bodyTextWithTags = Regex.Match(htmlCode, @"(?<=<body>)(.|\s)*(?=</body>)").ToString();
                MatchCollection bodyText = Regex.Matches(bodyTextWithTags, @"(?<=^|>)[^><]+?(?=<|$)");

                Console.WriteLine("Title: " + title);
                Console.Write("Body:");
                foreach (Match match in bodyText)
                {
                    Console.WriteLine(match.ToString());
                }
            }
        }
    }
}
