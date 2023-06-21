//Sortowanie babelkowe

using System;

class zad3_bubble_sort
{
    public static void Main()
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
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("Posortowana:");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }

    }

}