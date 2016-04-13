using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        int sum = 0;
        //sum
        for (int i = 0; i < input.Length; i++)
        {
            sum += int.Parse(input[i].ToString());
        }
        Console.WriteLine(sum);
        //reverse
        string reversed = "";
        for (int i = input.Length - 1; i >= 0; i--)
        {
            reversed += input[i];
        }
        Console.WriteLine(reversed);
        //move last to first
             Console.WriteLine(input[3].ToString() + input[0].ToString() + input[1].ToString() + input[2].ToString()); //TODO: please do me smarter

        //swap second and third
        Console.WriteLine(input[0].ToString() + input[2].ToString() + input[1].ToString() + input[3].ToString()); //TODO: please do me smarter
    }
}
