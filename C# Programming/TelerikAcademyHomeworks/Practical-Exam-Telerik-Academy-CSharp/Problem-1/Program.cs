using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextDate
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            bool isVisokosna=false;
            bool isFullMonth=false;

            // is the year Visokosna
            if (year%4==0)
            {
                isVisokosna = true;
            }
            else
            {
                isVisokosna = false;
            }
            // is the Month Full
            if (month==1||month==3||month==5|| month==7 ||month==8||month==10||month==12)
            {
                isFullMonth = true;
            }
            else
            {
                isFullMonth = false;
            }
            //calculation
            if (month == 12 && day == 31)
            {
                year++;
                day = 1;
                month = 1;
            }
            else
            {
                if (month == 2)
                {
                    if (isVisokosna == false && day == 28)
                    {
                        day = 1;
                        month++;
                    }
                    else if (isVisokosna = true && day == 29)
                    {
                        day = 1;
                        month++;
                    }
                    else
                    {
                        day++;
                    }
                }
                else
                {

                    if (day == 30 && isFullMonth == false)
                    {
                        day = 1;
                        month++;
                    }
                    else if (day == 31 && isFullMonth == true)
                    {
                        day = 1;
                        month++;
                    }
                    else
                    {
                        day++;
                    }
                }

            }
            //output
            Console.WriteLine(day+"."+month+"."+year);
        }
    }
}
