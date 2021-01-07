using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autoverseny
{
    class Program
    {
        /*2.	Olvassa be az autoverseny.csv állomány sorait 
         * és tárolja az adatokat egy olyan összetett adatszerkezetben (pl. vektor, lista stb.), 
         * amely használatával a további feladatok megoldhatók! 
         * Ügyeljen arra, hogy az állomány első sora az adatok fejlécét tartalmazza !
         * a versenyző csapatának a neve (csapat), például: Versenylovak 
         * a versenyző neve (versenyzo), például: Fürge Ferenc
         * versenyző életkora (eletkor): például: 29
         * a versenypálya neve (palya), például: Gran Prix Circuit
         * a köridó (korido) óra perc:másodperc formátumban, ahol minden adat két karakterre előnullázva (vezető nullákkal) jelenik meg, például: 00:01 : 1 1
         * melyik körben futotta az időt a versenyző (kor), például: 1*/
        struct verseny//Készítsen összetett változót az adatok tárolására!
        {
            public string csapat;
            public string versenyzo;
            public int eletkor;
            public string palya;
            public string korido;
            public int kor;            
        }
        static verseny[] adatok = new verseny[4000];//Az állományban legfeljebb 4000 sor lehet. 
        static void Main(string[] args)
        {
            string[] fajlbol = File.ReadAllLines("autoverseny.csv");
            int sorokszama = 0;//sorok száma a fájlban
            int i, j;//ciklusváltozó
            for (int k = 1; k < fajlbol.Count(); k++)//Ügyeljen arra, hogy az állomány első sora az adatok fejlécét tartalmazza!
            {
                string[] egysordarabolva = fajlbol[k].Split(';');//Az adatokat pontosvessző választja el.
                adatok[sorokszama].csapat = egysordarabolva[0];
                adatok[sorokszama].versenyzo = egysordarabolva[1];
                adatok[sorokszama].eletkor = Convert.ToInt32(egysordarabolva[2]);
                adatok[sorokszama].palya = egysordarabolva[3];
                adatok[sorokszama].korido = egysordarabolva[4];
                adatok[sorokszama].kor = Convert.ToInt32(egysordarabolva[5]);
                sorokszama++;
            }
            int adatokszama = sorokszama;
            /*
            Console.WriteLine("Az adatok listája fájlból");

            Console.WriteLine("csapat                  versenyzo     eletkor     palya              korido     kor");
            for (i = 0; i < adatokszama; i++)
            {
                Console.WriteLine("{0,-20} {1,-20} {2,-5} {3,-20} {4,-10} {5}", adatok[i].csapat, adatok[i].versenyzo, adatok[i].eletkor, adatok[i].palya, adatok[i].korido, adatok[i].kor);
            }*/
            //3.	Határozza meg és írja ki a képernyőre a minta szerint, hogy hány sornyi adat található a forrásállományban!
            Console.WriteLine("3. feladat:  {0}", adatokszama);
            //4.	Határozza meg és írja ki a minta szerint, 
            //hogy Fürge Ferenc a Gran Prix Circuit pályán futott 3. körét hány másodperc alatt tudta teljesíteni!
            //keresés tétele
            Boolean van = true;
            int masodperc;            
            i = 0;
            while ((i < adatokszama) && (adatok[i].versenyzo=="Fürge Ferenc") && (adatok[i].palya=="Gran Prix Circuit") && (adatok[i].kor!=3))
            {
                i++; 
            }
            van = i < adatokszama ? true : false;
            if (van)
            {
                string[] idoeredmeny = adatok[i].korido.Split(':');//Az adatokat pontosvessző választja el.
                int perc= Convert.ToInt32(idoeredmeny[1]);
                int mp= Convert.ToInt32(idoeredmeny[2]);
                masodperc = perc * 60 + mp;
                Console.WriteLine("4. feladat: {0} másodperc", masodperc);
            }

            else
                Console.WriteLine("4. feladat: Nincs ilyen elem az adatforrásban! ");
            //5.	Kérjen be a felhasználótól a minta szerint egy nevet!
            Console.WriteLine("5. feladat\nKérem egy versenyző nevét:");
            string versenyzonev = Console.ReadLine();
            /*6.	Keresse meg és írja ki a képernyőre a minta szerint, 
             * hogy az előző feladatban bekért versenyző hol és mennyi idő alatt futotta a leggyorsabb körét! 
             * Feltételezheti, hogy a legjobb köridőkben nincs holtverseny. 
             * Ha a versenyző nem található meg az adatok közt, 
             * akkor a „Nincs ilyen versenyző az állományban!” szöveget írja ki a képernyőre!*/
            //minimum kiválasztás tétele
            string min = adatok[0].korido;
            int mini = 0;
            van = false; 
            for (i = 0; i < adatokszama; i++)
            {
                if (adatok[i].versenyzo == versenyzonev)
                {
                    van = true;
                    int x = String.Compare(adatok[i].korido, min);
                    if ( x< 0)
                    {
                        mini = i;
                        min = adatok[i].korido;
                    }
                }
            }
            if (van)
            {
                Console.WriteLine("6. feladat: {0} {1}",adatok[mini].palya,adatok[mini].korido);
            }
            else
            {
                Console.WriteLine("6. feladat: Nincs ilyen versenyző az állományban!");
            }

                Console.ReadKey();
        }
    }
}
