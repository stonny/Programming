using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Class Kitten that inherits from class Cat

public class Kitten : Cat
{
    // Constructor
    public Kitten(string name, int age)
        : base(name, age, "Female")
    {
        this.Name = name;
        this.Age = age;
    }
    // Overrided sound method so it has different behaviour than the class that it inherits
    public override void MakeSound()
    {
        System.Console.WriteLine("Kitten mqu!");
    }
}
