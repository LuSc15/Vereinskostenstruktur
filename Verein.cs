using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vereinskostenstruktur
{
    public class Verein : Mitglied
    {


        private List<Mitglied> _Mitgliederliste;
        private int _maxMitglieder;

        public Verein(string name, int max) : base(name)
        {
            _maxMitglieder = max;
        }

        public override double GetAusgaben()
        {
            double gesamtAusgaben = 0;
            foreach(Mitglied m in _Mitgliederliste)
            {
                gesamtAusgaben += m.GetAusgaben();
            }
            return gesamtAusgaben;
        }
        public override double GetEinnahmen()
        {
            double gesamtEinnahmen = 0;
            foreach (Mitglied m in _Mitgliederliste)
            {
                gesamtEinnahmen += m.GetEinnahmen();
            }
            return gesamtEinnahmen;
        }
        public override void Ausgabe()
        {
            throw new NotImplementedException();
        }
    }
}