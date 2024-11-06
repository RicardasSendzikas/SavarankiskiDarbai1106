class Program
{
    static void Main(string[] args)
    {
        Console.Write("Pasirinkite transporto priemonės tipą (Automobilis/Dviratis): ");
        string tipas = Console.ReadLine();

        Console.Write("Įveskite greitį (km/h): ");
        int greitis = int.Parse(Console.ReadLine());

        Console.Write("Įveskite kelionės atstumą (km): ");
        int atstumas = int.Parse(Console.ReadLine());

        TransportoPriemone transportoPriemone;

        if (tipas.ToLower() == "automobilis")
        {
            transportoPriemone = new Automobilis(greitis);
        }
        else if (tipas.ToLower() == "dviratis")
        {
            transportoPriemone = new Dviratis(greitis);
        }
        else
        {
            Console.WriteLine("Neteisingas transporto priemonės tipas.");
            return;
        }

        double kelionesLaikas = transportoPriemone.ApskaiciuotiKelionesLaika(atstumas);
        Console.WriteLine($"Kelionės laikas su {tipas}: {kelionesLaikas:F2} valandos.");
    }
}