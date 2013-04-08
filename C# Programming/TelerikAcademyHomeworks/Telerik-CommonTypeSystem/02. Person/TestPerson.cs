using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Person
{
    class TestPerson
    {
        static void Main(string[] args)
        {

            // Initializng first test object with age
            Person testPerson = new Person("Ivan", 25);
            Console.WriteLine(testPerson);

            Console.WriteLine(new string('-', 25));

            // Initializing second test object without age
            Person testPerson2 = new Person("Pesho");
            Console.WriteLine(testPerson2);
        }
    }
}
