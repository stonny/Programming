using System;
using System.Linq;

namespace _02.Person
{
    public class PersonProperties
    {
        public void AddPerson(int identificationNumber)
        {
            Person person = new Person();
            person.Age = identificationNumber;
            if (identificationNumber % 2 == 0)
            {
                person.Name = "Some guy";
                person.Gender = Gender.Male;
            }
            else
            {
                person.Name = "Some girl";
                person.Gender = Gender.Female;
            }
        }
    }
}
