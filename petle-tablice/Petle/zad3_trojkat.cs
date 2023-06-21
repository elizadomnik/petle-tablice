// Napisz program, który „narysuje” na ekranie trójkąt złożony ze znaków „+” (patrz przykład).
// Wysokość trójkąta (liczba wierszy) powinna być podana przez użytkowania przed rysowaniem.
// W każdym wierszu powinno być o 2 znaki więcej niż w poprzednim.
// Każdy kolejny wiersz powinien zaczynać się na ekranie wcześniej, tak że najdłuższy wiersz zaczyna się przy krawędzie ekranu.
// Znak + w wierszu pierwszym musi być na środku powstałej figury.

using System;

class zad3
{
    static void Main()
    {
        Console.WriteLine("Podaj wysokość trójkąta:");
        int wysokosc = int.Parse(Console.ReadLine());

        for (int i = 1; i <= wysokosc; i++)
        {
            for (int j = 1; j <= wysokosc - i; j++)
            {
                Console.Write("W");
            }
            for (int j = 1; j <= 2 * i - 1; j++)
            {
                Console.Write("+");
            }
            Console.WriteLine();
        }
    }
}