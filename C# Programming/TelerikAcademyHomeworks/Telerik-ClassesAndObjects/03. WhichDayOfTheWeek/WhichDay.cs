// Write a program that prints to the console which day of the week is today. Use System.DateTime.

namespace _03.WhichDayOfTheWeek
{
    using System;
    using System.Linq;

    class WhichDay
    {
        static void Main(string[] args)
        {
            DateTime dayOfTheWeek = DateTime.Now;
            Console.WriteLine("Today is: {0} ", dayOfTheWeek.DayOfWeek);
        }
    }
}
