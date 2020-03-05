using System;
using System.Collections.Generic;
using System.Text;

namespace Konsultacje3.ZDrukarka
{
    // Stwórz klasę Drukarka. Dodaj do klasy pole typu enum Stan.
    // Dodaj do klasy metodę Drukuj, która przyjmie tekst i wypisze go, jeśli Stan to Dziala.
    // Jeśli Stan jest inny, powinna wypisywać stosowny komunikat.
    // Po poprawnym wydruku dodaj jednocześnie 2 dowolne awarie i wywołaj metodę jeszcze raz.
    public class Drukarka
    {
        public Stan Stan;

        public void Drukuj(string tekst)
        {
            if (Stan.HasFlag(Stan.BrakCzarnegoTuszu))
            {
                Console.WriteLine("Brak czarnegu tuszu");
            }
            if (Stan.HasFlag(Stan.BrakNiebieskiegoTuszu))
            {
                Console.WriteLine("Brak niebieskiego tuszu");
            }
            if (Stan.HasFlag(Stan.BrakZoltegoTuszu))
            {
                Console.WriteLine("Brak zoltego tuszu");
            }
            if (Stan.HasFlag(Stan.BrakRozowegoTuszu))
            {
                Console.WriteLine("Brak rozowego tuszu");
            }
            if (Stan.HasFlag(Stan.BrakPapieru))
            {
                Console.WriteLine("Brak papieru");
            }
            if (Stan.HasFlag(Stan.ZacietyPapier))
            {
                Console.WriteLine("Papier zaciety");
            }

            if (Stan == Stan.Dziala)
            {
                Console.WriteLine(tekst);
                Stan = Stan.BrakRozowegoTuszu | Stan.ZacietyPapier;
            }
        }
    }

    //Stan może przyjmować wartości: Dziala, BrakPapieru, BrakCzarnegoTuszu, BrakRozowegoTuszu, BrakNiebieskiegoTuszu, BrakZoltegoTuszu i ZacietyPapier. Wszystkie stany, z wyjątkiem Dziala nie wykluczają się. 
    [Flags]
    public enum Stan
    {
        Dziala = 0,                 //[000000]
        BrakPapieru = 1,            //[000001]
        BrakCzarnegoTuszu = 2,      //[000010]
        BrakRozowegoTuszu = 4,      //[000100]
        BrakZoltegoTuszu = 8,       //[001000]
        BrakNiebieskiegoTuszu = 16, //[010000]
        ZacietyPapier = 32          //[100000]
    }
}
