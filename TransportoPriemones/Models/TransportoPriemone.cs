using System;

class TransportoPriemone
{
    public int Greitis { get; set; }

    public TransportoPriemone(int greitis)
    {
        Greitis = greitis;
    }

    public virtual double ApskaiciuotiKelionesLaika(int atstumas)
    {
        return (double)atstumas / Greitis;
    }
}