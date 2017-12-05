using System;

namespace week05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int getal1 = 0, getal2 = 0;
            //int som = Optellen(int getal1, int getal2);
            ToonGetal1(getal1);
            Console.WriteLine("getal: "+getal1);
            ToonGetal2(ref getal1);
            Console.WriteLine("getal: "+getal1);
            ToonGetal3(out getal1);
            Console.WriteLine("getal: "+getal1);
            //Instantie van klasse Voertuig via fields.
            Voertuig v = new Voertuig();
            v.Merk = "BMW";
            //Instantie van klasse Voertuig via constructor met argumenten.
            Voertuig v1 = new Voertuig("VW", 4);

            Wagen w = new Wagen();
            w.Merk = "Fiat";
            w.AantalZitplaatsen = 3;
            w.Kleur = "Blauw";
            w.Model = "500";
        }

        private static void ToonGetal1(int getal)
        {
            getal = 1;            
        }

        private static void ToonGetal2(ref int getal)
        {
            getal = 2;            
        }

        private static void ToonGetal3(out int getal)
        {
            getal = 3;            
        }
        /*
        private static int Optellen(int getal1, int getal2)
        {
        }

        private static int Optellen(int getal1, int getal2, int getal3)
        {
            
        }
         */
        }
    }
}
