using System;

class Program
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        if (input <= 1)
        {
            Console.WriteLine("false");
        }
        else if (input == 2)
        {
            Console.WriteLine("true");
            return;
        }
        else
        {
            for (int i = 2; i < Math.Sqrt(input)+1; i++)
            {
                if (input % i == 0)
                {
                    Console.WriteLine("false");
                    return;
                }
            }
            Console.WriteLine("true");
        }
    }
}
