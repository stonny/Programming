using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Class Frog that inherits from class Animal - name, age and sex
public class Frog : Animal, ISound
{
    // Constructor
    public Frog(string name, int age, string sex)
        : base(name, age, sex)
    {
        this.Name = name;
        this.Age = age;
        this.Sex = sex;
    }
    // Make Sound Method
    public void MakeSound()
    {
        Console.WriteLine("Quack !");
    }
}
