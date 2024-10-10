using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vereinskostenstruktur
{
    public abstract class AktivesMitglied : Mitglied
    {
        private double _monatlicherBeitrag;
        private int _aktivitaetsGrad;
        private double _ausgaben;

        public AktivesMitglied(string name, int aktivitaet):base(name)
        {
            if(aktivitaet > 10) aktivitaet = 10;
            if(aktivitaet < 0) aktivitaet = 0;
            _aktivitaetsGrad = aktivitaet;
            _monatlicherBeitrag = 10.00;
            _ausgaben = _aktivitaetsGrad * 5;
            
            
        }

        public abstract override double GetAusgaben(int aktivitaet);
        

     

        public override double GetEinnahmen()
        {
            return 0;
        }
        public override double GetUeberschuss()
        {
            return 0;
        }
        
        public override void Ausgabe()
        {
            Console.WriteLine($"{_name,-10} {_einnahmen,-10},{_ausgaben,-10},{_ueberschuss,-10}" );
        }
    }
}