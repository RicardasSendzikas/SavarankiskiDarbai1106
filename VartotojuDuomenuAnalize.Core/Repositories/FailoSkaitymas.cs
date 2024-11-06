using System.Collections.Generic;
using System.IO;
using VartotojuDuomenuAnalize.Core.Contracts;

namespace VartotojuDuomenuAnalize.Core.Repositories
{
    public class FailoSkaitymas : IFailoSkaitymas
    {
        public List<string> SkaitytiDuomenis(string failoKelias)
        {
            return new List<string>(File.ReadAllLines(failoKelias));
        }
    }
}