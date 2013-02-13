/* Write a program that extracts from a given 
 * text all dates that match the format DD.MM.YYYY.
 * Display them in the standard date format for Canada.
*/
namespace _19.ExtractDates
{
    using System;
    using System.Globalization;
    using System.Linq;
    using System.Text.RegularExpressions;

    class ExtractDate
    {
        static void Main(string[] args)
        {
            string text = "Today is 03.02.2013. Tommorow is 04.02.2013.";
            MatchCollection dates = Regex.Matches(text, @"\d\d\.\d\d\.\d\d\d\d");
            foreach (Match date in dates)
            {
                DateTime temp = DateTime.ParseExact(date.ToString(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
                Console.WriteLine(temp.ToString(new CultureInfo("en-CA")));
            }
        }
    }
}
