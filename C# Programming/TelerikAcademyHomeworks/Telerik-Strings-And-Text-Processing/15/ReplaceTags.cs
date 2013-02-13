/* Write a program that replaces in a HTML document given 
 * as string all the tags <a href="…">…</a> with corresponding 
 * tags [URL=…]…/URL]. Sample HTML fragment:
*/
namespace _15ReplaceTags
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    class ReplaceTags
    {
        static string Replace(string htmlCode)
        {
           string temp = Regex.Replace(htmlCode,"(<a href=\")((\\w|\\.|:|/)*)(\">)","[URL=$2]");
           return Regex.Replace(temp, "</a>", "[/URL]");
        }
        static void Main()
        {
            string htmlCode = "<p>Please visit <a href=\"http://academy.telerik.com\">our site</a>"+ 
                " to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";
            Console.WriteLine(Replace(htmlCode));

        }
        
    }
}
