using System;

//TODO: Make with bitwise operators
class Program
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        int position = int.Parse(Console.ReadLine());
        char v = char.Parse(Console.ReadLine());

        string bitvalue = Convert.ToString(n, 2).PadLeft(64, '0'); 
        char[] bits = bitvalue.ToCharArray();
        bits[bits.Length - (position+1)] = v;

        bitvalue = "";

        for (int i = 0; i < bits.Length; i++)
        {
            bitvalue += bits[i];
        }

        long output = Convert.ToInt64(bitvalue, 2);
        Console.WriteLine(output);
    }
}
