using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pizzeria
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pizze> pizze = new List<Pizze>
            {
                new Pizze("Cztery Sery", 25.50),
                new Pizze("Hawajska", 24.60),
                new Pizze("Wiejska", 33.90),
                new Pizze("Miejska", 27.90)
            };
            List<Skladniki> skladniki = new List<Skladniki>
            {
                new Skladniki("papryka", 1.50),
                new Skladniki("cebula",1.20),
                new Skladniki("brokuły",1.70),
                new Skladniki("salami", 1.90),
                new Skladniki("extra ser",1.20),
                new Skladniki("boczek",2.10),
                new Skladniki("szynka",2.10),
                new Skladniki("pomidor",1.30)
            };
            Zamow.WyswietlPizze(pizze);
            Zamow.Oblicz(pizze,skladniki);
            Console.WriteLine(Zamow.Suma);
            Console.ReadKey();
        }
    }
}
