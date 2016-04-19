using System;

class Program
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double desc = (b * b) - (4 * a * c);
        if (desc < 0)
        {
            Console.WriteLine("no real roots");
        }
        else if (desc == 0)
        {
            Console.WriteLine(((-1 * b) / (2 * a)).ToString("F2"));
        }
        else
        {
            Console.WriteLine(((-b - Math.Sqrt(desc)) / (2 * a)).ToString("F2"));

            Console.WriteLine(((-b + Math.Sqrt(desc)) / (2 * a)).ToString("F2"));
        }
    }
}
