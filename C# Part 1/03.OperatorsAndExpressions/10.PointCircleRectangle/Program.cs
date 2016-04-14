using System;

class Program
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

        string output = "";
        if ((x < 2.5 && x >= -0.5) && (y <= 2.5 && y >= -0.5))
        {
            output += "inside circle ";
        }
        else
        {
            output += "outside circle ";
        }

        if ((x <= 5 && x >= -1) && (y <= 1 && y >= -1))
        {
            output += "inside rectangle";
        }
        else
        {
            output += "outside rectangle";
        }
        Console.WriteLine(output);
    }
}
