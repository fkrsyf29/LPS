using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Masukkan string: ");
        string input = Console.ReadLine();

        Dictionary<char, int> charCount = CountChars(input);

        Console.WriteLine("Output:");
        foreach (var charString in charCount)
        {
            if (charString.Key != ' ') // Mengabaikan spasi
            {
                Console.WriteLine($"{charString.Key} - {charString.Value}");
            }
        }
    }

    static Dictionary<char, int> CountChars(string input)
    {
        Dictionary<char, int> charCount = new Dictionary<char, int>();

        foreach (char c in input)
        {
            if (c != ' ') // Mengabaikan spasi
            {
                if (charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }
                else
                {
                    charCount[c] = 1;
                }
            }
        }

        return charCount;
    }
}
