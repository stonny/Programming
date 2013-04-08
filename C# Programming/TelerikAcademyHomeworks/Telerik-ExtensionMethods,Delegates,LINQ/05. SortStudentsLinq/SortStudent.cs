/* Using the extension methods OrderBy() and ThenBy()
 * with lambda expressions sort the students by first name
 * and last name in descending order. Rewrite the same with LINQ.
 */
using System;
using System.Linq;

class SortStudent
{
    static void Main(string[] args)
    {
        // Initializing an anonymous type to create new instance of the Students
        var studentArray = new[]
            {
                new { firstName = "Georgi", lastName = "Georgiev"},
                new { firstName = "Pesho", lastName = "Peshkov"},
                new { firstName = "Ivan", lastName = "Goshev" },
                new { firstName = "Ilko", lastName = "Iliev" }
            };
        // Generating LINQ to sort by descending
        var sortStudentLinq =
            from student in studentArray
            orderby student.firstName descending, student.lastName descending
            select student;
        // Printing the result on the console
        foreach (var item in sortStudentLinq)
        {
            Console.WriteLine(item.firstName + " " + item.lastName);
        }
    }
}

