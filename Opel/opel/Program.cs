using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opel
{
    class Program
    {

        /*Egy Opel gyűjtő adatbázisba rendezte az ismert Opel típusok adatait. 
         * Legfeljebb 2000 autóról vannak információi, melyeket az opel.txt UTF-8 kódolású, 
         * tabulátorral tagolt állományban tárolt el. 
         * Készítsen programot Opelek néven, melynek segítségével kezelheti ezeket az adatokat.
Az állomány minden sora egy-egy autó legfontosabb adatait tartalmazza tabulátorral elválasztva egymástól.
pl: Admiral B 2.8	1969	5	2784	0	1495
Az adatos sorrendben a következőek:
	A típus neve. Pl.: Admiral B 2.8
	Melyik évben kezdték el gyártani. Pl. 1969
	Az ülések száma. Pl.: 5
	A motor hengerűrtartalma cm3-ben. Pl.: 2784
	Gyorsulás. Az adat azt mutatja, hogy az autó hány másodperc alatt képes elérni 0-ról 100 km/h sebességet. Pl.: 8,8 Amennyiben az adat nem ismert, 0 szerepel az adatbázisban.
	Az autó önsúlya kg-ban. Pl: 1495 Amennyiben az adat nem ismert, 0 szerepel az adatbázisban.
*/

        struct opelek
        {
            public string tipus;
            public int kezdet;
            public int ulesek;
            public int henger;
            public double gyors;
            public int suly;
        }
        static opelek[] adatok = new opelek[2100];

        /*3.	Sportautónak azokat a gépjárműveket tekintjük, melyek 2 ülésesek 
             * és legalább 2000 cm3 a motor hengerűrtartalma. 
             * Készítsen logikai értékkel visszatérő függvényt vagy metódust Sportauto néven, 
             * mely igaz értékkel tér vissza, ha az autó sportautó, hamissal egyébként. 
             * Ügyeljen arra, hogy a függvény minden szükséges paramétert megkapjon!*/

        static bool Sportauto(int ulesekszama, int cm3)
        {
            if (ulesekszama>=2 && cm3>=2000)
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
            /*1.	Olvassa be az adatokat egy megfelelő adatszerkezetbe! 
             * Jelenítse meg a képernyőn a legutolsó sorban szereplő autó adatait a minta szerint!
1. feladat: 
Az utolsó autó típusa: Zafira B (facelift 2008) 1.7 DTR EcoFLEX	 
2010-es, 5 üléses modell.
*/

            string[] fajlbol = File.ReadAllLines("opel.txt");

            int sorokszama = 0;//sorok száma a fájlban
            int i;//ciklusváltozó
            for (int k = 0; k < fajlbol.Count(); k++)
            {
                string[] egysordarabolva = fajlbol[k].Split('\t');
                adatok[sorokszama].tipus = egysordarabolva[0];
                adatok[sorokszama].kezdet = Convert.ToInt32(egysordarabolva[1]);
                adatok[sorokszama].ulesek = Convert.ToInt32(egysordarabolva[2]);
                adatok[sorokszama].henger = Convert.ToInt32(egysordarabolva[3]);
                adatok[sorokszama].gyors = Convert.ToDouble(egysordarabolva[4]);
                adatok[sorokszama].suly = Convert.ToInt32(egysordarabolva[5]);                
                sorokszama++;
            }

            //Console.WriteLine("Az Opelek listája fájlból");
            int opelekszama = sorokszama;
            /*Console.WriteLine("tipus                                                                 kezdet         ulések      henger     gyors     suly ");//adatok kiíratása táblázatosan (nem volt feladat)
            for (i = 0; i < opelekszama; i++)
            {
                Console.WriteLine("{0,-70} {1,-10} {2,-10} {3,-20} {4,-10} {5}", adatok[i].tipus, adatok[i].kezdet, adatok[i].ulesek, adatok[i].henger, adatok[i].gyors, adatok[i].suly);
            }
            Console.WriteLine("1. feladat.\n\tAz Opelek száma {0}", opelekszama);*/
            i = opelekszama-1;
            Console.WriteLine("1. feladat:\nAz utolsó autó típusa: {0}\n{1} - es, {2} üléses modell.", adatok[i].tipus, adatok[i].kezdet, adatok[i].ulesek);
            /*2.	Hány éves(ek) az adatbázisban szereplő legidősebb autó(k)?
             * Írja ki a képernyőre a minta szerint!
2. feladat:
Az Opel már 50 éve gyárt autókat.
*/

            int min = adatok[0].kezdet;
            int mini = 0;
            for (i = 0; i < opelekszama; i++)
            {
                if (adatok[i].kezdet < min)
                {
                    min = adatok[i].kezdet;
                    mini = i;
                }
            }
            Console.WriteLine("2. feladat:\nAz Opel már {0} éve gyárt autókat.",2020- adatok[mini].kezdet);
            /*4.	Van-e olyan sportautó a listában, amelyet 2010 után gyártottak. 
             * Ha van, jelenítse meg egy ilyen Opel adatait a képernyőn a minta szerint. 
             * Ha nincs, akkor a „Nincs 2010 utáni sportautó a listánkban.” 
             * feliratot írja ki a monitorra! Amennyiben lehetséges, alkalmazz a Sportauto függvényt vagy metódust!
4. feladat:
2011-ben gyártott sportautó a Corsa van D (Facelift 2011) 1.2 Twinport Ecotec
*/

            bool van = false;
            int sorszam = 0;
            i = 0;
            while(i<opelekszama && !van)
            {
                if (adatok[i].kezdet > 2010)
                {
                    if(Sportauto(adatok[i].ulesek, adatok[i].henger))
                    {
                        van = true;
                        sorszam = i;
                    }
                }
                i++;
            }
            if (van)
            {
                Console.WriteLine("4. feladat:\n{0} - ben gyártott sportautó a {1}", adatok[sorszam].kezdet, adatok[sorszam].tipus);
            }
            else
            {
                Console.WriteLine("4. feladat:\nNincs 2010 utáni sportautó a listánkban.");
            }

            /*5.	Átlagosan hány másodperc alatt érik el a 100 km/h sebességet 
             * az 5 üléses Opelek? Ügyeljen rá, hogy a számításban ne szerepeljenek azok a modellek,
             * melyek gyorsulását nem ismerjük! Az eredményt kerekítse 2 tizedes pontosságra!
5. feladat:
Átlagos gyorsulás: 11,56 s
*/

            double atlag = 0;
            int db = 0;
            for (i = 0; i < opelekszama; i++)
            {
                if(adatok[i].ulesek==5 && adatok[i].gyors != 0)
                {
                    atlag += adatok[i].gyors;
                    db++;
                }
            }
            Console.WriteLine("5. feladat:\nÁtlagos gyorsulás: {0} s",Math.Round(atlag/db,2));

            //6.	Rendezze az adatokat a gyártás éve szerint növekvő sorrendbe!
            int r = opelekszama;
            while (r > 1)
            {
                for (i = 0; i < r - 1; i++)
                {
                    if (adatok[i].kezdet > adatok[i + 1].kezdet)
                    {
                        var seged = adatok[i];
                        adatok[i] = adatok[i + 1];
                        adatok[i + 1] = seged;
                    }
                }
                r--;

            }
            /*for (i = 0; i < opelekszama; i++)
            {
                Console.WriteLine("{0,-70} {1,-10} {2,-10} {3,-20} {4,-10} {5}", adatok[i].tipus, adatok[i].kezdet,adatok[i].ulesek, adatok[i].henger, adatok[i].gyors, adatok[i].suly);
            }*/
            /*7.	Készítse el az opel2000.csv állományt, melybe mentse el 
             * minden 2000 után gyártott Opel adatát! 
             * Az állomány minden sora egy-egy autó adatait tartalmazza 
             * pontosvesszővel (;) elválasztva! 
             * Ahol nem ismerjük a jármű súlyát vagy a gyorsulást, ott 0 helyett az állományban NaN szerepeljen!*/

            FileStream fnev = new FileStream("opel2000.csv", FileMode.Create);
            StreamWriter fajlbairo = new StreamWriter(fnev);
            for (i = 0; i < opelekszama; i++)
            {
                if (adatok[i].kezdet >2000)
                {
                    fajlbairo.Write("{0};", adatok[i].tipus);
                    fajlbairo.Write("{0};", adatok[i].kezdet);
                    fajlbairo.Write("{0};", adatok[i].ulesek);
                    fajlbairo.Write("{0};", adatok[i].henger);
                    if(adatok[i].gyors==0) fajlbairo.Write("NaN;");
                    else
                    fajlbairo.Write("{0};", adatok[i].gyors);
                    if (adatok[i].suly == 0) fajlbairo.WriteLine("NaN;");
                    else
                        fajlbairo.WriteLine("{0};", adatok[i].suly);                    
                }
            }
            fajlbairo.Close();
            fnev.Close();

            Console.ReadKey();

        }
    }
}
