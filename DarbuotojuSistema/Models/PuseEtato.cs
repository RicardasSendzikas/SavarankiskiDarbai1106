class PuseEtato : Darbuotojas
{
    public PuseEtato(string vardas, decimal atlyginimas) : base(vardas, atlyginimas) { }

    public decimal GautiValandinįAtlyginimą()
    {
        return Atlyginimas / 160;
    }
}