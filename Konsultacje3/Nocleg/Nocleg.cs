using System;
using System.Collections.Generic;
using System.Text;

namespace Konsultacje3
{
    //Stwórz klasę abstrakcyjną Nocleg z polami Nazwa, IloscMiejsc i Cena. 
    public abstract class Nocleg
    {
        public string Nazwa;
        public int IloscMiejsc;
        public double Cena;

        public virtual void Opisz()
        {
            Console.WriteLine($"Nazwa: {Nazwa}");
            Console.WriteLine($"Cena: {Cena}");
            Console.WriteLine($"Ilosc Miejsc: {IloscMiejsc}");
        }
    }
}
