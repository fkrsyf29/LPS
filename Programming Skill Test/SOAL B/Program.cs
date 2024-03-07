using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Masukkan angka: ");
        string input = Console.ReadLine();

        string[] parts = input.Split('.'); // Memisahkan angka berdasarkan titik

        if (parts.Length > 2)
        {
            Console.WriteLine("Input tidak valid. Hanya satu titik desimal yang diperbolehkan.");
            return;
        }

        string integerPart = parts[0];

        if (integerPart.Length > 38)
        {
            Console.WriteLine("Input tidak valid. Angka tidak boleh lebih dari 38 digit.");
            return;
        }

        BigInteger multiplier = BigInteger.Pow(10, integerPart.Length - 1);

        for (int i = 0; i < integerPart.Length; i++)
        {
            int num = int.Parse(integerPart[i].ToString());
            BigInteger result = num * multiplier;
            Console.WriteLine(result);
            multiplier /= 10;
        }
    }
}
