
namespace _05.WorkDays
{
    using System;
    using System.Linq;

    public class WorkDays
    {
        public static void Main(string[] args)
        {
            DateTime startDate = DateTime.Today;
            Console.WriteLine("Enter End Date (DD/MM/YYYY)");
            string[] endDateStr = Console.ReadLine().Split('/');
            int day = int.Parse(endDateStr[0]);
            int month = int.Parse(endDateStr[1]);
            int year = int.Parse(endDateStr[2]);
            DateTime endDate = new DateTime(year, month, day);
            Console.WriteLine("Number of work days between the period is: {0}", GetWorkDays(startDate, endDate));
        }
        public static int GetWorkDays(DateTime startDate, DateTime endDate)
        {
            DateTime[] holidays = { new DateTime(2012, 12, 24), new DateTime(2012, 12, 25), new DateTime(2012, 12, 30),
                                   new DateTime(2012, 12, 31), new DateTime(2013, 01, 01) };
            int daysLenght = Math.Abs((endDate - startDate).Days);
            if (startDate > endDate)
            {
                startDate = endDate;
                endDate = DateTime.Today;
            }

            int workDays = 0;
            bool isHoliday = false;
            for (int i = 0; i < daysLenght; i++)
            {
                startDate = startDate.AddDays(1);
                if (startDate.DayOfWeek != DayOfWeek.Saturday && startDate.DayOfWeek != DayOfWeek.Sunday)
                {
                    isHoliday = false;
                    for (int j = 0; j < holidays.Length; j++)
                    {
                        if (startDate == holidays[j])
                        {
                            isHoliday = true;
                            break;
                        }
                    }
                    if (isHoliday == false)
                    {
                        workDays++;
                    }
                }
            }
            return workDays;
        }
    }
}
