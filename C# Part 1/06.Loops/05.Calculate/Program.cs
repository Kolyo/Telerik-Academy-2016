using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        double n = int.Parse(Console.ReadLine());
        double x = double.Parse(Console.ReadLine());
        double sum = 1;
        long fact = 1;
        for (int i = 1; i <= n; i++)
        {
            fact *= i;
            sum += fact / Math.Pow(x, i);
        }
        Console.WriteLine(sum.ToString("F5"));
    }
}
