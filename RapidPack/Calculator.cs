using System;

Console.OutputEncoding = System.Text.Encoding.UTF8;
 
Console.WriteLine("=== RapidPack – Wycena Paczki ===\n");
 
Console.Write("Podaj wagę (kg): ");
double waga = double.Parse(Console.ReadLine()!);
 

if (waga > 30)
{
    Console.WriteLine("\nBŁĄD: Paczka za ciężka! Maksymalnie 30 kg.");
    return;
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
 
Console.WriteLine("\nDane wczytane poprawnie!");