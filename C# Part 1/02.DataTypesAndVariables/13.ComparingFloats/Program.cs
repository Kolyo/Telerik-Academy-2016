using System;

namespace _13.ComparingFloats
{
    class Program
    {
        static void Main(string[] args)
        {
            double eps = 0.000001f;
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            var output = a - b;
              if (Math.Abs(output) > eps)
            {
                Console.WriteLine("false");
            }
            else
            {
                Console.WriteLine("true");
            }
        }
    }
}
