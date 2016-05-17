using System;

class Program
{
    static void Main()
    {

        char[] arr1 = Console.ReadLine().ToCharArray();
        char[] arr2 = Console.ReadLine().ToCharArray();
        bool firstBigger = arr1.Length > arr2.Length;

        if (arr1.Length != arr2.Length)
        {
            if (firstBigger)
            {
                Console.WriteLine(">");
            }
            else
            {
                Console.WriteLine(">");
            }
        }
        else
        {
            for (int i = 0; i < arr1.Length - 1; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    if (arr1[i] > arr2[i])
                    {
                        Console.WriteLine(">");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("<");
                        return;
                    }
                }
            }
            Console.WriteLine("=");
        }
    }
}
