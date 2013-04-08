// Class Student that inherits People and inherits name
using System.Collections.Generic;
using System.Text;

public class Student : People
{
    // Field that will initialize student's class number
    protected int classNumber;

    // Constructor that initialize classNumber by Property
    public Student(string name, int classNumber) 
        : base(name)
    {
        this.ClassNumber = classNumber;
    }

    // Property with validation
    public int ClassNumber
    {
        get 
        { 
            return this.classNumber;
        }
        protected set 
        {
            if (value > 0)
            {
                this.classNumber = value;
            }
            else
            {
                throw new System.ArgumentOutOfRangeException("Incorrect value input !");
            }
        }
    }
}

