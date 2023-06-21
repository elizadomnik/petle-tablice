using System;

class zad5_select_sort
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

        for (int i = 0; i < n - 1; i++)
        {
            int min_idx = i;
            for (int j = i + 1; j < n; j++)
                if (arr[j] < arr[min_idx])
                    min_idx = j;

            int temp = arr[min_idx];
            arr[min_idx] = arr[i];
            arr[i] = temp;
        }

        Console.WriteLine(" ");
        Console.WriteLine("Posortowana:");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
}
