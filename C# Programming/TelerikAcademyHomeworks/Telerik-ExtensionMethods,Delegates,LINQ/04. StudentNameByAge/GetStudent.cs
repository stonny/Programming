// Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.

using System;
using System.Linq;

public class GetStudent
{
    static void Main(string[] args)
    {
        // Initializing array elements
        Student[] studentArray =
        {
            new Student("Georgi", "Georgiev", 17),
            new Student("Georgi", "Nejkov", 23),
            new Student("Nikolay", "Kostov", 45),
            new Student("Pavel", "Kolev", 20),
            new Student("Svetlin", "Nakov", 36),
            new Student("Galina", "Grueva", 68),
            new Student("Dimo", "Nyagolow", 12),
            new Student("Yana", "Stoyanova", 24),
            new Student("Hristina", "Petrova", 25)
        };

        // LINQ which gets the student name by age 
        var result =
            from student in studentArray
            where (student.Age >= 18 && student.Age <= 24)
            select student;
        // Printing student name who have passed the LINQ
        foreach (var student in result)
        {
            Console.WriteLine(student.FirstName + " " + student.LastName 
                );
        }
    }
}

