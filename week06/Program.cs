using System;

namespace week06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // maak een nieuwe instantie van de klasse "book"
            Book a = new Book("Jonkvrouw ", "Jean-Claude van Rijckeghem ", 9.95, 10);
            Console.WriteLine("Naam van het boek: " + a.Bookname + "Auteur: " + a.AuthorName + "prijs: €" + a.Price + " In Stock: " + a.QtyInStock);

        }
    }
}
