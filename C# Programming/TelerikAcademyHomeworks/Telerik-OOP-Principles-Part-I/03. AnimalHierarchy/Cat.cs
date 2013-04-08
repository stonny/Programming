using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Class Cat that inherits from class Animal - name, age and sex
public class Cat : Animal, ISound
{
    // Constructor
    public Cat(string name, int age, string sex)
        : base(name, age, sex)
    {
        this.Name = name;
        this.Age = age;
        this.Sex = sex;
    }
    // Virtual Method for Cat
    public virtual void MakeSound()
    {
        Console.WriteLine("Mqu !");
    }
}

