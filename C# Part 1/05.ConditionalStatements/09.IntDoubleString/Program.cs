using System;

class Program
{
    static void Main()
    {
        string variableType = Console.ReadLine();
        string input = Console.ReadLine();
        switch (variableType)
        {
            case "integer": Console.WriteLine(int.Parse(input) + 1); break;
            case "real": Console.WriteLine((double.Parse(input) + 1).ToString("F2")); break;
            case "text": Console.WriteLine(input + "*"); break;
            default:
                Console.WriteLine("error");
                break;
        }
    }
}

