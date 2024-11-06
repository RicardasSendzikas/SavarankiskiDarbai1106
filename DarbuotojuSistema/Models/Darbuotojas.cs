using System;

class Darbuotojas
{
    public string Vardas { get; set; }
    public decimal Atlyginimas { get; set; }

    public Darbuotojas(string vardas, decimal atlyginimas)
    {
        Vardas = vardas;
        Atlyginimas = atlyginimas;
    }
}