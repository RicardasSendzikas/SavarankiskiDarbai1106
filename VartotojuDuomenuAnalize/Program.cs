using System;
using System.Collections.Generic;
using System.IO;
using VartotojuDuomenuAnalize.Core.Contracts;
using VartotojuDuomenuAnalize.Core.Repositories;
using VartotojuDuomenuAnalize.Core.Services;

namespace VartotojuDuomenuAnalize
{
    class Program
    {
        static void Main(string[] args)
        {
            IFailoSkaitymas failoSkaitymas = new FailoSkaitymas();
            IDuomenuServisas duomenuServisas = new DuomenuServisas();

            Console.WriteLine("Įveskite vartotojus į vartotojai.txt");
            string failoKelias = @"C:\Users\ricar\source\repos\SavarankiskiDarbai1106\VartotojuDuomenuAnalize.Core\Repositories\vartotojai.txt";

            try
            {
                List<string> duomenys = failoSkaitymas.SkaitytiDuomenis(failoKelias);
                double vidutinisAmzius = duomenuServisas.ApskaiciuotiVidutiniAmziu(duomenys);

                Console.WriteLine($"Vartotojų amžiaus vidurkis: {vidutinisAmzius:F2}");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Klaida: Nurodytas failas nerastas. Patikrinkite, ar failo kelias yra teisingas.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Įvyko klaida: {ex.Message}");
            }
        }
    }
}