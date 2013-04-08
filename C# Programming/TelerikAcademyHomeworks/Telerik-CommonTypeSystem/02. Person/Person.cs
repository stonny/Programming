using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Person
{
    class Person
    {
        // Fields
        private string name;
        private byte? age;

        // Constructor
        public Person(string name, byte? age = null)
        {
            this.Name = name;
            this.Age = age;
        }

        // Properties
        public byte? Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        

        // Mehtods
        public override string ToString()
        {
            StringBuilder endText = new StringBuilder();
            endText.AppendLine(String.Format("Name: {0} ", this.name));
            if (this.age != null)
            {
                endText.Append(String.Format("Age: {0} ", this.age));
            }
            else
            {
                endText.Append("Age was not specified");
            }
            return endText.ToString();
        }
    }
}
