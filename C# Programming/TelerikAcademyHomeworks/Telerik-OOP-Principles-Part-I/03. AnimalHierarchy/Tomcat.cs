using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Class Tomcat that inherits from class Cat
class Tomcat : Cat
{
    // Constructor
    public Tomcat(string name, int age)
        : base(name, age, "Male")
    {
        this.Name = name;
        this.Age = age;
    }
    // Overrided sound method so it has different behaviour than the class that it inherits
    public override void MakeSound()
    {
        System.Console.WriteLine("Tomcat muaaaaaaaau");
    }
}

