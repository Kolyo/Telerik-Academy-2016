using System;

class Program
{
    static void Main()
    {
        double n = double.Parse(Console.ReadLine());
        double s = double.Parse(Console.ReadLine());
        float p = float.Parse(Console.ReadLine());

        Console.WriteLine((((n*s)/500)*p).ToString("F2"));

    }
}
