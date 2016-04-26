using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        ulong n = ulong.Parse(Console.ReadLine());
        ulong k = ulong.Parse(Console.ReadLine());
        BigInteger kfact = 1;
        for (ulong i = 1; i <= n; i++)
        {
            if (k < i)
            {
                kfact *= i;
            }

        }

        Console.WriteLine(kfact);
    }
}
