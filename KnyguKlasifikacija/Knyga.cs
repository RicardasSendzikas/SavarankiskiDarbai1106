using System;

class Knyga
{
    public string Pavadinimas { get; set; }
    public int PuslapiuSkaicius { get; set; }

    public void KlasifikuotiKnyga()
    {
        Console.Write("Įveskite knygos pavadinimą: ");
        Pavadinimas = Console.ReadLine();

        Console.Write("Įveskite knygos puslapių skaičių: ");
        PuslapiuSkaicius = int.Parse(Console.ReadLine());

        string tipas;

        if (PuslapiuSkaicius < 100)
        {
            tipas = "Trumpa";
        }
        else if (PuslapiuSkaicius <= 300)
        {
            tipas = "Vidutinė";
        }
        else
        {
            tipas = "Ilga";
        }

        Console.WriteLine($"Knyga \"{Pavadinimas}\" yra {tipas}.");
    }
}