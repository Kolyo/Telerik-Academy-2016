using System;

class Program
{
    static void Main()
    {
        int m = int.Parse(Console.ReadLine());
        string text = Console.ReadLine();
        int result = 0;
        text = text.ToLower();
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == '@')
            {
                Console.WriteLine(result); return;
            }
            else if (char.IsDigit(text[i]))
            {
                result *= (int)text[i]-48;
            }
            else if (char.IsLetter(text[i]))
            {
                result += (int)(char)text[i] - 97;
            }
            else
            {
                result %= m;
            }

        }
  
        Console.WriteLine(result);
    }
}


