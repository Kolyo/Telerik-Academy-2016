using System;

namespace _08.IsoleselesTriangles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            char symbol = '©';
            Console.WriteLine("   " + symbol);
            Console.WriteLine("  " + symbol + ' ' + symbol);
            Console.WriteLine(" " + symbol + "   " + symbol);
            Console.WriteLine(symbol + " " + symbol + " " + symbol + " " + symbol);

        }
    }
}
