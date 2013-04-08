using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Human
{
    // Properties only because the class purpose is only to set FirstName and LastName
    // which will be inherited from other classes
    public string FirstName { get; protected set; }
    public string LastName { get; protected set; }
}

