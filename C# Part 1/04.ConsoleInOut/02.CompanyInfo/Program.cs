using System;

class Program
{
    static void Main()
    {
        string companyName = Console.ReadLine();
        string companyAddress = Console.ReadLine();
        string phone = Console.ReadLine();
        string fax = Console.ReadLine();
        string website = Console.ReadLine();
        string managerFName = Console.ReadLine();
        string managerLName = Console.ReadLine();
        int managerAge = int.Parse(Console.ReadLine());
        string managerPhone = Console.ReadLine();

        Console.WriteLine(companyName);
        Console.WriteLine("Address: " + companyAddress);
        Console.WriteLine("Tel. " + phone);
        if (fax != "")
        {
            Console.WriteLine("Fax: " + fax);
        }
        else
        {
            Console.WriteLine("Fax: (no fax)");
        }
        Console.WriteLine("Web site: " + website);
        Console.WriteLine("Manager: " + managerFName + " " + managerLName + " (age: " + managerAge + ", tel. " + managerPhone + ")");
    }
}
