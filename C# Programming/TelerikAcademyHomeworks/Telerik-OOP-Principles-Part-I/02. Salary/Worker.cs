using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Class worker that will inherit first name and last name 
// from class Human and initializes its own WeekSalary and WorkHoursPerDay
public class Worker : Human
{
    // Properties
    public int WeekSalary { get; protected set; }
    public int WorkHoursPerDay { get; protected set; }

    // Constructor
    public Worker(string firstName, string lastName, int weekSalary, int workHoursPerDay)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.WeekSalary = weekSalary;
        this.WorkHoursPerDay = workHoursPerDay;
    }
    // Method which returns the Money Per Hour value
    public double MoneyPerHour()
    {
        double moneyPerHour = WeekSalary / WorkHoursPerDay;
        return moneyPerHour;
    }
}

