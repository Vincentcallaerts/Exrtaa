using System;


namespace Exrtaa
{
    class Program
    {
        static void Main(string[] args)
        {
            string naam, voornaam, straat, nummer, stad, postcode;


            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Geef je naam in: ");
            Console.ForegroundColor = ConsoleColor.Green;
            naam = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Geef je voornaam in: ");
            Console.ForegroundColor = ConsoleColor.Green;
            voornaam = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Geef je Straatnaam in: ");
            Console.ForegroundColor = ConsoleColor.Green;
            straat = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Geef je huisnummer in: ");
            Console.ForegroundColor = ConsoleColor.Green;
            nummer = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Geef je stadsnaam in: ");
            Console.ForegroundColor = ConsoleColor.Green;
            stad = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Geef je postcode in: ");
            Console.ForegroundColor = ConsoleColor.Green;
            postcode = Console.ReadLine();
            
            Console.WriteLine();
            Console.WriteLine($"Naam: {voornaam} {naam}");
            Console.WriteLine($"Straat: {straat} {nummer}, {postcode} {stad}");
           
            Console.ReadLine();
        }
    }
}
