using System;

class Program
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double perimeter = 2 * a + 2 * b;
        double area = a * b;
        Console.WriteLine(area.ToString("F2") + " " + perimeter.ToString("F2"));
    }
}
