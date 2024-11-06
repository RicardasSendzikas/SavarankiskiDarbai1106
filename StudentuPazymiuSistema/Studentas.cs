using System;

class Studentas
{
    public string Vardas { get; set; }
    public int Pazymys { get; set; }

    public void NustatytiIvertinima()
    {
        Console.Write("Įveskite studento vardą: ");
        Vardas = Console.ReadLine();

        Console.Write("Įveskite studento pažymį (nuo 1 iki 10): ");
        Pazymys = int.Parse(Console.ReadLine());

        string ivertinimas;

        if (Pazymys < 1 || Pazymys > 10)
        {
            Console.WriteLine("Prašome įvesti pažymį tarp 1 ir 10.");
            return;
        }

        if (Pazymys < 4)
        {
            ivertinimas = "Neišlaikė";
        }
        else if (Pazymys >= 4 && Pazymys <= 6)
        {
            ivertinimas = "Patenkinamas";
        }
        else if (Pazymys >= 7 && Pazymys <= 8)
        {
            ivertinimas = "Geras";
        }
        else
        {
            ivertinimas = "Labai geras";
        }

        Console.WriteLine($"Studentas {Vardas} įvertinimas: {ivertinimas}.");
    }
}