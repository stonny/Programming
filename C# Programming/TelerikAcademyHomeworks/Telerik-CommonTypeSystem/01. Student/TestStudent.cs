using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Student
{
    class TestStudent
    {
        static void Main(string[] args)
        {
            // Testing student initialization
            Student testStudent = new Student("Ivan", "Petrov", "Iliev", "Sofia bla bla", "0883543422",
                9353215363, 2, University.SofiaUniversity, Faculty.MathematicsAndInformatics, Specialty.SoftwareEngineering);
            Console.WriteLine(testStudent);

            // Testing student cloning
            Student newStudent = testStudent.Clone() as Student;
            Console.WriteLine(newStudent);

            // Testing Student Comparing
            Console.WriteLine(testStudent.CompareTo(newStudent));
        }
    }
}
