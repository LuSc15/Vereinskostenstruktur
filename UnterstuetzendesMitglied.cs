using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vereinskostenstruktur
{
    public class UnterstuetzendesMitglied : Mitglied
    {
        public UnterstuetzendesMitglied(string name):base(name) 
        {
        }
        public override void Ausgabe()
        {
            throw new NotImplementedException();

        }

        public override double GetAusgaben()
        {
            return base.GetAusgaben();
        }
        public override double GetEinnahmen()
        {
            throw new NotImplementedException();
        }
    }
}