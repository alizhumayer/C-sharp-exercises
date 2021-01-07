using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Mukorcsolya
{
    class Mukorcsolya
    {
        string nev;
        string orszagkod;
        double tpont;
        double kpont;
        byte hibapont;

        public string Nev 
        {
            get => nev;
            set => nev = value;
        }

        public string Orszagkod
        {
            get => orszagkod;
            set => orszagkod = value;
        }

        public double Tpont
        {
            get => tpont;
            set => tpont = value;
        }

        public double Kpont
        {
            get => kpont;
            set => kpont = value;
        }

        public byte Hibapont
        {
            get => hibapont;
            set => hibapont = value;
        }

        public Mukorcsolya(string egysor)
        {
            // Konstruktor készítés string típusú paraméterrel            
            // Készítünk egy "adatok" nevű string tömböt, amit feltöltünk, és ;-el elválasztjuk őket.
            // Ezt követően szétdaraboljuk őket a ; mentén.
            // FONTOS, HOGY A "."-T KICSERÉLJÜK ","-RE, mert ezt kéri a feladat!
            string[] adatok = egysor.Split(';');
            nev = adatok[0];
            orszagkod = adatok[1];
            tpont = double.Parse(adatok[2].Replace('.', ','));
            kpont = double.Parse(adatok[3].Replace('.', ','));
            hibapont = byte.Parse(adatok[4]);
        }
    }
}
