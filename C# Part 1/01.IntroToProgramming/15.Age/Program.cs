using System;

namespace _15.Age
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputParsed = DateTime.Parse(Console.ReadLine()).Year;

            var age = DateTime.Now.Year - inputParsed;

            Console.WriteLine(age);
            Console.WriteLine(age + 10);
        }
    }
}
