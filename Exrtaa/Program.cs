using System;


namespace Exrtaa
{
    class Program
    {
        static void Main(string[] args)
        {
            string naam, voornaam, straat, nummer, stad, postcode;
            Console.WriteLine("Geef je naam in: ");
            naam = Console.ReadLine();
            Console.WriteLine("Geef je voornaam in: ");
            voornaam = Console.ReadLine();
            Console.WriteLine("Geef je Straatnaam in: ");
            straat = Console.ReadLine();
            Console.WriteLine("Geef je huisnummer in: ");
            nummer = Console.ReadLine();
            Console.WriteLine("Geef je stadsnaam in: ");
            stad = Console.ReadLine();
            Console.WriteLine("Geef je postcode in: ");
            postcode = Console.ReadLine();
            
            Console.WriteLine();
            Console.WriteLine($"Naam: {voornaam} {naam}");
            Console.WriteLine($"Straat: {straat} {nummer}, {postcode} {stad}");
           
            Console.ReadLine();
        }
    }
}
