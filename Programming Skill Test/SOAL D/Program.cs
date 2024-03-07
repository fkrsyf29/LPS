using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Masukkan nilai N: ");
        int N = int.Parse(Console.ReadLine());

        for (int i = 1; i <= N; i++)
        {
            
            if (i % 5 == 0 && i != 5) // Jika kelipatan 5, kecuali 5
            {
                Console.Write("IDIC");
            }
            if (i % 6 == 0 && i != 6) // Jika kelipatan 6, kecuali 6
            {
                Console.Write("LPS");
            }

            if (i % 5 != 0 && i % 6 != 0) // Jika bukan kelipatan 5 dan 6
            {
                Console.Write($"{i}");
            }

            Console.Write(" ");
        }
    }
}
