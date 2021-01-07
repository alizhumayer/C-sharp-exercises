using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hianyzasok
{
    class Program
    {
        struct hianyzas//Készítsen összetett változót az adatok tárolására!
        {            
            public string nev;
            public string osztaly;
            public int elsonap;
            public int utolsonap;
            public int mulasztottorak;
        }
        static hianyzas[] adatok = new hianyzas[200];//Az állományban legfeljebb 200 sor lehet. 
        static void Main(string[] args)
        {
            string[] fajlbol = File.ReadAllLines("szeptember.csv");
            int sorokszama = 0;//sorok száma a fájlban
            int i, j;//ciklusváltozó
            for (int k = 1; k < fajlbol.Count(); k++)//Ügyeljen arra, hogy az állomány első sora az adatok fejlécét tartalmazza!
            {
                string[] egysordarabolva = fajlbol[k].Split(';');//Az adatokat pontosvessző választja el.
                adatok[sorokszama].nev = egysordarabolva[0];
                adatok[sorokszama].osztaly = egysordarabolva[1];
                adatok[sorokszama].elsonap = Convert.ToInt32(egysordarabolva[2]);
                adatok[sorokszama].utolsonap = Convert.ToInt32(egysordarabolva[3]);
                adatok[sorokszama].mulasztottorak = Convert.ToInt32(egysordarabolva[4]);
                sorokszama++;
            }
            int hianyzasokszama = sorokszama;

            Console.WriteLine("Az adatok listája fájlból");
            
            Console.WriteLine(" Név                Osztály   Első nap  Utolsó nap Mulasztott órák");
            for (i = 0; i < hianyzasokszama; i++)
            {
                Console.WriteLine("{0,-20} {1,-10} {2,-10} {3,-10} {4}", adatok[i].nev, adatok[i].osztaly, adatok[i].elsonap, adatok[i].utolsonap, adatok[i].mulasztottorak);
            }

            //2.	Határozza meg, és írja ki a képernyőre, hogy a diákok összesen hány órát mulasztottak ebben a hónapban.  
            //összegzés tétele
            double osszeshianyzas = 0;
            for (i = 0; i < hianyzasokszama; i++)
            {
                osszeshianyzas += adatok[i].mulasztottorak;
            }
                Console.WriteLine("2. feladat\n\tÖsszes mulasztott órák száma: {0} óra", osszeshianyzas);
            /*3.	Kérjen be a felhasználótól  
             * •	egy napot 1 és 30 között 
             * •	egy tanuló nevét  */
            int nap;
            string tanulonev;
            do
            {
                Console.Write("3. feladat\n\tKérem adjon meg egy napot: ");
                nap = Convert.ToInt32(Console.ReadLine());
            } while (nap <= 0 || nap >= 31);
            Console.Write("\tTanuló neve: ");
            tanulonev = Console.ReadLine();

            /*4.	Írja ki a képernyőre, hogy az előző feladatban beért tanulónak volt-e hiányzása! 
             * A „A tanuló hiányzott szeptemberben” vagy „A tanuló nem hiányzott szeptemberben” szöveget jelenítse meg */
            //keresés tétele
            i = 0;
            while (i < hianyzasokszama && adatok[i].nev !=tanulonev)
            {
                i++;
            }
            Console.WriteLine("\n4. feladat");
            if (i < hianyzasokszama)
                Console.WriteLine("\tA tanuló hiányzott szeptemberben");
            else
                Console.WriteLine("\tA tanuló nem hiányzott szeptemberben");
            /*5.	Írja ki a képernyőre azon tanulók nevét és osztályát a minta szerint, akik a 3. feladatban bekért napon hiányoztak! 
             * (Ha a 3. feladatot nem tudta megoldani, akkor a 19-ei nappal dolgozzon!) 
             * Ha nem volt hiányzó, akkor a „Nem volt hiányzó” szöveget jelenítse meg! */
             //megszámlálás tétele
            int hianyzokszama = 0;
            Console.Write("\n5. feladat: Hiányzók 2017.09.{0}-n:\n",nap);
            for (i = 0; i < hianyzasokszama; i++)
            {
                if (adatok[i].elsonap <= nap && adatok[i].utolsonap >= nap)
                {
                    hianyzokszama++;
                    Console.WriteLine("\t{0} ({1})",adatok[i].nev,adatok[i].osztaly);
                }
            }
            if (hianyzokszama == 0) Console.WriteLine("\tNem volt hiányzó");

            /*6.	Készítsen összesítést, amely osztályonként fájlba írja a mulasztott órák számát! 
             * Az osszesites.csv nevű fájl tartalmazza az osztályt és a mulasztott órák számának összegét! */
            //adott egy sorozat, határozzuk meg hány különböző eleme van és gyűjtsük ki egy tömbbe
            int kulonbozoelemekszama = 0;
            string[] osztalyok = new string[100];
            int[] hianyzasossz = new int[100];
            for (i = 0; i < 100; i++) hianyzasossz[i] = 0;//adatok nullázása
            for (i = 0; i < hianyzasokszama; i++)
            {
                j = 0;
                while ((j <= kulonbozoelemekszama) && (adatok[i].osztaly != osztalyok[j]))
                {
                    j++;
                }
                if (j > kulonbozoelemekszama)
                {
                    kulonbozoelemekszama++;
                    osztalyok[kulonbozoelemekszama] = adatok[i].osztaly;
                }

            }
            //összegzés tétele            
            for (i = 0; i < hianyzasokszama; i++)
            {
                for (int k = 1; k <= kulonbozoelemekszama; k++)

                {
                    if (osztalyok[k] == adatok[i].osztaly) hianyzasossz[k]+=adatok[i].mulasztottorak;
                }

            }
            Console.WriteLine("6. feladat:");
            for (i = 1; i <= kulonbozoelemekszama; i++)
                Console.WriteLine("\t{0},{1} óra ", osztalyok[i], hianyzasossz[i]);
            //sorbarendezés min kiválasztással
            int mini = 0;
            string min;
            int csere;
            for (i = 0; i <= kulonbozoelemekszama; i++)
            {
                mini = i;
                min = osztalyok[i];
                for (j = i; j <= kulonbozoelemekszama; j++)
                {
                    int x = String.Compare(osztalyok[j], min);
                    if (x < 0)
                    {
                        mini = j;
                        min = osztalyok[j];
                    }
                }
                //csere
                var s = osztalyok[i];
                csere = hianyzasossz[i];
                osztalyok[i] = osztalyok[mini];
                hianyzasossz[i] = hianyzasossz[mini];
                osztalyok[mini] = s;
                hianyzasossz[mini] = csere;
            }
            
            Console.WriteLine("sorbarendezett adatok:");
            for (i = 1; i <= kulonbozoelemekszama; i++)
                Console.WriteLine("\t{0},{1} óra ", osztalyok[i], hianyzasossz[i]);
            FileStream fnev = new FileStream("osszesites.csv", FileMode.Create);
            StreamWriter fajlbairo = new StreamWriter(fnev);
            
            for (i = 1; i <= kulonbozoelemekszama; i++)
            {
                fajlbairo.Write("{0};", osztalyok[i]);
                fajlbairo.Write("{0}", hianyzasossz[i]);               
                fajlbairo.WriteLine("\n");//sortörés                
            }
            fajlbairo.Close();
            fnev.Close();

            Console.ReadKey();
        }
    }
}
