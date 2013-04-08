// Write a method that from a given array of students
// finds all students whose first name is before its
// last name alphabetically. Use LINQ query operators.

using System;
using System.Linq;

public class CompareNames
{
    public static void Main()
    {
        // Initializng Students
        Student[] studentArray =
        {
            new Student("Georgi", "Georgiev"),
            new Student("Georgi", "Nejkov"),
            new Student("Nikolay", "Kostov"),
            new Student("Pavel", "Kolev"),
            new Student("Svetlin", "Nakov"),
            new Student("Galina", "Grueva"),
            new Student("Dimo", "Nyagolow"),
            new Student("Yana", "Stoyanova"),
            new Student("Hristina", "Petrova")
        };

        GetStudentName(studentArray);
       
    }
    
    //Method which performs LINQ Query and prints Student names
    public static void GetStudentName(Student[] studentArray)
    {
        var result =
            from student in studentArray
            where student.FirstName.CompareTo(student.LastName) < 0
            select student;

        foreach (var student in result)
        {
            Console.WriteLine(student.FirstName + " " + student.LastName);
        }
    }
}

