using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Mukorcsolya
{
    class Program
    {
        // Szükségünk van 2 statikus listára, amiket a főosztályon kívülre pakolunk!
        static List<Mukorcsolya> rovid = new List<Mukorcsolya>();
        static List<Mukorcsolya> donto = new List<Mukorcsolya>();
        static void Main(string[] args)
        {
            Feladat1();
            Feladat2();
            Feladat3();
            // Feladat4();
            Feladat5();
            Feladat6();
            Feladat7();
            Feladat8();

            ReadKey();
        }

        private static void Feladat1()
        {
            // Lehetőleg a bin/debugban legyenek a file-ok!
            string cimsor = "";
            FileStream fs = new FileStream("rovidprogram.csv",FileMode.Open);           
            StreamReader sr = new StreamReader(fs);
            cimsor = sr.ReadLine();
            while (!sr.EndOfStream)
            {
                rovid.Add(new Mukorcsolya(sr.ReadLine()));
            }
            sr.Close();
            fs.Close();           
            FileStream fs2 = new FileStream("donto.csv",FileMode.Open);
            StreamReader sr2 = new StreamReader(fs2);
            cimsor = sr2.ReadLine();
            while (!sr2.EndOfStream)
            {
                donto.Add(new Mukorcsolya(sr2.ReadLine()));
            }
            sr2.Close();
            fs2.Close();
            /*
            // A másik módszer a filebeolvasásra
            foreach (string item in File.ReadAllLines("rovidprogram.csv").Skip(1))
            {
                rovid.Add(new Mukorcsolya(item));
            }
            foreach (string item in File.ReadAllLines("donto.csv").Skip(1))
            {
                donto.Add(new Mukorcsolya(item));
            }
            */
        }

        private static void Feladat2()
        {
            //Egyszerűen csak kiiratjuk a "rövid" lista hosszát. 
            WriteLine("A rövidprogramban {0} induló volt", rovid.Count);
        }

        private static void Feladat3()
        {
            // Kell egy logikai változó, aminek értékétől függően derül ki, hogy a magyar versenyző döntős lesz-e.
            bool van = false;
            int i = 0;
            // Csak addig lépdel a cikluson, míg igaz nem lesz a "van" értéke.
            while (!van && i < donto.Count)
            {
                if (donto[i].Orszagkod=="HUN")
                {
                    van = true;
                }
                else
                {
                    i++;
                }
            }
            if (van)            
            {
                WriteLine("A magyar versenyző bejutott a kűrbe.");
            }
            else
            {
                WriteLine("A magyar versenyző nem kvalifikálta magát a kűrbe.");
            }
        }

        /*
        private static void Feladat4()
        {
            OsszPontszam(nev);
        }
        */
        // Lesz visszatérési értéke, így nem void, hanem double típusú a függvény.
        static double OsszPontszam(string nev)
        {
            double osszpont = 0;
            // Foreach-el végigmegyünk a versenyzők listáján. A rövidprogram és a kűr listáján is.
            foreach (Mukorcsolya versenyzo in rovid)
            {
                if (versenyzo.Nev == nev)
                {
                    osszpont += versenyzo.Tpont + versenyzo.Kpont - versenyzo.Hibapont;
                }
            }
            foreach (Mukorcsolya versenyzo in donto)
            {
                if (versenyzo.Nev == nev)
                {
                    osszpont += versenyzo.Tpont + versenyzo.Kpont - versenyzo.Hibapont;
                }
            }
            return osszpont;
        }

        private static void Feladat5()
        {
            // Esetleges elírás miatt kivételkezelést alkalmazunk.
            try
            {
                Write("Kérem adja meg a versenyző nevét! ");
                string nev=ReadLine();
            }
            catch (Exception)
            {
                WriteLine("Ilyen nevű induló nem volt!");
            }
        }

        private static void Feladat6()
        {
            string nev = "";
            double osszpont = OsszPontszam(nev);
            WriteLine("A versenyző összpontszáma: {0}", osszpont);
        }

        private static void Feladat7()
        {
            List<string> orszagok = new List<string>();
            foreach (Mukorcsolya versenyzo in donto)
            {
                if (orszagok.Contains(versenyzo.Orszagkod))
                {
                    orszagok.Add(versenyzo.Orszagkod);
                }
            }
            foreach (string orszag in orszagok)
            {
                int db = 0;
                foreach (Mukorcsolya versenyzo in donto)
                {
                    if (versenyzo.Orszagkod==orszag)
                    {
                        db++;
                    }
                }
                if (db > 1)
                {
                    WriteLine(orszag+": "+db);
                }
            }
            /*
            // Szótáros megoldás is jó, de bonyolultabb.           
            Dictionary<string, int> statisztika = new Dictionary<string, int>();
            foreach (var item in donto)
            {
                string orszag = "";
                statisztika[orszag]++;
                foreach (var kulcsertek in statisztika)
                {
                    WriteLine("{0}: {1}",kulcsertek.Key,kulcsertek.Value);
                }
            }
            */
        }

        private static void Feladat8()
        {
            FileStream fs3 = new FileStream("vegeredmeny.csv", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs3,Encoding.UTF8);
            // donto = donto.OrderByDescending(versenyzo=>(versenyzo.Tpont+versenyzo.Kpont-versenyzo.Hibapont)).ToList();
            donto = donto.OrderByDescending(versenyzo => (OsszPontszam(versenyzo.Nev))).ToList();
            int helyezes = 1;
            foreach (Mukorcsolya versenyzo in donto)
            {
                // sw.WriteLine(helyezes+". "+versenyzo.Nev+";"+versenyzo.Orszagkod+";"+ (versenyzo.Tpont + versenyzo.Kpont - versenyzo.Hibapont));
                sw.WriteLine(helyezes + ". " + versenyzo.Nev + ";" + versenyzo.Orszagkod + ";" + (OsszPontszam(versenyzo.Nev)));
                helyezes++;
            }

            sw.Flush();
            sw.Close();
            fs3.Close();
        }
    }
}
