// Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.

namespace _01.IsLeapYear
{
    using System;
    using System.Linq;

    class IsLeapYear
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a year to check if it is Leap:");
            Console.Write("Year=");
            ushort myYear = ushort.Parse(Console.ReadLine());
            Console.WriteLine("Is The Year {0} Leap -> {1}", myYear, DateTime.IsLeapYear(myYear));
        }
    }
}
