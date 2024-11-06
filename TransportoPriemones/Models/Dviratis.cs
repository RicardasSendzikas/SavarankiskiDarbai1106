class Dviratis : TransportoPriemone
{
    public Dviratis(int greitis) : base(Math.Min(greitis, 20)) { } // Apribojame greitį iki 20

    public override double ApskaiciuotiKelionesLaika(int atstumas)
    {
        return base.ApskaiciuotiKelionesLaika(atstumas);
    }
}