
using System;

Console.OutputEncoding = System.Text.Encoding.UTF8;

while (true)
{
    Console.Clear();
    Console.WriteLine("=== RapidPack – Wycena Paczki ===\n");

    Console.Write("Podaj wagę (kg): ");
    double waga = double.Parse(Console.ReadLine()!);

    if (waga > 30)
    {
        Console.WriteLine("\nBŁĄD: Paczka za ciężka! Maksymalnie 30 kg.");
        Console.WriteLine("\nNaciśnij Enter, aby spróbować ponownie...");
        Console.ReadLine();
        continue;
    }

    Console.Write("Wysokość (cm): ");
    double wysokosc = double.Parse(Console.ReadLine()!);

    Console.Write("Szerokość (cm): ");
    double szerokosc = double.Parse(Console.ReadLine()!);

    Console.Write("Głębokość (cm): ");
    double glebokosc = double.Parse(Console.ReadLine()!);

    Console.WriteLine("\nTyp przesyłki:");
    Console.WriteLine("  1 - Standardowa");
    Console.WriteLine("  2 - Ostrożnie (szkło) +10 zł");
    Console.WriteLine("  3 - Paleta (stała cena 100 zł)");
    Console.Write("Wybór (1/2/3): ");
    string typ = Console.ReadLine()!.Trim();

    Console.Write("\nEkspres +15 zł? (t/n): ");
    bool ekspres = Console.ReadLine()!.Trim().ToLower() == "t";

    double cena;
    string opis;

    if (typ == "3")
    {
        cena = 100;
        opis = "Paleta (cena stała)";
    }
    else
    {
        cena = 10 + (waga * 2);

        if (typ == "2")
        {
            cena += 10;
            opis = "Ostrożnie (szkło)";
        }
        else
        {
            opis = "Standardowa";
        }

        if (wysokosc + szerokosc + glebokosc > 150)
        {
            cena *= 1.5;
            opis += " + GABARYT";
        }
    }

    if (ekspres)
        cena += 15;


    Console.WriteLine("\n--- PODSUMOWANIE ---");
    Console.WriteLine($"Typ:     {opis}");
    Console.WriteLine($"Waga:    {waga} kg");
    Console.WriteLine($"Wymiary: {wysokosc}x{szerokosc}x{glebokosc} cm");
    Console.WriteLine($"Ekspres: {(ekspres ? "TAK" : "NIE")}");
    Console.WriteLine($"\nCENA:    {cena} zł");
    Console.WriteLine("--------------------");

    Console.WriteLine("\nNaciśnij Enter, aby wycenić kolejną paczkę...");
    Console.ReadLine();
}