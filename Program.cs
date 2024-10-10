namespace Vereinskostenstruktur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AmateurSportler A1 = new AmateurSportler("Rolf", 50);
            Console.WriteLine(A1.GetUeberschuss()); 
        }
    }
}
