using System;

//class Program
//{
//    static void Main()
//    {
//        uint input = uint.Parse(Console.ReadLine());
//        string bitvalue = Convert.ToString(input, 2).PadLeft(8, '0');
//        Console.WriteLine(bitvalue[bitvalue.Length - 4]);
//    }
//}

class Program
{
    static void Main()
    {
        uint input = uint.Parse(Console.ReadLine());
        input = input >> 3;
        //input = input | 0;
        Console.WriteLine(input);
    }
}