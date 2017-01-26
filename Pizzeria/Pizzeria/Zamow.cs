using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace Pizzeria
{
    static class Zamow
    {
        static private double suma=0;
        static private int liczbaPizz;
        static public void WyswietlPizze(List<Pizze> pizze)
        {
            Console.WriteLine("Witamy w naszej pizzeri poniżej znajduje się menu z pizzami, proszę wybrać nr");
            liczbaPizz = pizze.Count + 1;
            int i=1;
            foreach (var p in pizze)
            {
                Console.WriteLine("{0}. " + p.Wyswietl(), i);
                i++;
            }
            Console.WriteLine("{0}. Stworzenie własnej pizzy\n", liczbaPizz);
        }
        static public void WyswietlSkladniki(List<Skladniki> skladniki)
        {
            int i = 1;
            foreach (var s in skladniki)
            {
                Console.WriteLine("{0}. " + s.Wyswietl(), i);
                i++;
            }
        }
        static public void Oblicz(List<Pizze> pizze,List<Skladniki> skladniki)
        {
            string wybor;
            wybor = Convert.ToString(Console.ReadLine());
            try
            {
                if (int.Parse(wybor) != liczbaPizz)
                {
                    suma += pizze[int.Parse(wybor) - 1].Cena;
                    Console.WriteLine("Wybrałeś {0}", pizze[int.Parse(wybor) - 1].Nazwa);
                }
                else
                {
                    suma += 15;
                    Console.WriteLine("Wybierz nr składników\n");
                    WyswietlSkladniki(skladniki);
                    wybor = Convert.ToString(Console.ReadLine());
                    while (wybor != "q")
                    {
                        Console.WriteLine("Wybrałeś {0}", skladniki[int.Parse(wybor) - 1].Nazwa);
                        Console.WriteLine("Jeżeli zakończyłeś wybieranie składników nacisnij Q");
                        suma += skladniki[int.Parse(wybor) - 1].Cena;
                        wybor = Convert.ToString(Console.ReadLine());
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        static public string Suma
        {
            get
            {
                return "Koszt całkowity: " + Zamow.suma + " zł";
            }
            
        }
    }
}
