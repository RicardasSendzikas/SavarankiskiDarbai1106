class PilnasEtatas : Darbuotojas
{
    public PilnasEtatas(string vardas, decimal atlyginimas) : base(vardas, atlyginimas) { }

    public decimal GautiMetinįAtlyginimą()
    {
        return Atlyginimas * 12;
    }
}