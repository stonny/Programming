// Class Discipling that will initialize name, number of lectures, number of exercises
public class Discipline :  Commentable
{
    // Fields
    protected string name;
    protected int numberLectures;
    protected int numberExercises;

    // Constructor
    public Discipline(string name, int numberLectures, int numberExercises)
    {
        this.Name = name;
        this.NumberLectures = numberLectures;
        this.NumberExcercises = numberExercises;
    }

    // Properties
    public string Name
    {
        get 
        {
            return this.name; 
        }
        protected set 
        {
            // Encapsulation
            if (value.Length > 0)
            {
                this.name = value;
            }
            else
            {
                throw new System.ArgumentOutOfRangeException("Incorrect value input !");
            }
        }
    }

    public int NumberLectures
    {
        get
        {
            return this.numberLectures;
        }
        protected set
        {
            // Encapsulation
            if (value >= 0)
            {
                this.numberLectures = value;
            }
            else
            {
                throw new System.ArgumentOutOfRangeException("Invalid input!");
            }
        }
    }

    public int NumberExcercises
    {
        get
        {
            return this.numberExercises;
        }
        protected set
        {
            // Encapsulation
            if (value >= 0)
            {
                this.numberExercises = value;
            }
            else
            {
                throw new System.ArgumentOutOfRangeException("Invalid input!");
            }
        }
    } 
}

