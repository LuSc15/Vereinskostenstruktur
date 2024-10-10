using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vereinskostenstruktur
{
    public class Vorstandsmitglied : Mitglied
    {
        public Vorstandsmitglied(string name) :base(name)
        {

        }
        public override double GetEinnahmen()
        {
            throw new NotImplementedException();
        }
        public override double GetAusgaben()
        {
            return base.GetAusgaben();
        }

        public override void Ausgabe()
        {
            throw new NotImplementedException();
        }
    }
}