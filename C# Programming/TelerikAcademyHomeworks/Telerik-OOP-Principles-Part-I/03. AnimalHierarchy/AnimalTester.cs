using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define
    * useful constructors and methods. Dogs, frogs and cats are Animals.
    * All animals can produce sound (specified by the ISound interface).
    * Kittens and tomcats are cats. All animals are described by age, name and sex.
    * Kittens can be only female and tomcats can be only male. Each animal produces a 
    * specific sound. Create arrays of different kinds of animals and calculate the average
    * age of each kind of animal using a static method (you may use LINQ).
    * */

class AnimalTester
{
    static void Main(string[] args)
    {    
        // Adding Animals to List
        List<Animal> differentAnimalsList = new List<Animal>();
        differentAnimalsList.Add(new Kitten("pesho", 10));
        differentAnimalsList.Add(new Tomcat("misho", 20));
        differentAnimalsList.Add(new Frog("gabcho", 50, "Male"));
        differentAnimalsList.Add(new Frog("gabcho2", 30, "Male"));
        differentAnimalsList.Add(new Dog("sharo", 25, "Male"));
        differentAnimalsList.Add(new Kitten("puhcho", 5));

        // Testing MakeSound Method
        Frog testFrog = new Frog("gabcho", 50, "Male");
        Cat testCat = new Tomcat("pesho", 25);
        Dog testDog = new Dog("Ivan", 35, "Male");
        testFrog.MakeSound();
        testCat.MakeSound();
        testDog.MakeSound();
        
        // Average age of Kitten
        Console.WriteLine("Average kitten age: ");
        var result =
            (from animal in differentAnimalsList
             where animal.GetType() == typeof(Kitten)
             select animal.Age).Average();
        Console.WriteLine(result);
        

        // Average age of Tomcat
        Console.WriteLine("Average tomcat age: ");
        result =
            (from animal in differentAnimalsList
             where animal.GetType() == typeof(Tomcat)
             select animal.Age).Average();
        Console.WriteLine(result);
        

        // Average age of Frog
        Console.WriteLine("Average frog age: ");
        result =
            (from animal in differentAnimalsList
             where animal.GetType() == typeof(Frog)
             select animal.Age).Average();
        Console.WriteLine(result);
        
        
        // Average age of Dog
        Console.WriteLine("Average dog age: ");
        result =
            (from animal in differentAnimalsList
             where animal.GetType() == typeof(Dog)
             select animal.Age).Average();
        Console.WriteLine(result);
    }
}


