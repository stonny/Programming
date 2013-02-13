/*A marketing firm wants to keep record of its employees. 
 * Each record would have the following characteristics 
 * – first name, family name, age, gender (m or f), ID number,
 * unique employee number (27560000 to 27569999). |
 * Declare the variables needed to keep the information for a single
 * employee using appropriate data types and descriptive names.
*/
using System;

class FirmRecords
{
    static void Main()
    {
        string firstName, familyName, gender;
        byte age;
        int idNumber, employeNumber;
        Console.WriteLine("Enter your First Name: ");
        firstName=Console.ReadLine();
        Console.WriteLine("Enter your Family Name: ");
        familyName=Console.ReadLine();
        Console.WriteLine("Enter your gender:");
        gender=Console.ReadLine();
        Console.WriteLine("Enter your age: ");
        age=byte.Parse(Console.ReadLine());
        Console.WriteLine("Enter your ID Number: ");
        idNumber=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter your Employe Number(27560000 to 27569999)" );
         employeNumber=int.Parse(Console.ReadLine());
       
        Console.WriteLine("The Data has been saved successfully!");

        

    }
}

