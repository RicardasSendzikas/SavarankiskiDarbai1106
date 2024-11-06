class Program
{
    static void Main(string[] args)
    {
        Console.Write("Įveskite darbuotojo tipą (PilnasEtatas/PuseEtato): ");
        string tipas = Console.ReadLine();

        Console.Write("Įveskite darbuotojo vardą: ");
        string vardas = Console.ReadLine();

        Console.Write("Įveskite atlyginimą: ");
        decimal atlyginimas = decimal.Parse(Console.ReadLine());

        Darbuotojas darbuotojas;

        if (tipas.ToLower() == "pilnasetatas")
        {
            darbuotojas = new PilnasEtatas(vardas, atlyginimas);
            Console.WriteLine($"Darbuotojas {darbuotojas.Vardas} metinis atlyginimas: {((PilnasEtatas)darbuotojas).GautiMetinįAtlyginimą()}.");
        }
        else if (tipas.ToLower() == "puseetato")
        {
            darbuotojas = new PuseEtato(vardas, atlyginimas);
            Console.WriteLine($"Darbuotojas {darbuotojas.Vardas} valandinis atlyginimas: {((PuseEtato)darbuotojas).GautiValandinįAtlyginimą()}.");
        }
        else
        {
            Console.WriteLine("Neteisingas darbuotojo tipas.");
        }
    }
}