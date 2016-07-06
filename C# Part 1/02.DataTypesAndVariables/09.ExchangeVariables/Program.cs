using System;

namespace _09.ExchangeVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            Console.WriteLine(a + " " + b);
            a += b;
            b = a - b;
            a -= b;
            Console.WriteLine(a + " " + b);
        }
    }
}
