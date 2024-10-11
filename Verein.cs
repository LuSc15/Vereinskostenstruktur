using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vereinskostenstruktur
{
    public class Verein : Mitglied
    {


        private List<Mitglied> _Mitgliederliste = new List<Mitglied>();
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
            _ausgaben = gesamtAusgaben;
            return gesamtAusgaben;
        }
        public override double GetEinnahmen()
        {
            double gesamtEinnahmen = 0;
            foreach (Mitglied m in _Mitgliederliste)
            {
                gesamtEinnahmen += m.GetEinnahmen();
            }
            _einnahmen = gesamtEinnahmen;
            return gesamtEinnahmen;
        }
        public override void Ausgabe()
        {
            
            Console.WriteLine($"Vereinsname: {_name}");
            Console.WriteLine($"{"Name",-10}{"Einnahmen",10}{"Ausgaben",10}{"Überschuss",15}");
            foreach (Mitglied m in _Mitgliederliste)
            {
                Console.WriteLine($"{m.getName(),-12}{m.GetEinnahmen(),-10}{m.GetAusgaben(),-10}{m.GetUeberschuss(),6}");
            }
            Console.WriteLine($"{"Gesamt:",-12}{this.GetEinnahmen(),-10} €{this.GetAusgaben(),-10} €{this.GetUeberschuss(),6} €\n");
        }
        public void MitgliedHinzufuegen(Mitglied mitglied)
        { 
            if(_Mitgliederliste.Count < _maxMitglieder)
            {
                _Mitgliederliste.Add(mitglied);
                Console.WriteLine($"{mitglied.getName()} ist dem Verein {this._name} beigetreten.");
            }
            else
            {
                Console.WriteLine($"{mitglied.getName()} konnte nicht beitreten: {this._name} ist voll.");
            }
        
        }
    }
}