using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ExceptionTask
{
    class ExceptionTest
    {
        public static void Main()
        {
            Console.WriteLine("to check number press 1, to check date press any key...");
            if (Console.ReadLine() == "1")
            {
                Console.WriteLine("Enter Number: ");
                PrintNumber();
            }
            else
            {
                Console.WriteLine("Enter date in format \" dd/mm/yy \": ");
                PrintDate();
            }
        }

        public static int GetNumber(int min, int max)
        {
            int num = int.Parse(Console.ReadLine());
            if (num < min || num > max)
            {
                throw new ExceptionClass<int>("Int Out Of Range", min, max);
            }
            return num;
        }

        public static void PrintNumber()
        {
            try
            {
                Console.WriteLine("Your number: " + GetNumber(5, 10));
            }
            catch (ExceptionClass<int> ire)
            {
                Console.WriteLine("Exeption Occured! The number is out of range [{0}, {1}].", ire.fromT, ire.toT);
            }
            catch (Exception e)//catch any other exeption
            {
                Console.WriteLine("Exeption Occured! " + e.Message);
            }
        }

        public static DateTime GetDate(DateTime from, DateTime to)
        {
            DateTime date = DateTime.Parse(Console.ReadLine());
            if (date < from || date > to)
            {
                throw new ExceptionClass<DateTime>("Date Out Of Range", from, to);
            }
            return date;
        }

        public static void PrintDate()
        {
            try
            {
                Console.WriteLine("Your date: " + GetDate(new DateTime(2013, 02, 02), new DateTime(2013, 07, 02)));
            }
            catch (ExceptionClass<DateTime> ire)
            {
                Console.WriteLine("Exeption Occured! The date is out of range [{0}, {1}]", ire.fromT, ire.toT);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
