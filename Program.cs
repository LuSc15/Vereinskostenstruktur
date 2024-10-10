namespace Vereinskostenstruktur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AmateurSportler A1 = new AmateurSportler("Rolf", 10);
            Console.WriteLine($"Einnahmen:{A1.GetEinnahmen()}");
            Console.WriteLine($"Ausgaben:{A1.GetAusgaben()}");

            Console.WriteLine($"Überschuss:{A1.GetUeberschuss()}"); 
        }
    }
}
