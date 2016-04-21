using System;

class Program
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        int signCount = 0;
        if (a < 0)
        {
            signCount++;
        }
        if (b < 0)
        {
            signCount++;
        }
        if (c < 0)
        {
            signCount++;
        }

        if (a == 0 || b == 0 || c == 0)
        {
            Console.WriteLine(0);
        }
        else if (signCount % 2 == 0)
        {
            Console.WriteLine("+");
        }
        else
        {
            Console.WriteLine("-");
        }

    }
}

