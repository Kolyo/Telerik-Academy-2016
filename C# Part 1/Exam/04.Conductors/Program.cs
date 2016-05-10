using System;

class Program
{
    static void Main()
    {
        string p = Convert.ToString(int.Parse(Console.ReadLine()), 2);
        uint m = uint.Parse(Console.ReadLine());

        string[] binaries = new string[m];
        for (int i = 0; i < m; i++)
        {
            binaries[i] = Convert.ToString(int.Parse(Console.ReadLine()), 2).PadLeft(32, '0');
        }

        char[] output;

        for (uint i = 0; i < m; i++)
        {
            output = binaries[i].ToCharArray();
            for (int j = 32; j >= p.Length; j -= 1)
            {
                if (new string(output).Substring(j - p.Length, p.Length) == p)
                {
                    for (int k = j - 1; k >= j - p.Length; k--)
                    {
                        output[k] = '0';
                    }
                }

            }
            Console.WriteLine(Convert.ToInt32(new string(output), 2));
        }
    }
}