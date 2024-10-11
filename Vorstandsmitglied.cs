using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vereinskostenstruktur
{
    public class Vorstandsmitglied : Mitglied
    {
        private double _kompetenz;
        public Vorstandsmitglied(string name, int kompetenz) :base(name)
        {
            if(kompetenz <= 10 && kompetenz >= 0)
            {
                _kompetenz = kompetenz;
            }
            else
            {
                Console.WriteLine("Ungültiger Kompetenzwert");
            }

        }
        public override double GetEinnahmen()
        {
            return _kompetenz * 100;
        }
        public override double GetAusgaben()
        {
            return GetEinnahmen() * 0.2;
        }

        public override void Ausgabe()
        {
            Console.WriteLine($"{_name,-10} {_einnahmen,-10},{_ausgaben,-10},{_ueberschuss,-10}");
        }
    }
}