using System;
using System.Collections.Generic;
using System.Text;

namespace Konsultacje3
{
    //Stwórz klasę Motel dziedziczącą z Nocleg ale posiadającą pola bool Sniadanie i bool WspolnaLazienka. 
    public class Motel: Nocleg
    {
        public bool Sniadanie;
        public bool WspolnaLazienka;

        public override void Opisz()
        {
            base.Opisz();
            string czySniadanie = Sniadanie ? "TAK" : "NIE";
            string czyWspolnaLazienka = WspolnaLazienka ? "TAK" : "NIE";
            Console.WriteLine($"Sniadanie: {czySniadanie}");
            Console.WriteLine($"Wspolna lazienka: {czyWspolnaLazienka}");
        }
    }
}
