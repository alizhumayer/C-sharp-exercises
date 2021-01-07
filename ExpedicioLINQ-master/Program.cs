using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ExpedicioLINQ
{
    class Program
    {
        static List<Expedicio> uzenetek = new List<Expedicio>();
        static void Main(string[] args)
        {
            Feladat1();
            Feladat2();
            Feladat3();
            Feladat4();
            Feladat5();
            Feladat6();
            Feladat7();
            ReadKey();
        }

        private static void Feladat1()
        {
            StreamReader sr = new StreamReader("vetel.txt");
            while (!sr.EndOfStream)
            {
                uzenetek.Add(new Expedicio(sr.ReadLine(),sr.ReadLine()));
            }
            sr.Close();
        }

        /* Írja a képernyőre, hogy melyik rádióamatőr rögzítette az állományban szereplő első és
        melyik az utolsó üzenetet! */
        private static void Feladat2()
        {
            WriteLine("Az első üzenet rögzítője: {0} \nAz utolsó üzenet rögzítője: {1}", uzenetek.First().Ado, uzenetek.Last().Ado);
        }

        /* Adja meg az összes olyan feljegyzés napját és a rádióamatőr sorszámát, amelynek
        szövegében a „farkas” karaktersorozat szerepel!*/
        private static void Feladat3()
        {
            WriteLine(uzenetek.Where(x => x.Szoveg.Contains("farkas")).Aggregate("", (c, n) => c += String.Format("\n{0}. nap: {1}. rádióamatőr", n.Nap, n.Ado)));
        }

        /* Készítsen statisztikát, amely megadja, hogy melyik napon hány rádióamatőr készített
        feljegyzést. Azok a napok 0 értékkel szerepeljenek, amikor nem született feljegyzés!
        Az eredmény a képernyőn jelenjen meg a napok sorszáma szerint növekvően!
        A megjelenítést a feladat végén látható minta szerint alakítsa ki!*/
        private static void Feladat4()
        {
            Array.ForEach(Enumerable.Range(1, 11).ToArray(), i => WriteLine("{0}. nap: {1} rádióamatőr", i, uzenetek.Count(x => x.Nap == i)));
        }

        /* A rögzített üzenetek alapján kísérelje meg helyreállítani az expedíció által küldött
        üzenetet! Készítse el az adaas.txt fájlt, amely napok szerinti sorrendben tartalmazza
        a küldött üzeneteket! Ha egy időpontban senkinél nem volt vétel, akkor azon a ponton a #
        jel szerepeljen! (Feltételezheti, hogy az azonos üzenethez tartozó feljegyzések között
        nincs ellentmondás.)
        Az alábbi minta az első napról tartalmaz három üzenetet: */
        private static void Feladat5()
        {
            List<string> adas = new List<string>();
            Array.ForEach(Enumerable.Range(1, 11).ToArray(), i => { if (uzenetek.Where(x => x.Nap == i).Count() > 0) adas.Add(uzenetek.Where(x => x.Nap == i).Aggregate((c, n) => c += n).Szoveg); });
            File.WriteAllLines("adaas.txt", adas);
        }

        /* Készítsen függvényt szame néven az alábbi algoritmus alapján! A függvény egy
        karaktersorozathoz hozzárendeli az igaz vagy a hamis értéket. A függvény elkészítésekor
        az algoritmusban megadott változóneveket használja! Az elkészített függvényt
        a következő feladat megoldásánál felhasználhatja. */
        private static void Feladat6()
        {
        }

        static bool szame(string szo)
        {
            bool valasz = true;
            for (int i = 0; i < szo.Length; i++)
            {
                if (szo[i] < '0' || szo[i] > '9') valasz = false;
            }
            return valasz;
        }

        /* Olvassa be egy nap és egy rádióamatőr sorszámát, majd írja a képernyőre a megfigyelt
        egyedek számát (a kifejlett és kölyök egyedek számának összegét)! Ha nem volt ilyen
        feljegyzés, a „Nincs ilyen feljegyzés” szöveget jelenítse meg! Ha nem volt megfigyelt
        egyed vagy számuk nem állapítható meg, a „Nincs információ” szöveget jelenítse meg!
        Amennyiben egy számot közvetlenül # jel követ, akkor a számot tekintse nem
        megállapíthatónak! */

        public int Egyedszam()
        {
            int db = 1;
            string[] eszleles = Szoveg.Split(' ')[0].Split(';');
            if (eszleles.Length==2&&szame(eszleles[0])&&szame(eszleles[1]))
            {
                db = int.Parse(eszleles[0]) + int.Parse(eszleles[1]);
            }
            return db;
        }

        private static void Feladat7()
        {
            Write("Adja meg a nap sorszámát!");
            int nap = int.Parse(ReadLine());
            WriteLine("Adja meg a rádióamatőr sorszámát!");
            int ado = int.Parse(ReadLine());
            var f = uzenetek.Where(x => x.Nap == nap && x.Ado == ado);
            WriteLine(f.Count() == 0 ? "Nincs ilyen feljegyzés" : f.First().Egyedszam());
        }
    }
}

