using System;

namespace _12.NullValuesArithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            int? a = null;
            double? b = null;
            Console.WriteLine($"{a}  {b}");
            Console.WriteLine($"{a + 5}  {b + 6.8}");
            Console.WriteLine($"{a + null}  {b + null}");

        }
    }
}
