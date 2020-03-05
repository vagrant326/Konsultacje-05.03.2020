using System;
using System.Collections.Generic;
using System.Text;

namespace Konsultacje3
{
    //Stwórz klasę Hotel, dziedziczącą z Nocleg ale posiadającą również pole liczbowe Gwiazdki.
    
    public class Hotel: Nocleg
    {
        public int Gwiazdki;

        public override void Opisz()
        {
            base.Opisz();
            Console.WriteLine($"Gwiazdki: {Gwiazdki}");
        }
    }
}
