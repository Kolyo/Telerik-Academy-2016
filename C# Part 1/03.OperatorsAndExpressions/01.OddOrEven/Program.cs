using System;

class Program
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        if (input % 2 == 0)
        {
            Console.WriteLine("even " + input);
        }
        else
        {
            Console.WriteLine("odd " + input);
        }
    }
}
