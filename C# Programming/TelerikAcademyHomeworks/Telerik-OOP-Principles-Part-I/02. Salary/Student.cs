using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Class Student which inherits FirstName and LastName
// from class Human and initializes its own grade field
public class Student : Human
{
    // Property
    public double Grade { get; protected set; }

    // Constructor
    public Student(string firstName, string lastName, double grade)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Grade = grade;  
    }
}

