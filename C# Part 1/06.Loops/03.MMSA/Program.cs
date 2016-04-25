using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < n; i++)
        {
            sum += arr[i];
        }
        Array.Sort(arr);
        Console.WriteLine("min=" + arr[0].ToString("F2"));
        Console.WriteLine("max=" + arr[n-1].ToString("F2"));
        Console.WriteLine("sum=" + sum.ToString("F2"));
        Console.WriteLine("avg=" + (sum/(double)n).ToString("F2"));
    }
}
