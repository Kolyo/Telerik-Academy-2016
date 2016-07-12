using System;

class Program
{
    static void Main()
    {
        ulong n = ulong.Parse(Console.ReadLine());
        int position = int.Parse(Console.ReadLine());
        uint v = uint.Parse(Console.ReadLine());
  

        if (v == 1)
        {
            uint shifted = v << position;
            Console.WriteLine(n | shifted);
        }
        else
        {
            uint shifted = v << position;
            Console.WriteLine(n ^ (~shifted));
        }

    }
}
