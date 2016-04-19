using System;

class Program
{
    static void Main()
    {
        double radius = double.Parse(Console.ReadLine());
        double perimeter = radius * 2 * Math.PI;
        double area = radius * radius * Math.PI;
        Console.WriteLine(perimeter.ToString("F2") + " " + area.ToString("F2"));
    }
}
