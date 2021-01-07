using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cukraszda
{
    class Program
    {/*1.	Készítsen konzol applikációt cukraszda néven! 
        A mellékelt cuki.txt pontosvesszővel tagolt, UTF-8 kódolású szöveges állományt olvassa be egy megfelelő adatszerkezetbe! 
Pl.: Sajttorta (málnás);torta;false;9000;12 szeletes
Az állomány tartalma: 
•	A sütemény neve (szöveg) 
•	A sütemény típusa (szöveg) 
•	A sütemény díjazott volt-e a Magyarország Tortája versenyen (logikai) true/false
•	A sütemény ára (egész szám)
•	Annak az egységnek a neve, amelyben a süteményt értékesítik (szöveg)
*/
        struct sutik
        {
            public string nev;
            public string tipus;
            public bool dij;
            public int ar;
            public string egyseg;
        }
        static sutik[] adatok = new sutik[300];
        static void Main(string[] args)
        {
            string[] fajlbol = File.ReadAllLines("cuki.txt");

            int sorokszama = 0;//sorok száma a fájlban
            int i;//ciklusváltozó
            for (int k = 0; k < fajlbol.Count(); k++)
            {
                string[] egysordarabolva = fajlbol[k].Split(';');
                adatok[sorokszama].nev = egysordarabolva[0];
                adatok[sorokszama].tipus = egysordarabolva[1];
                if(egysordarabolva[2]=="false") adatok[sorokszama].dij = false;
                if(egysordarabolva[2]=="true") adatok[sorokszama].dij = true;
                adatok[sorokszama].ar = Convert.ToInt32(egysordarabolva[3]);
                adatok[sorokszama].egyseg = egysordarabolva[4];
                sorokszama++;
            }

            Console.WriteLine("A sütemények listája fájlból");
            int sutikszama = sorokszama;
            Console.WriteLine("  sütinév                    sütitipus                 díjazott-e sütiár    egység");//adatok kiíratása táblázatosan (nem volt feladat)
            for (i = 0; i < sutikszama; i++)
            {
                Console.WriteLine("{0,-30} {1,-25} {2,-10} {3,-10} {4}", adatok[i].nev, adatok[i].tipus, adatok[i].dij, adatok[i].ar, adatok[i].egyseg);
            }
            /*2.	Válasszon ki véletlen szám generátor segítségével egy sütit és jelenítse meg nevét a képernyőn a minta szerint!*/
            Random n = new Random();
            int kivalaszt = n.Next(0, sutikszama);
            Console.WriteLine("2. feladat:");
            Console.WriteLine("Mai ajánlatunk: {0}", adatok[kivalaszt].nev);
            /*3.	Mennyibe kerülne, ha minden vegyes típusú süteményből szeretnénk venni egy adagot?*/
            Console.WriteLine("3. feladat:");
            double osszesen = 0;
            for (i = 0; i < sutikszama; i++)
            {
                if(adatok[i].tipus=="vegyes")
                osszesen += adatok[i].ar;
            }
            Console.WriteLine("A vegyes sütemények ára összesen {0} Ft", osszesen);
            /*4.	Hány féle Magyarország Tortája versenyen díjazott finomság közül választhatnak a vásárlók? 
             * (Ha az egység eltérő, akkor a sütemény különbözőnek számít.)*/
            Console.WriteLine("4. feladat:");
            int db = 0;
            for (i = 0; i < sutikszama; i++)
            {
                if (adatok[i].dij == true)
                    db++;
            }
            Console.WriteLine("{0} féle díjnyertes édességből választhat.", db);
            /*5.	Egy cég árajánlatot kért tőlünk. 
             * Tortát szeretnének rendelni. Készítse el a tortak.csv, pontosvesszővel tagolt állományt! 
             * Az állományba írja ki az összes torta nevét, a kiszerelés egységét és az árát!*/
            FileStream fnev = new FileStream("tortak.csv", FileMode.Create);
            StreamWriter fajlbairo = new StreamWriter(fnev);            
            for (i = 0; i < sutikszama; i++)
            {
                if (adatok[i].tipus=="torta")
                {
                    fajlbairo.Write("{0};", adatok[i].nev);
                    fajlbairo.Write("{0};", adatok[i].egyseg);
                    fajlbairo.WriteLine("{0}", adatok[i].ar);
                    //fajlbairo.WriteLine("\n");//sortörés
                }
            }
            fajlbairo.Close();
            fnev.Close();
            /*6.	Olvasson be a felhasználótól egy süteménytípust! 
             * Jelenítse meg a képernyőn az első olyan sütit, amely megfelel ennek a sütitípusnak!*/
            Console.WriteLine("6. feladat:");
            Console.Write("Milyen fajta sütit kér? ");
            string keresettsutinev = Console.ReadLine();
            i = 0;
            while(i<sutikszama && adatok[i].tipus != keresettsutinev)
            {
                i++;
            }
            if (i < sutikszama)
            {
                Console.WriteLine("Ajánlatunk: {0} {1} Ft/db", adatok[i].nev, adatok[i].ar);
            }
            else
            {
                Console.WriteLine("A keresett {0} sütemény fajta nem található",keresettsutinev);
            }
            Console.ReadKey();
        }
    }
}
