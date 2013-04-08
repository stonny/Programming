using System;
/*We are given a school. In the school there are classes of students.
         * Each class has a set of teachers. Each teacher teaches a set of disciplines.
         * Students have name and unique class number. Classes have unique text identifier.
         * Teachers have name. Disciplines have name, number of lectures and number of exercises.
         * Both teachers and students are people. Students, classes, teachers and disciplines could
         * have optional comments (free text block).
	     * Your task is to identify the classes (in terms of  OOP) and their attributes and operations,
         * encapsulate their fields, define the class hierarchy and create a class diagram with Visual Studio.
        */
public class CreateSchool
{
    static void Main(string[] args)
    {        
        // Testing the initialization of the classes
        School school = new School("Ivan Vazov");
        People testStudent = new Student("Georgi Georgiev", 12);
        People testTeacher = new Teacher("Ivan Ivanov");
        Classes coolClass = new Classes("b");
        Discipline discpline = new Discipline("Math", 5, 10);
        // Testing add Comment method

        testTeacher.AddComment("Pesho e mnogo gotin");
        testStudent.AddComment("Ivan e lud");

    }
}
