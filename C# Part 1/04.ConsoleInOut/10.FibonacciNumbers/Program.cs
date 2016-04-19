using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        uint[] arr = new uint[n + 3];
        arr[0] = 0;
        arr[1] = 1;
        arr[2] = 1;
        for (int i = 2; i < n; i++)
        {
            arr[i] = arr[i - 1] + arr[i - 2];
        }
        if (n == 0)
        {
            Console.WriteLine("0");
        }
        else
        {
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write(arr[i] + ", ");
            }
            Console.WriteLine(arr[n-1]);
        }
    }
}

