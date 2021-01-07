using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ultrabalaton//1.	Készítsen programot a következő feladatok megoldására, amelynek a forráskódját Ultrabalaton néven mentse el! 
{
    class Program
    {
        /*a versenyen egyéniben induló futók eredményeit tároltuk a következő sorrendben: 
•	a versenyző neve, például: Acsadi Lajos 
•	a versenyző rajtszáma, egész szám, például: 1 
•	a versenyző kategóriája: Ferfi vagy Noi 
•	az elért időeredmény [óra:perc:másodperc], például: 30:28:42 
•	a teljes táv hány százalékánál fejezte be a versenyt, egész szám, például: 100  
Ha itt kevesebb, mint 100 százalék szerepel, akkor a sportoló a versenyt egy közbenső ellenőrzőponton fejezte be. 
Helyezése időeredménytől függetlenül csak rosszabb lehet, mint a nagyobb távot teljesítő futóké. 
*/
        struct maraton
        {
            public string nev;
            public int rajtszam;
            public string nem;
            public int ora;
            public int perc;
            public int sec;
            public int szazalek;
        }
        static maraton[] futok = new maraton[500];//Az állományban legfeljebb 500 sor lehet. 
        //6. feladat:saját függvény ami kiszámolja az időeredményt órában
        static double idoorabanfuggveny(int eredmenyora, int eredmenyperc, int eredmenysec)
        {
            double eredmenyoraban = eredmenyora + eredmenyperc / 60 + eredmenysec / 3600;
            return eredmenyoraban;
        }
        static void Main(string[] args)
        {
            /*2.	Olvassa be az ub2017egyeni.txt állományban lévő adatokat és tárolja el egy olyan adatszerkezetben, 
            ami a további feladatok megoldására alkalmas!*/ 
            string[] fajlbol = File.ReadAllLines("ub2017egyeni.txt");            
            int sorokszama = 0;//sorok száma a fájlban
            int i;//ciklusváltozó
            for (int k = 1; k < fajlbol.Count(); k++)
            {
                string[] egysordarabolva = fajlbol[k].Split(';');
                futok[sorokszama].nev = egysordarabolva[0];
                futok[sorokszama].rajtszam = Convert.ToInt32(egysordarabolva[1]);
                futok[sorokszama].nem = egysordarabolva[2];
                string[] egysordarabolva2 = egysordarabolva[3].Split(':');
                futok[sorokszama].ora =Convert.ToInt32(egysordarabolva2[0]);
                futok[sorokszama].perc = Convert.ToInt32(egysordarabolva2[1]);
                futok[sorokszama].sec = Convert.ToInt32(egysordarabolva2[2]);
                futok[sorokszama].szazalek = Convert.ToInt32(egysordarabolva[4]);
                sorokszama++;
            }

            //Console.WriteLine("Az adatok listája fájlból");
            int futokszama = sorokszama;
            /*Console.WriteLine("  név          rajtszám       nem     idő     százalék");
            for (i = 0; i < futokszama; i++)
            {
                Console.WriteLine("{0,-25} {1,-5} {2,-8} {3,-3}:{4,-3}:{5,-3} {6}", futok[i].nev, futok[i].rajtszam, futok[i].nem, futok[i].ora, futok[i].perc, futok[i].sec, futok[i].szazalek);
            }*/
            //3.	Határozza meg és írja ki a képernyőre a minta szerint, hogy hány egyéni sportoló indult el a versenyen! 
            Console.WriteLine("3. feladat: Egyéni indulók: {0} fő",futokszama);
            //4.	Számolja meg és írja ki a képernyőre a minta szerint, hogy hány női sportoló teljesítette a teljes távot! 
            //megszámlálás tétele
            int noisportolokszama = 0;
            for (i = 0; i < futokszama; i++)
            {
                if(futok[i].nem== "Noi" && futok[i].szazalek==100)
                {
                    noisportolokszama++;
                }
            }
            Console.WriteLine("4. feladat: Célba érkező női sportolók: {0} fő", noisportolokszama);
            /*5.	Kérje be a felhasználótól egy sportoló nevét, majd határozza meg és írja ki a minta szerint, 
             * hogy a sportoló indult-e a versenyen! A keresést ne folytassa, ha az eredményt meg tudja határozni! 
             * Ha a sportoló indult a versenyen, akkor azt is írja ki a képernyőre, hogy a teljes távot teljesítette-e! 
             * Feltételezheti, hogy nem indultak azonos nevű sportolók ezen a versenyen. */
            Console.Write("5. feladat: Kérem a sportoló nevét: ");
            string sportoloneve=Console.ReadLine();
            //keresés tétele
            i = 0;
            while (i < futokszama && sportoloneve!= futok[i].nev)
            {
                i++;
            }
           
            if (i < futokszama)//ha volt ilyen sportoló
            {
                Console.WriteLine("\tIndult egyéniben  a sportoló? Igen");
                if (futok[i].szazalek == 100)//ha teljesítette a teljes távot
                    Console.WriteLine("\tTeljesítette a teljes távot? Igen");
                else Console.WriteLine("\tTeljesítette a teljes távot? Nem");
            }
                
            else//ha nem volt ilyen sportoló
                Console.WriteLine("\tIndult egyéniben  a sportoló? Nem");
            /*6.	Készítsen IdőÓrában azonosítóval valós típusú értékkel visszatérő függvényt vagy jellemzőt, 
             * ami a versenyző időeredményét órában határozza meg! 
             * Egy óra 60 percből, illetve 3600 másodpercből áll. */
            double idooraban = 0;
            /*7.	Határozza meg és írja ki a minta szerint a teljes távot teljesítő férfi sportolók átlagos idejét órában! 
             * Feltételezheti, hogy legalább egy ilyen sportoló volt. */
             //összegzés tétele
            int ferfifutokszama = 0;
            for (i = 0; i < futokszama; i++)
            {
                if(futok[i].nem=="Ferfi" && futok[i].szazalek == 100)
                {                   
                    idooraban += idoorabanfuggveny( futok[i].ora , futok[i].perc, futok[i].sec );//idő órában
                    ferfifutokszama++;//futók száma
                }
            }
            Console.WriteLine("7. feladat: Átlagos idő: {0} óra", idooraban/ferfifutokszama);
            /*8.	Keresse meg a női és a férfi kategóriák győzteseit és írja ki nevüket, rajtszámukat és időeredményeiket a minta szerint!
             * Feltételezheti, hogy egyik kategóriában sem alakult ki holtverseny és mindkét kategóriában volt célba érkező futó. */
             //minimum kiválasztás tétele
            string gyoztesferfi = futok[0].nev;
            string gyoztesno = futok[0].nev;
            int gyoztesferfisorszam = 0;
            int gyoztesnoisorszam = 0;
            double gyoztesidoferfi= 100;
            double gyoztesidonoi =100;
            for (i = 0; i < futokszama; i++)
            {
                if(futok[i].nem == "Ferfi" && futok[i].szazalek == 100)
                {
                    if((idoorabanfuggveny(futok[i].ora, futok[i].perc, futok[i].sec))< gyoztesidoferfi)
                    {
                        gyoztesidoferfi = idoorabanfuggveny(futok[i].ora, futok[i].perc, futok[i].sec);
                        gyoztesferfisorszam = i;
                        gyoztesferfi = futok[i].nev;
                    }
                }
                if (futok[i].nem == "Noi" && futok[i].szazalek == 100)
                {
                    if ((idoorabanfuggveny(futok[i].ora, futok[i].perc, futok[i].sec)) < gyoztesidonoi)
                    {
                        gyoztesidonoi = idoorabanfuggveny(futok[i].ora, futok[i].perc, futok[i].sec);
                        gyoztesnoisorszam = i;
                        gyoztesno = futok[i].nev;
                    }
                }
            }
            Console.WriteLine("8. feladat: Verseny győztesei\n\tNők {0} ({1}.) -{2}:{3}:{4}", gyoztesno, futok[gyoztesnoisorszam].rajtszam, futok[gyoztesnoisorszam].ora, futok[gyoztesnoisorszam].perc, futok[gyoztesnoisorszam].sec);
            Console.WriteLine("\tFérfiak {0} ({1}.) -{2}:{3}:{4}", gyoztesferfi, futok[gyoztesferfisorszam].rajtszam, futok[gyoztesferfisorszam].ora, futok[gyoztesferfisorszam].perc, futok[gyoztesferfisorszam].sec);
            
            Console.ReadKey();
        }
    }
}
