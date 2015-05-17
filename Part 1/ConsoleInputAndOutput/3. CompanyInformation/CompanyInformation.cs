/* A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
Write a program that reads the information about a company and its manager and prints them on the console.*/
using System;

class CompanyInformation
{
    static void Main()
    {
        string companyName;
        string companyAddress;
        string companyWebsite;
        int companyNumber;
        int companyFaxNumber;
        string managerFirstName;
        string managerLastName;
        int managerNumber;
        int managerAge;
        Console.Write("Write down the name of the company: ");
        companyName = Console.ReadLine();
        Console.Write("Write down the address of the company: ");
        companyAddress = Console.ReadLine();
        Console.Write("Write down the website of the company: ");
        companyWebsite = Console.ReadLine();
        Console.Write("Write down the phone number of the company: ");
        companyNumber = int.Parse(Console.ReadLine());
        Console.Write("Write down the fax number of the company: ");
        companyFaxNumber = int.Parse(Console.ReadLine());
        Console.Write("Write down the manager's first name: ");
        managerFirstName = Console.ReadLine();
        Console.Write("Write down the manager's last name: ");
        managerLastName = Console.ReadLine();
        Console.Write("Write down the manager's phone number: ");
        managerNumber = int.Parse(Console.ReadLine());
        Console.Write("Write down the manager's age: ");
        managerAge = int.Parse(Console.ReadLine());

        Console.WriteLine("------------- {0} -------------",companyName);
        Console.WriteLine("Address: {0}, Website:",companyAddress,companyWebsite);
        Console.WriteLine("Phone number: 0{0}, Fax Number: {1}",companyNumber,companyFaxNumber);
        Console.WriteLine("------------- Manager Contacts -------------");
        Console.WriteLine("Name: {0}" + " " + "{1}",managerFirstName,managerLastName);
        Console.WriteLine("Age: {0} | Phone number: 0{1}",managerAge,managerNumber);


    }
}

