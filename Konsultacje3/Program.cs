using System;
using System.Collections.Generic;
using System.Linq;
using Konsultacje3.ZDrukarka;

namespace Konsultacje3
{
    class Program
    {
        // W głównej części programu stwórz listę typu Nocleg i dodaj do niej po jednym obiekcie każdej konkretnej klasy wypełnionego dowolnymi danymi. 
        // Wczytaj od użytkownika nazwę, wyszukaj nocleg o tej nazwie i wypisz jego wszystkie informacje.
 
        static void Main(string[] args)
        {
            #region Nocleg
            /*
            List<Nocleg> noclegi = new List<Nocleg>();
            noclegi.Add(new Hotel() { Nazwa = "Hotel", Cena = 100.0, IloscMiejsc = 10, Gwiazdki = 3 });
            noclegi.Add(new Pensjonat() { Nazwa = "Pensjonat", Cena = 100.0, IloscMiejsc = 10, OpisTurystyczny = "Piekny pensjonat" });
            noclegi.Add(new Motel() { Nazwa = "Motel", Cena = 100.0, IloscMiejsc = 10, Sniadanie = true, WspolnaLazienka = false });

            Console.WriteLine("Wpisz nazwe noclegu");
            string nazwa = Console.ReadLine();

            var nocleg = noclegi.Where(x => x.Nazwa == nazwa).FirstOrDefault();

            if (nocleg == null)
            {
                Console.WriteLine("nie znaleziono takiego noclegu");
                return;
            }

            nocleg.Opisz();
            */
            #endregion
            var drukarka = new Drukarka();
            drukarka.Drukuj("test");
            drukarka.Drukuj("test");
        }
    }
}
