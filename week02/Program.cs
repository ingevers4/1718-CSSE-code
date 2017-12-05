using System;

namespace week02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //integer = int
            //een variable die nog niet gebruikt wordt wordt in het groen onderlijnd

            int getal;
            getal = 10;

            int getal1 = 5;
            Console.WriteLine(getal);
            Console.WriteLine(getal1);

            //byte: dit kunnen we gebruiken voor een binaire, hexadecimale waarde 

            byte byteWaarde1 = 105; //decimaal
            byte byteWaarde2 = 0x00C8; //hexadecimaal
            byte byteWaarde3 = 0b100_1000; //binair

            //Console.WriteLine("decimaal: {0}; hexadecimaal: {1}; binair: {3};", byteWaarde1, byteWaarde2, byteWaarde3);


            Console.WriteLine(byte.MaxValue);
            Console.WriteLine(byte.MinValue);

            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);

            Console.WriteLine(float.MaxValue);
            Console.WriteLine(float.MinValue);

            Console.WriteLine(typeof(float));
            Console.WriteLine(default(float));


            Console.WriteLine(typeof(byte));
            Console.WriteLine(typeof(Byte));
            Console.WriteLine(default(byte));

            byte a = 15, b = 10;
            //hier moet je meegeven aan de waarde dat het een byte moet blijven. 
            byte som = (byte)(a + b);

            

            Console.WriteLine(som);

            Console.WriteLine("Geef een getal in:");
            int getal2 = Convert.ToInt32(Console.ReadLine());
            
            if(getal2 == 10) {
                Console.WriteLine("Getal is gelijk aan 10 ");
            }

            //eenvoudige controle
            if(getal2 < 10) {
                Console.WriteLine("Getal is kleiner dan 10");
            } else {
                Console.WriteLine("Getal is groter of gelijk aan 10");
            }


            //wat is een sequentie= opeenvolging van opdrachten. 
        }
    }
}
