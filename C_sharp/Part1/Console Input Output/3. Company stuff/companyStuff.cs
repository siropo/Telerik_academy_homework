using System;

class companyStuff
{
    static void Main()
    {
        Console.Write("Enter company name:");
        string companyName = Console.ReadLine();

        Console.Write("Enter address:");
        string address = Console.ReadLine();

        Console.Write("Enter phone:");
        string phone = Console.ReadLine();

        Console.Write("Enter fax:");
        string fax = Console.ReadLine();

        Console.Write("Enter website:");
        string website = Console.ReadLine();

        Console.Write("Enter Meneger first name:");
        string menegerFirstName = Console.ReadLine();

        Console.Write("Enter Meneger last name:");
        string menegerLastName = Console.ReadLine();

        Console.Write("Enter Meneger age:");
        string menegerAge = Console.ReadLine();

        Console.Write("Enter Meneger phone:");
        string menegerPhone = Console.ReadLine();

        Console.WriteLine("bfdd {0,-25}|", companyName);
        Console.WriteLine("{0,-25}|", address);
        Console.WriteLine("{0,-25}|", phone);
        Console.WriteLine("{0,-25}|", fax);
        Console.WriteLine("{0,-25}|", website);
        Console.WriteLine("{0} {1,-25}|", menegerFirstName, menegerLastName);
        Console.WriteLine("{0,-25}|", menegerAge);
        Console.WriteLine("{0,-25}|", menegerPhone);
    }
}
