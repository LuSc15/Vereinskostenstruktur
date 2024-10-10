using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vereinskostenstruktur
{
    public class SpitzenSportler : AktivesMitglied
    {
        public SpitzenSportler(string name, int aktivitaet) :base(name,aktivitaet)
        {
           
            _einnahmen = 10*12;
            _ausgaben = GetAusgaben(aktivitaet);
                
        }
        public override double GetAusgaben(int aktivitaet)
        {
            return aktivitaet * 5*12;
        }
        public override double GetEinnahmen()
        {
            return _einnahmen;
        }
        public override double GetUeberschuss()
        {
            return _einnahmen - _ausgaben;
        }
    }
}