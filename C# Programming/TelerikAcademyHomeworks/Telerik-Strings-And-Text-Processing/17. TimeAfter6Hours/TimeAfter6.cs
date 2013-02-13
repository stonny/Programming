/* Write a program that reads a date and 
 * time given in the format:
 * day.month.year hour:minute:second 
 * and prints the date and time after 6 hours and 30 minutes
 * (in the same format) along with the day of week in Bulgarian
 * */
namespace _17.TimeAfter6Hours
{
    using System;
    using System.Globalization;
    using System.Linq;

    class TimeAfter6
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Input a date in format day.month.year hour:minute:second");
            // string date = Console.ReadLine();
            string date = "1.02.2012 21:14:13";
            DateTime inputDate = DateTime.ParseExact(date, "d.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            inputDate = inputDate.AddHours(6);
            inputDate = inputDate.AddMinutes(30);
            Console.WriteLine(inputDate.ToString("d.MM.yyyy HH:mm:ss dddd", new CultureInfo("bg-BG")));
        }
    }
}
