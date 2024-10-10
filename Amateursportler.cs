using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vereinskostenstruktur
{
    public class AmateurSportler : AktivesMitglied
    {
        
        public AmateurSportler(string name, int aktivitaet):base(name,aktivitaet)
        {
            _einnahmen = GetEinnahmen();
            _ausgaben = GetAusgaben(aktivitaet);
        }
        public override double GetAusgaben(int aktivitaet)
        {
            return aktivitaet * 1.5 * 12;
        }
        public override double GetAusgaben()
        {
            return _aktivitaetsGrad * 1.5 * 12;
        }
        public override double GetEinnahmen()
        {
            return 25 * 12;
        }
        public override double GetUeberschuss()
        {
            return base.GetUeberschuss();
        }
    }
}