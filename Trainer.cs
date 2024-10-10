using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vereinskostenstruktur
{
    public class Trainer : AktivesMitglied
    {

        public Trainer(string name, int aktivitaet):base(name,aktivitaet)
        {

        }
        public override double GetAusgaben(int aktivitaet)
        {
            throw new NotImplementedException();
        }
    }
}