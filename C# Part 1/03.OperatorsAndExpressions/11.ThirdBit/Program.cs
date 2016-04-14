using System;

class Program
{
    static void Main()
    {
        uint input = uint.Parse(Console.ReadLine());
        string bitvalue = Convert.ToString(input, 2).PadLeft(8, '0');
        Console.WriteLine(bitvalue[bitvalue.Length - 4]);
    }
}
