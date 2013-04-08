// Class People that will create new instance of type People
// and inherit the method addcomment from class Commentable
public class People : Commentable
{
    // Fields
    protected string name;
    // Constructor which initializes name by Property
    public People(string name)
    {
        this.Name = name;
    }

    // Property with validation 
    public string Name
    {
        get
        {
            return this.name;
        }
        protected set
        {
            if (value.Length > 0)
            {
                this.name = value;
            }
            else
            {
                throw new System.FormatException("Invalid input!");
            }
        }     
    }
}

