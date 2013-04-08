using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.Student
{
    public class Student : ICloneable, IComparable<Student>
    {
        // Fields
        private string firstName;
        private string middleName;
        private string lastName;
        private string address;
        private string phoneNumber;
        private long ssn;
        private byte course;
        private University university;
        private Faculty faculty;
        private Specialty specialty;

        // Constructor
        public Student(string firstName, string middleName, string lastName, string address, string phoneNumber,
            long ssn, byte course, University university, Faculty faculty, Specialty specialty)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
            this.SSN = ssn;
            this.Course = course;
            this.university = university;
            this.faculty = faculty;
            this.specialty = specialty;
        }

        // Properties
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        

        public byte Course
        {
            get { return course; }
            set { course = value; }
        }
        

        public long SSN
        {
            get { return ssn; }
            set { ssn = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        
        public string MiddleName
        {
            get { return middleName; }
            set { middleName = value; }
        }
        
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        // Overrided Methods - I dont know what to comment on them...
        // Each method name is enough
        public override bool Equals(object obj)
        {
            if (this.ssn != (obj as Student).ssn)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public override string ToString()
        {
            return string.Format("Name: {0} {1} {2}\nSSN: {3}\nAddress: {4}\nMobile phone: {5}\nSpecialty: {6}\n" +
                "University: {7}\n", firstName, middleName, lastName, ssn, address, phoneNumber, specialty, university);
        }

        public override int GetHashCode()
        {
            return firstName.GetHashCode() ^ lastName.GetHashCode() ^ ssn.GetHashCode();
        }

        public static bool operator ==(Student s1, Student s2)
        {
            return (s1.ssn == s2.ssn);
        }

        public static bool operator !=(Student s1, Student s2)
        {
            return (s1.ssn != s2.ssn);
        }


        // Method that deeply clones an object of type Student
        public object Clone()
        {
            Student temp = new Student(this.firstName, this.middleName, this.lastName, this.address, this.phoneNumber, this.ssn, this.course,
                this.university, this.faculty, this.specialty) as Student;
            return temp;
        }

        // Method that compares students by name (Lexicographically)
        public int CompareTo(Student s)
        {
            if (firstName.CompareTo(s.firstName) != 0)
                return firstName.CompareTo(s.firstName);
            else if (middleName.CompareTo(s.middleName) != 0)
                return middleName.CompareTo(s.middleName);
            else if (lastName.CompareTo(s.lastName) != 0)
                return lastName.CompareTo(s.lastName);
            else
            {
                return ssn.CompareTo(s.ssn);
            }
        }
    }
}
