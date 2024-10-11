using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vereinskostenstruktur
{
    public abstract class Mitglied
    {
        private static List<int>VergebeneNummern=new List<int>();
        static Random rnd = new Random();
        private static int _mitgliedsnummer;
        protected string _name;
        protected double _einnahmen;
        protected double _ausgaben;
        protected double _ueberschuss;

        public Mitglied(string name)
        { 
            _name = name;

            int nummer = rnd.Next(100000, 999999);
            bool abbruch = false;
            while(abbruch == false)
            {
                abbruch = false;
                for (int i = 0; i < VergebeneNummern.Count; i++)
                {
                    if (nummer == VergebeneNummern[i])
                    {
                        abbruch = true;
                        nummer = rnd.Next(100000, 999999);
                        break;
                    }
                }
                if (abbruch == false)
                {
                    _mitgliedsnummer = nummer;
                    break;
                }
            }

            
           
        }

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
        { return _einnahmen - _ausgaben; }

        public abstract void Ausgabe();
    }

  
   
}