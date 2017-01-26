using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pizzeria
{
    class Pizze: Menu
    {
        public Pizze(string nazwa, double cena)
        {
            this.cena = cena;
            this.nazwa = nazwa;
        }
        public override string Wyswietl()
        {
            return nazwa + ": " + cena.ToString()+" zł";
        }
        public double Cena
        {
            get
            {
                return this.cena;
            }
            
        }
        public string Nazwa
        {
            get
            {
                return this.nazwa;
            }
            
        }
    }
}
