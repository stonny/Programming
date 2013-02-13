using System;


class companyInfo
{
    static void Main()
    {
        Console.WriteLine("Please Enter the Name of the Company: ");
        string companyName = Console.ReadLine();
        Console.WriteLine("Please Enter the address of the Company: ");
        string companyAddress = Console.ReadLine();
        Console.WriteLine("Please Enter the Phone Number of the Company: ");
        string companyPhone = Console.ReadLine();
        Console.WriteLine("Please Enter the Fax Number of the Company: ");
        string companyFax = Console.ReadLine();
        Console.WriteLine("Please Enter the Web site of the Company: ");
        string companyWeb= Console.ReadLine();
        Console.WriteLine("Please Enter the following info about the Manager: ");
        Console.WriteLine("Please Enter the First Name of the Manager: ");
        string firstName = Console.ReadLine();
        Console.WriteLine("Please Enter the Last Name of the Manager: ");
        string lastName = Console.ReadLine();
        Console.WriteLine("Please Enter the Age of the Manager: ");
        byte ageManager = byte.Parse(Console.ReadLine());
        Console.WriteLine("Please Enter the Phone Number of the Manager: ");
        string managerPhone = Console.ReadLine();
        Console.WriteLine("Company Info:");
        Console.WriteLine("Company Name: {0}\r\n Address: {1}\r\n Phone Number: {2}\r\n FaxNumber: {3}\r\n Website: {4}",
                            companyName, companyAddress, companyPhone, companyFax, companyWeb);
        Console.WriteLine("Manager Info:");
        Console.WriteLine(" Name: {0} {1}\r\n  Age: {2}\r\n PhoneNumber: {3}",
                            firstName, lastName, ageManager, managerPhone);


    }   
}

