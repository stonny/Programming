using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Abstract class Animal that will be base for other type of animals
public abstract class Animal
{
    // Properties
    public int Age { get; protected set; }
    public string Name { get; protected set; }
    public string Sex { get; protected set; }

    // Constructor
    public Animal(string name, int age, string sex)
    {
        this.Name = name;
        this.Age = age;
        this.Sex = sex;
    }

}

