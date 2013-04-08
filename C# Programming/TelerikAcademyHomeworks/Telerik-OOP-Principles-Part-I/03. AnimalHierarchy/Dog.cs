using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Class Dog that inherits from class Animal - name, age and sex
public class Dog : Animal, ISound
{
    // Constructor
    public Dog(string name, int age, string sex)
        : base(name, age, sex)
    {
        this.Name = name;
        this.Age = age;
        this.Sex = sex;
    }
    // Make Sound Method
    public void MakeSound()
    {
        Console.WriteLine("Bau !");
    }
}
