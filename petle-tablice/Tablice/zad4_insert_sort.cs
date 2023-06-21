using System;

class zad4_insert_sort
{
    static void Main()
    {
        int[] arr = new int[10];
        Random rand = new Random();
        int n = arr.Length;

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rand.Next(1, 100);
        }

        Console.WriteLine("Tablica:");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }

        for (int i = 1; i < n; ++i)
        {
            int key = arr[i];
            int j = i - 1;

            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j = j - 1;
            }
            arr[j + 1] = key;
        }

        Console.WriteLine(" ");
        Console.WriteLine("Posortowana:");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
}