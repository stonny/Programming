// Class School that will give the school a name
using System.Text;
public class School
{
    // Field
    protected string schoolName;

    // Constructor
    public School(string schoolName)
    {
        this.SchoolName = schoolName;
    }

    //Property
    public string SchoolName
    {
        get
        {
            return this.schoolName;
        }
        protected set
        {
            if (value.Length > 0)
            {
                this.schoolName = value;
            }
            else
            {
                throw new System.FormatException("Wrong input!");
            }
        }
    }
}
