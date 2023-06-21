// Znajdź najmniejszy i największy element tablicy

using System;

class zad2
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

        int min = tablica[0];
        int max = tablica[0];

        for (int i = 1; i < tablica.Length; i++)
        {
            if (tablica[i] < min)
            {
                min = tablica[i];
            }

            if (tablica[i] > max)
            {
                max = tablica[i];
            }
        }

        Console.WriteLine("\nNajmniejszy element: " + min);
        Console.WriteLine("Największy element: " + max);
    }
}
