using System;

public class Student
{
    // Defining shortly field and property 
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Construtctor to create the elements
    public Student (string firstName, string lastName)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
    }
}

