using System.Collections.Generic;
using System.Linq;
using VartotojuDuomenuAnalize.Core.Contracts;

namespace VartotojuDuomenuAnalize.Core.Services
{
    public class DuomenuServisas : IDuomenuServisas
    {
        public double ApskaiciuotiVidutiniAmziu(List<string> duomenys)
        {
            List<int> amziai = new List<int>();

            foreach (var eilute in duomenys)
            {
                var duomenysSplit = eilute.Split(',');
                if (duomenysSplit.Length == 2 && int.TryParse(duomenysSplit[1], out int amzius))
                {
                    amziai.Add(amzius);
                }
            }

            return amziai.Count > 0 ? amziai.Average() : 0;
        }
    }
}