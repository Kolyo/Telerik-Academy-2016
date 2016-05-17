using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        int longestSec = 0 , curSec = 1;

        for (int i = 1; i < n; i++)
        {
            if (arr[i]-1 == arr[i - 1])
            {
                curSec++;
            }
            else
            {
                if (curSec > longestSec)
                {
                    longestSec = curSec;
                    curSec = 1;
                }
            }
        }
        Console.WriteLine(longestSec);
    }
}