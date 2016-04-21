using System;

class Program
{
    static void Main()
    {
        string value = Console.ReadLine();

        switch (value)
        {
            case "2": case "3": case "4": case "5": case "6": case "7": case "8": case "9": case "10": case "J": case "Q": case "K": case "A": Console.WriteLine("yes " + value); break;
            default: Console.WriteLine("no " + value); return;
        }

    }
}
