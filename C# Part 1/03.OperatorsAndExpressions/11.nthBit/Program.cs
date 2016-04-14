using System;

class Program
{
    static void Main()
    {
        int p = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
       
        string bitvalue = Convert.ToString(p, 2).PadLeft(64, '0');
        Console.WriteLine(bitvalue[bitvalue.Length - n]);
    }
}
