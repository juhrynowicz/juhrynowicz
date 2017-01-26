using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pizzeria
{
    abstract class Menu
    {
        protected string nazwa;
        protected double cena;
        abstract public string Wyswietl();
    }
}
