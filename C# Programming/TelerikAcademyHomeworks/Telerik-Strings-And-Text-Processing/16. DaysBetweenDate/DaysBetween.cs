/* Write a program that reads two dates in the format: 
 * day.month.year and calculates the number of days between them. Example:
*/
namespace _16.DaysBetweenDate
{
    using System;
    using System.Globalization;
    using System.Linq;

    class DaysBetween
    {
        static void Main(string[] args)
        {
            Console.Write("Input first date(dd/mm/yyy): ");
            DateTime firstDate = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);
            Console.Write("Input second date(dd/mm/yyy): ");
            DateTime secondDate = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine("Distance: {0}", Math.Abs(secondDate.Subtract(firstDate).TotalDays));
        }
    }
}
