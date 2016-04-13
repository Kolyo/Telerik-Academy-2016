using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        if (input.Length < 3)
        {
            Console.WriteLine("false 0");
        }
        else if (input[input.Length - 3] == '7')
        {
            Console.WriteLine("true");
        }

        else
        {
            Console.WriteLine("false " + input[input.Length - 3]);
        }

    }
}
