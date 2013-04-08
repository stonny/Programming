using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Test
{
    /* Define abstract class Human with first name and last name.
     * Define new class Student which is derived from Human and has new field 
     * – grade. Define class Worker derived from Human with new property WeekSalary
     * and WorkHoursPerDay and method MoneyPerHour() that returns money earned by hour
     * by the worker. Define the proper constructors and properties for this hierarchy.
     * Initialize a list of 10 students and sort them by grade in ascending order
     * (use LINQ or OrderBy() extension method). Initialize a list of 10 workers and
     * sort them by money per hour in descending order. Merge the lists and sort them by first name and last name.
    */
    static void Main(string[] args)
    {
        // Initializing Array with students
        List<Student> studentList = new List<Student>()
        {
            new Student("Ivan", "Georgiev", 5.50), 
            new Student("Pesho", "Ivanov", 4.50), 
            new Student("Grigo", "Leshperov", 6), 
            new Student("Canka", "Petkova", 5.50), 
            new Student("Ivan", "Murdjev", 3.50), 
            new Student("Luben", "Smekov", 5.50), 
            new Student("Nikolay", "Georgiev", 2.50), 
            new Student("Georgi", "Georgiev", 5.50),
            new Student("Svetlin", "Nakov", 6.00),
            new Student("Keremid", "Shpokov", 4.50)
        };
        // Sorting in ascending order by grade
            var sortedByGrade = studentList.OrderBy(x => x.Grade);
        // Printing on the console the sorted List
            foreach (var item in sortedByGrade)
            {
                Console.WriteLine("{0} {1} {2}", item.FirstName, item.LastName, item.Grade);
            }
            Console.WriteLine(new string('-',35));
        // Initializing workers List
            List<Worker> workerList = new List<Worker>()
        {
            new Worker("Ivan", "Georgiev", 250, 6), 
            new Worker("Pesho", "Ivanov", 150, 4), 
            new Worker("Grigo", "Leshperov", 180, 5), 
            new Worker("Canka", "Petkova", 130, 3), 
            new Worker("Ivan", "Murdjev", 260, 8), 
            new Worker("Luben", "Smekov", 385, 9), 
            new Worker("Nikolay", "Georgiev", 120, 2), 
            new Worker("Georgi", "Georgiev", 260, 8),
            new Worker("Svetlin", "Nakov", 150, 4),
            new Worker("Keremid", "Shpokov", 250, 6)
        };
        // Sorting by Money Per Hour
            var sortedByMoneyPerHour = workerList.OrderBy(x => x.MoneyPerHour());
        // Merging both Lists
            List<dynamic> mergedList = new List<dynamic>();
            foreach (var item in studentList)
            {
                mergedList.Add(item);
            }

            foreach (var item in workerList)
            {
                mergedList.Add(item);
            }
        // Sorting by First and Last Name with LINQ
            var sortedMerged = from item in mergedList
            orderby item.FirstName, item.LastName
            select item;
        // Printing on the Console
            foreach (var item in sortedMerged)
            {
                Console.WriteLine("{0} {1}",item.FirstName, item.LastName);
            }
        }
}

