using System;

class Program
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

        double dist = Math.Sqrt(x * x + y * y);
        if (dist < -2 || dist > 2)
        {
            Console.WriteLine("no " + dist.ToString("F2"));
        }
        else
        {
            Console.WriteLine("yes " + dist.ToString("F2"));
        }
    }
}
