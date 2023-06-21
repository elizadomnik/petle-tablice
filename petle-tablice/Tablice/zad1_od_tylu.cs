// Napisz algorytm do wypisywania zawartości tablicy od tyłu (tablicę wypełnij losowymi wartościami).

using System;

class zad1_tablica
{
    static void Main()
    {
        int[] tablica = new int[10];
        Random rand = new Random();

        for (int i = 0; i < tablica.Length; i++)
        {
            tablica[i] = rand.Next(1, 100);
        }

        Console.WriteLine("Tablica:");
        for (int i = 0; i < tablica.Length; i++)
        {
            Console.Write(tablica[i] + " ");
        }

        Console.WriteLine("\nTablica od tyłu:");
        for (int i = tablica.Length - 1; i >= 0; i--)
        {
            Console.Write(tablica[i] + " ");
        }
    }
}
