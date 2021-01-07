using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace telekocsi
{
    class Program
    {
        struct auto//Készítsen összetett változót az adatok tárolására!
        {
            public string indulas;
            public string cel;
            public string rendszam;
            public string telefonszam;
            public int ferohely;          
        }
        static auto[] adatok = new auto[1000];//Az állományban legfeljebb 1000 sor lehet. 
        struct igeny//Készítsen összetett változót az adatok tárolására!
        {
            public string azonosito;
            public string indulas;
            public string cel;            
            public int szemelyek;
            public string rendszam;
            public string telefonszam;
            public int ok;
        }
        static igeny[] igenyek = new igeny[500];//Az állományban legfeljebb 500 sor lehet.
        static void Main(string[] args)
        {
            string[] fajlbol = File.ReadAllLines("autok.csv");
            int sorokszama = 0;//sorok száma a fájlban
            int i, j;//ciklusváltozó
            for (int k = 1; k < fajlbol.Count(); k++)//Ügyeljen arra, hogy az állomány első sora az adatok fejlécét tartalmazza!
            {
                string[] egysordarabolva = fajlbol[k].Split(';');//Az adatokat pontosvessző választja el.
                adatok[sorokszama].indulas = egysordarabolva[0];
                adatok[sorokszama].cel = egysordarabolva[1];
                adatok[sorokszama].rendszam = egysordarabolva[2];
                adatok[sorokszama].telefonszam = egysordarabolva[3];
                adatok[sorokszama].ferohely = Convert.ToInt32(egysordarabolva[4]);
                sorokszama++;
            }
            int autokszama = sorokszama;

            /*Console.WriteLine("Az adatok listája fájlból");
            
            Console.WriteLine(" Indulás        Cél             Rendszám     Telefonszám  Féröhely");
            for (i = 0; i < autokszama; i++)
            {
                Console.WriteLine("{0,-15} {1,-15} {2,-10} {3,-15} {4} ", adatok[i].indulas, adatok[i].cel, adatok[i].rendszam, adatok[i].telefonszam, adatok[i].ferohely);
            }*/
            string[] fajlbol2 = File.ReadAllLines("igenyek.csv");
            sorokszama = 0;//sorok száma a fájlban           
            for (int k = 1; k < fajlbol2.Count(); k++)//Ügyeljen arra, hogy az állomány első sora az adatok fejlécét tartalmazza!
            {
                string[] egysordarabolva = fajlbol2[k].Split(';');//Az adatokat pontosvessző választja el.
                igenyek[sorokszama].azonosito = egysordarabolva[0];
                igenyek[sorokszama].indulas = egysordarabolva[1];
                igenyek[sorokszama].cel = egysordarabolva[2];
                igenyek[sorokszama].szemelyek = Convert.ToInt32(egysordarabolva[3]);                
                sorokszama++;
            }
            int igenyekszama = sorokszama;

            /*Console.WriteLine("Az adatok listája fájlból");

            Console.WriteLine(" Azonosító       Indulás           Cél         Személyek");
            for (i = 0; i < igenyekszama; i++)
            {
                Console.WriteLine("{0,-15} {1,-15} {2,-15} {3} ", igenyek[i].azonosito, igenyek[i].indulas, igenyek[i].cel, igenyek[i].szemelyek);
            }*/
            //2.	Írja ki, hogy hány hirdető adatát tartalmazta az első feladatban beolvasott fájl! 
            Console.WriteLine("2. feladat\n\t{0} autós hirdet fuvart", autokszama);
            //3.	Határozza meg és írja ki a képernyőre, hogy Budapestről Miskolcra összesen hány férőhelyet hirdettek a sofőrök! 
            //összegzés tétele
            int osszesferohely = 0;
            for (i = 0; i < autokszama; i++)
            {
                if(adatok[i].indulas=="Budapest" && adatok[i].cel == "Miskolc")
                {
                    osszesferohely += adatok[i].ferohely;
                }
            }
            Console.WriteLine("3. feladat\n\tÖsszesen {0} férőhelyet hirdettek az autósok Budapestről Miskolcra", osszesferohely);
            //4.	Határozza meg és írja ki, hogy melyik volt az az útvonal (induló- és célállomás), 
            //amelyhez a legtöbb férőhelyet ajánlották fel a hirdetők! 
            //adott egy sorozat, határozzuk meg hány különböző eleme van és gyűjtsük ki egy tömbbe
            int kulonbozoelemekszama = 0;
            string[] indcel = new string[1000];//különböző útvonalak kiválogatása (indulas-cel)
            int[] ferohelyosszesen = new int[1000];
            for (i = 0; i < 1000; i++) ferohelyosszesen[i] = 0;
            for (i = 0; i < autokszama; i++)
            {
                j = 0;
                while ((j <= kulonbozoelemekszama) && (adatok[i].indulas+"-"+ adatok[i].cel != indcel[j]))
                {
                    j++;
                }
                if (j > kulonbozoelemekszama)
                {
                    kulonbozoelemekszama++;
                    indcel[kulonbozoelemekszama] = adatok[i].indulas + "-" + adatok[i].cel;
                }

            }
            /*for (i = 1; i <= kulonbozoelemekszama; i++)
                Console.WriteLine("\t{0} útvonal ", indcel[i]);*/
            //megszámlálás tétele
            for (i = 0; i < autokszama; i++)
            {
                for (j = 0; j < kulonbozoelemekszama; j++)
                {
                    if(indcel[j]== adatok[i].indulas + "-" + adatok[i].cel)
                    {
                        ferohelyosszesen[j] += adatok[i].ferohely;
                    }
                }
            }
            //maximumkiválasztás tétele
            int max = ferohelyosszesen[0];
            int maxi = 0;
            for (j = 0; j < kulonbozoelemekszama; j++)
            {
                if (ferohelyosszesen[j] > max)
                {
                   max=ferohelyosszesen[j];
                    maxi = j;
                }
            }
            Console.WriteLine("4. feladat\n\tA legtöbb férőhelyet ({0}-t) a {1} útvonalon ajánlották fel a hirdetők", ferohelyosszesen[maxi],indcel[maxi]);
            /*5.	Az igenyek.csv fájl beérkezési sorrendben tartalmazza az utazási igényeket. 
             * Az igények feldolgozása beérkezési sorrendben történik. 
             * Olvassa be az igényeket és a beérkezési sorrendnek megfelelően határozza meg, 
             * hogy melyek azok az igények, amelyekhez lehet hirdetést (sofőrt) találni! 
             * A találatokat a mintának megfelelően írja ki a képernyőre! */
            Console.WriteLine("5. feladat");
            for (i = 0; i < igenyekszama; i++)
            {
                for (j = 0; j < autokszama; j++)
                {
                    if(igenyek[i].indulas==adatok[j].indulas && igenyek[i].cel == adatok[j].cel && igenyek[i].szemelyek < adatok[j].ferohely)
                    {
                        Console.WriteLine("{0}=>{1}",igenyek[i].azonosito,adatok[j].rendszam);
                        igenyek[i].telefonszam = adatok[j].telefonszam;
                        igenyek[i].rendszam = adatok[j].rendszam;
                        igenyek[i].ok = 1;
                    }                    
                }
            }
            /*6.	Készítse el a minta szerint az utasuzenetek.txt fájlt, 
             * amely tartalmazza az egyes igényekre adott választ! 
             * Az igénylő sikeres párosítás esetén megkapja az autó rendszámát és a sofőr telefonszámát, 
             * sikertelen párosítás esetén egy „Sajnos nem sikerült autót találni” üzenetet kap.  */
            //kiválogatás
            Console.WriteLine("6. feladat");
            FileStream fnev = new FileStream("utasuzenetek.txt", FileMode.Create);
            StreamWriter fajlbairo = new StreamWriter(fnev);
            for (i = 0; i < igenyekszama; i++)
            {                
                    if (igenyek[i].ok==1)
                    {
                        fajlbairo.WriteLine("{0}: Rendszám: {1}, Telefonszám: {2}", igenyek[i].azonosito, adatok[i].rendszam,adatok[i].telefonszam);
                        Console.WriteLine("{0}: Rendszám: {1}, Telefonszám: {2}", igenyek[i].azonosito, igenyek[i].rendszam, igenyek[i].telefonszam);
                    }
                    else
                    {
                        fajlbairo.WriteLine("{0}: Sajnos nem sikerült autót találni",igenyek[i].azonosito);
                        Console.WriteLine("{0}: Sajnos nem sikerült autót találni", igenyek[i].azonosito);
                    }
                
            }
            
            fajlbairo.Close();
            fnev.Close();

            Console.ReadKey();
        }
    }
}
