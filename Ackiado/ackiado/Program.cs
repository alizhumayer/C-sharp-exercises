using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ackiado
{
    class Program
    {
        /*1.	Hozzon létre programot ackiado néven a regények adatainak feldolgozásra!
2.	Olvassa be az ac.csv állományban található adatokat! 
Az állomány első sora Agatha Christie születésének évét tárolja. 
Minden további sor 1-1 könyvének adatait tárolja ;-vel elválasztva.
Pl.:
M;A láthatatlan kéz;The Moving Finger;1942;11,40 
A sorokban tárolt adatok a következők:
•	a regény kategóriája, ha Hercule Poirot vagy Miss Marple szerepel a történetben, 
akkor a P, illetve a M karakter szerepel, egyébként – van az állományban. (nincs olyan mű, amelyben közösen szerepelnek) 
•	a regény magyar címe
•	a regény eredeti, angol címe  
•	az első angol kiadás éve  
•	a regény jelenlegi ára euróban 
Minden kiírást igénylő feladat előtt jelenítse meg a feladat sorszámát! (A mintában szereplő ered-mények helytelenek.)

 */

        struct kiadok
        {
            public string kategoria;
            public string magyarcim;
            public string angolcim;            
            public int kiadaseve;
            public double ar;
        }
        static kiadok[] adatok = new kiadok[300];
        static void Main(string[] args)
        {
            string[] fajlbol = File.ReadAllLines("ac.csv");
            int szulev =Convert.ToInt32(fajlbol[0]);//Az állomány első sora Agatha Christie születésének évét tárolja. 
            int sorokszama = 0;//sorok száma a fájlban
            int i;//ciklusváltozó
            for (int k = 1; k < fajlbol.Count(); k++)
            {
                string[] egysordarabolva = fajlbol[k].Split(';');
                adatok[sorokszama].kategoria = egysordarabolva[0];
                adatok[sorokszama].magyarcim = egysordarabolva[1];
                adatok[sorokszama].angolcim = egysordarabolva[2];                
                adatok[sorokszama].kiadaseve = Convert.ToInt32(egysordarabolva[3]);
                adatok[sorokszama].ar =Convert.ToDouble(egysordarabolva[4]);
                sorokszama++;
            }

            Console.WriteLine("A könyvek listája fájlból");
            int konyvekszama = sorokszama;
            Console.WriteLine("kategória    magyarcim                           angolcim                          kiadaseve     ar ");//adatok kiíratása táblázatosan (nem volt feladat)
            for (i = 0; i < konyvekszama; i++)
            {
                Console.WriteLine("{0,-5} {1,-40} {2,-40} {3,-10} {4}", adatok[i].kategoria, adatok[i].magyarcim, adatok[i].angolcim, adatok[i].kiadaseve, adatok[i].ar);
            }
            /*3.	Írja ki a képernyőre, hogy hány könyvet árul a kiadó Agatha Christie műveiből!*/
            Console.WriteLine("3. feladat: {0} könyvet árul a kiadó.",konyvekszama);

            /*4.	Mennyibe kerülne, ha az összes Poirot könyvből meg akarunk vásárolni egy példányt?*/

            double osszesen = 0;
            for (i = 0; i < konyvekszama; i++)
            {
                osszesen += adatok[i].ar;
            }
            Console.WriteLine("4. feladat: {0} Euróba kerül a teljes gyűjtemény.",osszesen);

            /*5.	Jelenítse meg a képernyőn, hogy hány éves volt Agatha Christie, amikor első könyve megjelent! */

            int min = adatok[0].kiadaseve;
            int mini = 0;
            for (i = 1; i < konyvekszama; i++)
            {
                if (adatok[i].kiadaseve < min)
                {
                    min = adatok[i].kiadaseve;
                    mini = i;
                }
            }
            Console.WriteLine("5. feladat: Agatha Christie {0} évesen jelentette meg első könyvét.", adatok[mini].kiadaseve-szulev);

            /*6.	Hozza létre az 1945.txt állományt, és írja ki a fájlba 
             * az összes 1945 előtt megjelent könyv angol és magyar címét, valamint megjelenésnek évét! 
             * A fájlban minden könyv külön sorban szerepel-jen, adatait tabulátorral válassza el egymástól!*/
            FileStream fnev = new FileStream("1945.txt", FileMode.Create);
            StreamWriter fajlbairo = new StreamWriter(fnev);
            for (i = 0; i < konyvekszama; i++)
            {
                if (adatok[i].kiadaseve <=1945)
                {
                    fajlbairo.Write("{0}\t", adatok[i].angolcim);
                    fajlbairo.Write("{0}\t", adatok[i].magyarcim);                   
                    fajlbairo.WriteLine("{0}", adatok[i].kiadaseve);                    
                }
            }
            fajlbairo.Close();
            fnev.Close();

            /*7.	Miss Marpl vagy Poirot történeteiből írt többet Agatha Christie? 
             * A választ írja ki a képernyőre!*/

            int m = 0, p = 0;
            for (i = 0; i < konyvekszama; i++)
            {
                if (adatok[i].kategoria == "M") m++;
                if (adatok[i].kategoria == "P") p++;
            }
            if (m > p)
            {
                Console.WriteLine("7. feladat: Miss Marpl történetből jelent meg több. p= {0} m= {1}", p, m);
            }
            else
            {
                Console.WriteLine("7. feladat: Poirot történetből jelent meg több. p= {0} m= {1}",p,m);
            }

            /*8.	Jelenítse meg egy olyan Poirot történet angol és magyar címét, 
             * melyet Agatha Christie a II. vi-lágháború előtt jelentetett meg! 
             * Ha nincs ilyen könyv, akkora „Nincs háború előtti Poirot könyv” felirat jelenjen mega képernyőn!	*/
            int sorszam = 0;
            i = 0;
            bool van=false;
            while (i < konyvekszama && !van)               
            {
                if (adatok[i].kategoria=="P" && adatok[i].kiadaseve < 1940)
                {
                    van = true;
                    sorszam = i;
                }
                else van = false;
                i++;
            }
           
            if (van)
            {
                Console.WriteLine("8. feladat: {0}	{1}", adatok[sorszam].angolcim, adatok[sorszam].magyarcim);
            }
            else
            {
                Console.WriteLine("Nincs háború előtti Poirot könyv");
            }

            /*9.	Rendezze a könyveket buborék rendezéssel áruk szerint csökkenő sorrendbe! 
             * Jelenítse meg a képernyőn a 15 legdrágább könyv minden adatát tabulátorral elválasztva!9. feladat:*/
            Console.WriteLine("9. feladat: 15 legdrágább könyv");
            //sorbarendezés buborékmódszerrel áruk szerint csökkenő sorrendbe         
            int r = konyvekszama;
            while (r > 1)
            {
                for (i = 0; i < r - 1; i++)
                {
                    if (adatok[i].ar < adatok[i + 1].ar)
                    {
                        var seged = adatok[i];
                        adatok[i] = adatok[i + 1];
                        adatok[i + 1] = seged;
                    }
                }
                r--;

            }
            Console.WriteLine("\n\tsorbarendezett adatok áruk szerint");
            for (i = 0; i < 14; i++)
            {
                Console.WriteLine("{0,-5} {1,-40} {2,-40} {3,-10} {4}", adatok[i].kategoria, adatok[i].magyarcim, adatok[i].angolcim, adatok[i].kiadaseve, adatok[i].ar);
            }
            Console.ReadKey();
        }
    }
}
