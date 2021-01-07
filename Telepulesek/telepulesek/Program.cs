using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace telepulesek
{
    class Program
    {
        struct telepules
        {
            public string telepulesnev;
            public string rang;
            public string terseg;
            public double terulet;
            public double lakosokszama;
        }
        static telepules[] adatok = new telepules[500];

        // 6. feladat saját függvény
        //meg tudja határozni egy település népsűrűségét fő/km2-ben! (1 ha = 0,01 km2)
        static void Nepsuruseg()
        {
            double nepsur = 0;//népsűrűség
            nepsur = adatok[0].lakosokszama / adatok[0].terulet * 100;
            int mins = 0;
            for (int i = 1; i < adatok.Length; i++)
            {
                if ((adatok[i].lakosokszama / adatok[i].terulet *100)<nepsur)
                {
                    nepsur= adatok[i].lakosokszama / adatok[i].terulet * 100;
                    mins = i;
                }
            }
            Console.Write("7. feladat: ");
            Console.WriteLine("A legritkábban lakott település:");
            Console.WriteLine("\tA település neve: {0}\n\tNépsűrűsége: {1} fő/km2", adatok[mins].telepulesnev,Math.Round(nepsur,2));
        }
        static void Main(string[] args)
        {
            string[] fajlbol = File.ReadAllLines("szszb.csv", Encoding.Default);//beolvasás fájlból
            int sorokszama = 0;
            int i;
            int telepulesekszama = 0;
            //adatok beolvasása
            for (int k = 1; k < fajlbol.Count(); k++)//a ciklus 1-től megy mert az első sor a mezőneveket tartalmazza
            {
                string[] egysordarabolva = fajlbol[k].Split(';');
                adatok[sorokszama].telepulesnev = egysordarabolva[0];
                adatok[sorokszama].rang = egysordarabolva[1];
                adatok[sorokszama].terseg = egysordarabolva[2];
                adatok[sorokszama].terulet = Convert.ToDouble(egysordarabolva[3]);
                adatok[sorokszama].lakosokszama = Convert.ToDouble(egysordarabolva[4]);
                sorokszama++;
            }
            telepulesekszama = sorokszama;
            //3. feladat megszámlálás tétele
            //Határozza meg és írja ki a képernyőre, hogy hány település található az szszb.csv állományban!
          
            Console.Write("3. feladat: ");
            Console.WriteLine("Települések száma: {0} db", telepulesekszama);
            //4. feladat összegzés tétele
            //Határozza meg és írja ki a képernyőre Szabolcs-Szatmár-Bereg Megye lakosságát!
            double szabolcsossz = 0;
            for (i = 0; i < telepulesekszama; i++)
            {
                szabolcsossz += adatok[i].lakosokszama;
            }
            Console.Write("4. feladat: ");
            Console.WriteLine("A megye lakossága: {0} fő", szabolcsossz);

            //5. feladat minimumkiválasztás
            //a megye legkisebb területű településének az adatai
            double min = adatok[0].terulet;
            int mini = 0;
            for (i = 1; i < telepulesekszama; i++)
            {
                if (adatok[i].terulet < min)
                {
                    min = adatok[i].terulet;
                    mini = i;
                }
            }
            Console.Write("5. feladat: ");
            Console.WriteLine("A legkisebb telületű település:");
            Console.WriteLine("\tTelepülés neve: {0}\n\tTerülete: {1} ha",adatok[mini].telepulesnev,adatok[mini].terulet);

            //7. feladat 
            //Írja ki a képernyőre a legritkábban lakott település nevét és népsűrűségét!
            Nepsuruseg();
            


            Console.ReadKey();
        }
    }
}
