// Class Classes which holds the Unique text identifier for each class
// and inherits the comment method from the abstract class Commentable
using System.Collections.Generic;
public class Classes :  Commentable
{
    // Field to initialize the class identifier
    protected string classIdentifier;

    // Constructor to initialize classIdentifier through property
    public Classes(string classIdentifier)
    {
        this.ClassIdentifier = classIdentifier;
    }

    // Property with validator
    public string ClassIdentifier
    {
        get 
        {
            return this.classIdentifier; 
        }
        // Encapsulation
        protected set 
        {        
            if (value.Length > 0)
            {
                this.classIdentifier = value;
            }
            else
            {
                throw new System.FormatException("Wrong input !");
            }
        }
    }
}

