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

        //var n = 11;
        ////var n = 5;
        //int[] arr = { 4000, 4, 6, 5, 3, 3, 9, 100, 2, 3, 1 };
        ////int[] arr = { 5, 4, 3, 2, 1 };

        var sum = 0;
        var maxsum = 0;
        var blockspeed = arr[0];
        var count = 0;
        var maxcount = 0;

        for (int i = 0; i < arr.Length - 1;)
        {

            if (arr[i] < arr[i + 1])
            {
                blockspeed = arr[i];
                do
                {
                    sum += arr[i];

                    i++;
                    count++;
                    if (i == n)
                    {
                        break;
                    }
                } while (blockspeed < arr[i]);
            }
            else
            {
                if (maxcount < 1)
                {
                    maxcount = 1;
                    maxsum = arr[i];
                }

                i++;
            }

            if (count >= maxcount)
            {
                maxsum = sum;
                maxcount = count;
                sum = 0;
                count = 0;
            }


        }

        Console.WriteLine(maxsum);

    }

}