using System.Collections.Generic;

namespace VartotojuDuomenuAnalize.Core.Contracts
{
    public interface IFailoSkaitymas
    {
        List<string> SkaitytiDuomenis(string failoKelias);
    }
}