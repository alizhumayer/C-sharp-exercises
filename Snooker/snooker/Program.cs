using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snooker
{
    class Program
    {
        struct versenyzok//Helyezes;Nev;Orszag;Nyeremeny
        {
            public int helyezes;
            public string nev;
            public string orszag;
            public double nyeremeny;
        }
        static versenyzok[] adatok = new versenyzok[200];
        static void Main(string[] args)
        {
            string[] fajlbol = File.ReadAllLines("snooker.txt");
            int sorsz = 0;
            int i, j, k;
            for (k = 1; k < fajlbol.Count(); k++)
            {
                string[] egysorarabolva = fajlbol[k].Split(';');
                adatok[sorsz].helyezes = Convert.ToInt32(egysorarabolva[0]);
                adatok[sorsz].nev = egysorarabolva[1];
                adatok[sorsz].orszag = egysorarabolva[2];
                adatok[sorsz].nyeremeny = Convert.ToDouble(egysorarabolva[3]);

                sorsz++;
            }
            int adatokszama = sorsz;
            /*Console.WriteLine("Helyezes   Nev                  Orszag          Nyeremeny");
            for (i = 0; i < adatokszama; i++)
            {
                Console.WriteLine("{0,-4}{1,-25}{2,-25}{3}",adatok[i].helyezes, adatok[i].nev, adatok[i].orszag, adatok[i].nyeremeny);

            }*/
            Console.WriteLine("3. feladat: A világranglistán {0} versenyző szerepel", adatokszama);
            double osszesnyeremeny = 0;
            for (i = 0; i < adatokszama; i++)
            {
                osszesnyeremeny += adatok[i].nyeremeny;
            }
            Console.WriteLine("4. feladat: A  versenyzők átlagosan {0} fontot kerestek",Math.Round(osszesnyeremeny/adatokszama,2));
            double max = adatok[0].nyeremeny;
            int maxi = 0;
            for (i = 1; i < adatokszama; i++)
            {
                if (adatok[i].orszag == "Kína")
                {
                    if (adatok[i].nyeremeny > max)
                    {
                        max = adatok[i].nyeremeny;
                        maxi = i;
                    }
                }                
            }
            Console.WriteLine("5. feladat: A legjobban kereső kínai versenyző: \n\tHelyezés: {0}\n\tNév: {1}\n\tOrszág: {2}\n\tNyeremény összege: {3} Ft", adatok[maxi].helyezes, adatok[maxi].nev, adatok[maxi].orszag, adatok[maxi].nyeremeny*380);

            bool van = false;
            i = 0;
            while(i<adatokszama && adatok[i].orszag != "Norvégia")
            {
                i++;
            }
            van = i < adatokszama ? true : false;
            if (van)
            {
                Console.WriteLine("6. feladat: A versenyzők között van norvég versenyző {0}.",i);               
            }
            else
            {
                Console.WriteLine("6. feladat: A versenyzők között nincs norvég versenyző");
            }

            Console.WriteLine("7. feladat: Statisztika ");
            //adott egy sorozat, határozzuk meg hány különböző eleme van és gyűjtsük ki egy tömbbe
            int kulonbozoelemekszama = 0;
            string[] orszagok = new string[200];
            int[] orszagokszama = new int[200];
            for (i = 0; i < adatokszama; i++)
            {
                j = 0;
                while ((j <= kulonbozoelemekszama) && (adatok[i].orszag != orszagok[j]))
                {
                    j++;
                }
                if (j > kulonbozoelemekszama)
                {
                    kulonbozoelemekszama++;
                    orszagok[kulonbozoelemekszama] = adatok[i].orszag;
                }
            }
            //megszámlálás tétele            
            for (i = 0; i < adatokszama; i++)
            {
                for (k = 1; k <= kulonbozoelemekszama; k++)

                {
                    if (orszagok[k] == adatok[i].orszag) orszagokszama[k]++;
                }

            }
            for (i = 1; i <= kulonbozoelemekszama; i++)
                if (orszagokszama[i]>4)
                Console.WriteLine("\t{0}: {1} fő ", orszagok[i], orszagokszama[i]);
            /*
            //8. Rendezzük az adatokat a nyeremény szerint csökkenő sorrendbe!
            Console.WriteLine("Sorbarendezett adatok nyeremény szerint csökkenő sorrendbe");
            for (i = 0; i < adatokszama; i++)
            {
                double min = adatok[i].nyeremeny;
                int mini = i;
                for (j = i; j < adatokszama; j++)
                {
                    if (adatok[j].nyeremeny > min)
                    {
                        min = adatok[j].nyeremeny;
                        mini = j;
                    }
                }
                var csere = adatok[i];
                adatok[i] = adatok[mini];
                adatok[mini] = csere;
            }

            Console.WriteLine("Helyezes   Nev                  Orszag          Nyeremeny");
            for (i = 0; i < adatokszama; i++)
            {
                Console.WriteLine("{0,-4}{1,-25}{2,-25}{3}", adatok[i].helyezes, adatok[i].nev, adatok[i].orszag, adatok[i].nyeremeny);

            }

                */


            Console.ReadKey();
        }
    }
}
