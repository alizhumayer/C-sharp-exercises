using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace etterem
{
    class Program
    {
        /*Az „etlap.txt” állományban egy étterem étlapján szereplő, legfeljebb 60 db étel adatait találja
         * * (csillag) karakterrel tagolva.
Pl.: Almaleves*130*9,8*550*L
Az egy sorban tárolt adatok rendre:
•	az étel neve Pl.: Almaleves
•	az étel energiatartalma (kalória) Pl.: 130
•	az étel szénhidráttartalma (grammban) Pl.: 9,8
•	az étel ára (forintban) Pl.: 550
•	az étel kategóriája Pl.: L
	L: leves
	F: főétel
	D: desszert
Hozzon létre programot „saját név_etterme” néven az alábbi feladatok megvalósítására! 
Minden kiírást igénylő feladat előtt jelenítse meg a feladat sorszámát! 
A kiíratás mintái nem biztos, hogy a helyes eredményt tartalmazzák!
*/

        struct etlapok
        {
            public string etelnev;
            public int energia;
            public double szenhidrat;
            public int ar;
            public string kategoria;            
        }
        static etlapok[] adatok = new etlapok[100];
        static void Main(string[] args)
        {
            /*1.	Olvassa be a forrásfájl tartalmát és tárolja el úgy,
             * hogy további feladatok megoldására alkalmasak legyenek! 
             * Jelenítse meg a képernyőn a teljes étlapot tabulátorokkal tagolva!
             * Írassa ki, hogy hány étel adatait találhatjuk a fájlban az alábbi minta szerint: 
             * 1. feladat:	 A fájlban 57 db étel adatai találhatóak.*/
            string[] fajlbol = File.ReadAllLines("etlap.txt");

            int sorokszama = 0;//sorok száma a fájlban
            int i;//ciklusváltozó
            for (int k = 0; k < fajlbol.Count(); k++)
            {
                string[] egysordarabolva = fajlbol[k].Split('*');
                adatok[sorokszama].etelnev = egysordarabolva[0];
                adatok[sorokszama].energia = Convert.ToInt32(egysordarabolva[1]);
                adatok[sorokszama].szenhidrat = Convert.ToDouble(egysordarabolva[2]);
                adatok[sorokszama].ar = Convert.ToInt32(egysordarabolva[3]);
                adatok[sorokszama].kategoria = egysordarabolva[4];                
                sorokszama++;
            }

            Console.WriteLine("Az ételek listája fájlból");
            int etelekszama = sorokszama;
            Console.WriteLine("etelnev                                               energia         szenhidrat     ar     kategoria ");//adatok kiíratása táblázatosan
            for (i = 0; i < etelekszama; i++)
            {
                Console.WriteLine("{0,-60} {1,-10} {2,-10} {3,-10} {4}", adatok[i].etelnev, adatok[i].energia, adatok[i].szenhidrat, adatok[i].ar, adatok[i].kategoria);
            }
            Console.WriteLine(" 1. feladat:	\n\tA fájlban {0} db étel adatai találhatóak.", etelekszama);
            /*2.	Határozza meg, hogy átlagosan mennyibe kerül egy adag étel!
2. feladat:
	 Egy adag étel 888,07 Ft-ba kerül.
*/

            double atlag = 0;
            for (i = 0; i < etelekszama; i++)
            {
                atlag += adatok[i].ar;
            }
            Console.WriteLine(" 2. feladat:	\n\tEgy adag étel {0} Ft-ba kerül.",Math.Round(atlag/etelekszama,2));

            /*3.	Jelenítse meg egy olyan étel nevét és árát, 
             * amely főétel és legfeljebb 400 kalória az energiatartalma. 
3. feladat:
	 Csőben sült brokkoli sajttal	1210 Ft.
*/

            int sorszam=0;
            bool van = false;
            i = 0;
            while(i<etelekszama && !van)
            {
                if(adatok[i].kategoria=="F" && adatok[i].energia <= 400)
                {
                    sorszam = i;
                    van = true;
                }
                else
                {
                    van = false;
                }
                i++;
            }
            if (van)
            {
                Console.WriteLine("3. feladat:\n\t{0} {1} Ft.", adatok[sorszam].etelnev, adatok[sorszam].ar);
            }
            else
            {
                Console.WriteLine("3. feladat:\n\tNincs olyan főétel aminek legfeljebb 400 kalória az energiatartalma");
            }
            /*4.	Hány olyan ételt szerepel az étlapon, amely gombás (nevében szerepel a gomba szó)?
4. feladat:
	 3 különböző gombás étel szerepel az étlapon
*/

            int gombasetelekszama = 0;
            for (i = 0; i < etelekszama; i++)
            {
                if (adatok[i].etelnev.Contains("gomba"))
                {
                    gombasetelekszama++;
                }
            }
            Console.WriteLine("4. feladat:\n\t{0} különböző gombás étel szerepel az étlapon",gombasetelekszama);

            /*5.	Írja ki a legdrágább étel nevét, árát és szénhidráttartalmát! 
5. feladat:
	 A legdrágább étel a Csirkés pizza 1470 Ft. Szénhidráttartalma: 14,8 g
*/

            int max = adatok[0].ar;
            int maxi = 0;
            for (i = 0; i < etelekszama; i++)
            {
                if (adatok[i].ar > max)
                {
                    max = adatok[i].ar;
                    maxi = i;
                }
            }
            Console.WriteLine("5. feladat:\n\tA legdrágább étel a {0} {1} Ft.Szénhidráttartalma: {2} g", adatok[maxi].etelnev, adatok[maxi].ar, adatok[maxi].szenhidrat);

            /*6.	Az az étel ajánlható cukorbetegek számára, 
             * amelyek szénhidráttartalma nem éri el a 10 grammot. 
             * Egy, az eredetivel azonos szerkezetű „cukorbeteg.txt” állományban 
             * tárolja le a cukorbetegek számára ajánlható ételek minden adatát! */
            FileStream fnev = new FileStream("cukorbeteg.txt", FileMode.Create);
            StreamWriter fajlbairo = new StreamWriter(fnev);
            for (i = 0; i < etelekszama; i++)
            {
                if (adatok[i].szenhidrat <=10)
                {
                    fajlbairo.Write("{0};", adatok[i].etelnev);
                    fajlbairo.Write("{0};", adatok[i].energia);
                    fajlbairo.Write("{0};", adatok[i].szenhidrat);
                    fajlbairo.Write("{0};", adatok[i].ar);                    
                    fajlbairo.WriteLine("{0}", adatok[i].kategoria);
                }
            }
            fajlbairo.Close();
            fnev.Close();

            Console.ReadKey();
        }
    }
}
