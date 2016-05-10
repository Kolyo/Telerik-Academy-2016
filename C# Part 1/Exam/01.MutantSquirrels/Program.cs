using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        ulong t = ulong.Parse(Console.ReadLine());
        ulong b = ulong.Parse(Console.ReadLine());
        ulong s = ulong.Parse(Console.ReadLine());
        ulong n = ulong.Parse(Console.ReadLine());

        ulong output = t * b * s * n;
        if (output % 2 == 0)
        {
            Console.WriteLine((output * 376439.0).ToString("F3"));
        }
        else
        {
            Console.WriteLine((output / 7.0).ToString("F3"));
        }
    }
}

