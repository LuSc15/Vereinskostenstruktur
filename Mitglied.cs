using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vereinskostenstruktur
{
    public abstract class Mitglied
    {
        private static int _mitgliedsnummer;
        protected string _name;
        protected double _einnahmen;
        protected double _ausgaben;
        protected double _ueberschuss;

        public Mitglied(string name)
        { _name = name; }

        public int returnMitgliedsnummer()
        { return _mitgliedsnummer;}

        public abstract double GetEinnahmen();

        public string getName()
        { return _name; }

        public virtual double GetAusgaben(int aktivitaet)
        { return 0; }
        public virtual double GetAusgaben()
        { return 0; }
        public virtual double GetUeberschuss()
        { return 0; }

        public abstract void Ausgabe();
    }

  
   
}