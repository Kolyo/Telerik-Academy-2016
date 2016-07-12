using System;

namespace _14.PrintASCII
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 33; i < 127; i++)
            {
                Console.Write((char)i);
            }
        }
    }
}
