using System;

namespace _10.EmployeeData
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Gosho";
            string lastName = "Peshev";
            byte age = 23;
            char gender = 'M';
            string ID = "8306112507";
            string employeeNumber = "27569999";

            Console.WriteLine($"{firstName} {lastName} - {age} - {gender}\nID: {ID}\n{employeeNumber}");
        }
    }
}
