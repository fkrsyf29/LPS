using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Input:");
        string input = Console.ReadLine();

        string formatJudul = FormatJudul(input);
        string formatBiasa = FormatBiasa(input);

        Console.WriteLine("\nOutput:");
        Console.WriteLine($"Format Judul: {formatJudul}");
        Console.WriteLine($"Format Biasa: {formatBiasa}");
    }

    static string FormatJudul(string input)
    {
        string[] words = input.ToLower().Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i] != "")
            {
                char[] letters = words[i].ToCharArray();
                letters[0] = char.ToUpper(letters[0]);
                words[i] = new string(letters);
            }
        }
        return string.Join(" ", words);
    }

    static string FormatBiasa(string input)
    {
        string[] words = input.ToLower().Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i] != "" && i == 0)
            {
                char[] letters = words[i].ToCharArray();
                letters[0] = char.ToUpper(letters[0]);
                words[i] = new string(letters);
            }
        }
        return string.Join(" ", words);
    }
}
