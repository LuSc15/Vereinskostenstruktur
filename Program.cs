namespace Vereinskostenstruktur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AmateurSportler A1 = new AmateurSportler("Rolf", 10);
            AmateurSportler A2 = new AmateurSportler("Frank", 10);
            AmateurSportler A3 = new AmateurSportler("Merlin", 10);
            Verein V1 = new Verein("Kleingarten eV", 2);
            V1.MitgliedHinzufuegen(A1);
            V1.MitgliedHinzufuegen(A2);
            V1.MitgliedHinzufuegen(A3);
            V1.Ausgabe();

            Console.WriteLine($"Einnahmen:{A1.GetEinnahmen()}");
            Console.WriteLine($"Ausgaben:{A1.GetAusgaben()}");

            Console.WriteLine($"Überschuss:{A1.GetUeberschuss()}"); 
        }
    }
}
