
//Napisz program, który wypisze na ekranie n liczb pierwszych (jedna pod drugą).
//Liczba pierwsza jest podzielna przez 1 i przez samą siebie (liczby 1 nie uznajemy za liczbę pierwszą).
//Wartość n użytkownik zadaje przy uruchomieniu programu

using System;

class zad1
{
    static bool CzyLiczbaJestPierwsza(int liczba)
    {
        if (liczba < 2) return false;
        for (int i = 2; i * i <= liczba; i++)
        {
            if (liczba % i == 0) return false;
        }
        return true;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Podaj ilość liczb pierwszych do wyświetlenia:");
        int n = int.Parse(Console.ReadLine());
        int liczba = 2;
        while (n > 0)
        {
            if (CzyLiczbaJestPierwsza(liczba))
            {
                Console.WriteLine(liczba);
                n--;
            }
            liczba++;
        }
    }
}
