using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace OtszazLINQ
{
    class Program
    {
        static List<Vasarlo> vasarlok = new List<Vasarlo>();
        static void Main(string[] args)
        {
            Feladat1();
            Feladat2();
            Feladat3();
            Feladat4();
            Feladat5();
            Feladat6();
            Feladat7();
            Feladat8();
            ReadKey();
        }

        #region 
        // 1. Olvassa be és tárolja el a penztar.txt fájl tartalmát!
        private static void Feladat1()
        {
            int sorszam = 1;
            /*
            FileStream fs = new FileStream("penztar.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            while (!sr.EndOfStream)
            {
                vasarlok.Add(new Vasarlo(sr.ReadLine()));
            }
            sr.Close();
            fs.Close();
            */
            foreach (var item in File.ReadAllLines("penztar.txt"))
            {
                if (item == "F") sorszam++;
                else
                {
                    if (vasarlok.Where(x => x.Sorszam == sorszam && x.Nev == item).Count() == 0)
                    {
                        vasarlok.Add(new Vasarlo(sorszam, item, 1));
                    }
                    else
                    {
                        vasarlok.Where(x => x.Sorszam == sorszam && x.Nev == item).First().Db++;
                    }
                }
            }           
        }
        #endregion

        #region 
        // 2. Határozza meg, hogy hányszor fizettek a pénztárnál!
        private static void Feladat2()
        {
            WriteLine("A fizetések száma: {0}",vasarlok.Max(x=>x.Sorszam));
        }
        #endregion

        #region 
        // 3. Írja a képernyőre, hogy az első vásárlónak hány darab árucikk volt a kosarában!
        private static void Feladat3()
        {
            WriteLine("Az első vásárló {0} db. árucikket vásárolt.", vasarlok.Where(x=>x.Sorszam==1).Sum(x=>x.Db));
        }
        #endregion

        #region 
        /* 4. Kérje be a felhasználótól egy vásárlás sorszámát, egy árucikk nevét és egy darabszámot!
        A következő három feladat megoldásánál ezeket használja fel!
        Feltételezheti, hogy a program futtasásakor csak a bemeneti állományban rögzített
        adatoknak megfelelő vásárlási sorszámot és árucikknevet ad meg a felhasználó. */
        private static void Feladat4()
        {
            string[] adatok = ReadLine().Split(' ');
            int sorszam = int.Parse(adatok[0]);
            string nev = adatok[1];
            int db = int.Parse(adatok[2]);
            WriteLine("Adja meg egy vásárlás sorszámát!");
            WriteLine("Adja meg egy árucikk nevét!");
            WriteLine("Adja meg a vásárolt darabszámot!");
            /*
            string[] adatok = sorok.Split(' ');
            sorszam = int.Parse(adatok[0]);
            nev = adatok[1];
            db = int.Parse(adatok[2]);           
            Console.Write("\n4.feladat:\nAdja meg egy vásárlás sorszámát, árucikk nevét,\nés a vásárolt darabszámot szóközzel elválasztva: ");
            string[] m = Console.ReadLine().Split();
            int iSsz = int.Parse(m[0]);
            string iNév = m[1];
            int iDb = int.Parse(m[2]);
            */
        }
        #endregion

        #region 
        /* 5. Határozza meg, hogy a bekért árucikkből
        a.) melyik vásárláskor vettek először, és melyiknél utoljára!
        b.) összesen hány alkalommal vásároltak! */
        private static void Feladat5()
        {
            var cikk = vasarlok.Where(x=>x.Nev==nev);
            WriteLine("Az első vásárlás sorszáma: {0}", cikk.First().Sorszam);
            WriteLine("Az utolsó vásárlás sorszáma: {0}", cikk.Last().Sorszam);
            WriteLine("{0} vásárlás során vettek belőle.", cikk.Count());
        }
        #endregion

        #region 
        /* 6. Határozza meg, hogy a bekért darabszámot vásárolva egy termékből mennyi a fizetendő összeg! 
        A feladat megoldásához készítsen függvényt ertek néven, amely a darabszámhoz a fizetendő összeget rendeli! */
        private static void Feladat6()
        {
            WriteLine("{0} darab vételekor fizetendő: {1}",db, new Vasarlo(0, "", db).Ar);
        }
        #endregion

        #region 
        /* 7. Határozza meg, hogy a bekért sorszámú vásárláskor mely árucikkekből és milyen mennyiségben vásároltak! 
        Az árucikkek nevét tetszőleges sorrendben megjelenítheti. */
        private static void Feladat7()
        {
            WriteLine(vasarlok.Where(x => x.Sorszam == sorszam).Aggregate((c, n) => c += n.Db + " " + n.Nev + "\n"));
        }
        #endregion

        #region 
        /* 8. Készítse el az osszeg.txt fájlt, amelybe soronként az egy-egy vásárlás alkalmával
        fizetendő összeg kerüljön a kimeneti mintának megfelelően! */
        private static void Feladat8()
        {
            FileStream fs = new FileStream("osszeg.txt",FileMode.Create);
            StreamWriter sw = new StreamWriter(fs,Encoding.UTF8);
            foreach (Vasarlo item in vasarlok)
            {
                vasarlok.GroupBy(g => g.Sorszam).Aggregate("", (c, g) => c += g.Key + ": " + g.Sum(x => x.Ar) + "\n");
            }
            sw.Flush();
            sw.Close();
            fs.Close();
        }
        #endregion
    }
}
