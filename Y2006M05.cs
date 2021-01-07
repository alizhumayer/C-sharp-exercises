using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSGradSolutions
{
    [Erettsegi(2006, 5, "Fehérje", 3)]
    public class Y2006M05
    {
        static string Be = System.IO.Path.Combine(Program.BasePath, "Forrasok\\4_Feherje\\aminosav.txt");
        static string Ki = System.IO.Path.Combine(Program.BasePath, "megoldas\\eredmeny.txt");

        // az egy aminosav adatait tartalmazó osztály
        class Aminosav
        {
            public string Rovidites { get; }
            public char Betujel { get; }
            public int C { get; }
            public int H { get; }
            public int O { get; }
            public int N { get; }
            public int S { get; }

            // az aminosav relativ tömegét megadó tulajdonság
            public int RelativTomeg
            {
                get
                {
                    return C * 12 + H + O * 16 + N * 14 + S * 32;
                }
            }

            public Aminosav(string rovidites, char betujel, int c, int h, int o, int n, int s)
            {
                Rovidites = rovidites;
                Betujel = betujel;
                C = c;
                H = h;
                O = o;
                N = n;
                S = s;
            }
        }

        // az aminosavak tárolása
        static Dictionary<char, Aminosav> aminosavak = new Dictionary<char, Aminosav>();
        // a bsa fehérje tárolása
        static char[] bsa;

        static void Main(string[] args)
        {
            Feladat1();
            using (var kiFajl = System.IO.File.CreateText(Ki))
            {
                Feladat3(kiFajl);
                BeolvasBSA();
                Feladat4(kiFajl);
            }
            Feladat5();
            Feladat6();
        }

        static void Feladat1()
        {
            var sorok = System.IO.File.ReadAllLines(Be);
            for (int i = 0; i < sorok.Length; i += 7)
            {
                aminosavak[sorok[i + 1][0]] = new Aminosav(
                    sorok[i],                   // rövidités
                    sorok[i + 1][0],            // betüjel
                    int.Parse(sorok[i + 2]),    // C
                    int.Parse(sorok[i + 3]),    // H
                    int.Parse(sorok[i + 4]),    // O
                    int.Parse(sorok[i + 5]),    // N
                    int.Parse(sorok[i + 6])     // S
                    );
            }
        }

        static void BeolvasBSA()
        {
            // a bsa fájl beolvasása
            var sorok = System.IO.File.ReadAllLines(System.IO.Path.Combine(Program.BasePath, "Forrasok\\4_Feherje\\bsa.txt"));
            // minden sor elsö karakterét vesszük és az eredményt tömbbé alakítjuk
            bsa = sorok.Where(s => !string.IsNullOrEmpty(s)).Select(s => s[0]).ToArray();
        }

        static void Feladat3(System.IO.StreamWriter writer)
        {
            Kiir(3);
            writer.WriteLine("3. feladat");
            // az aminosavakat tömeg szerint rendezzük
            foreach (var item in aminosavak.Values.OrderBy(a => a.RelativTomeg))
            {
                // a rövidítést és a tömeget a fájlba és a képernyöre írjuk sornként
                var sor = $"{item.Rovidites} {item.RelativTomeg}";
                Console.WriteLine(sor);
                writer.WriteLine(sor);
            }
            writer.WriteLine();
        }

        static void Feladat4(System.IO.StreamWriter writer)
        {
            Kiir(4);
            writer.WriteLine("4. feladat");
            // az egyes atomok számát tartalmazó tömb
            int[] atomok = new int[5];
            foreach (var a in bsa)
            {
                var aSav = aminosavak[a];
                atomok[0] += aSav.C;
                atomok[1] += aSav.H;
                atomok[2] += aSav.O;
                atomok[3] += aSav.N;
                atomok[4] += aSav.S;
            }

            // kapcsolatonként a H és O atomok számát csökkentjük
            // a kapcsolatok száma az aminosavak számánál egyel kisebb!
            // A1 -- A2 -- A3
            // a -- jelöl egy kapcsolatot
            // a fenti példában 3 aminosav között 2 kapcsolat van

            // 2 hidrogén atomot és 1 oxigén atomot vonunk ki a megfelelö tömb-elemekböl
            atomok[1] -= 2 * (bsa.Length - 1);
            atomok[2] -= bsa.Length - 1;

            // meghatározzuk a képletet
            // string.Format egy object[] tömböt vár paraméterként, ezért a szám tömböt, elöbb object típusúvá alakítjuk
            var keplet = string.Format("C {0} H {1} O {2} N {3} S {4}", atomok.Cast<object>().ToArray());

            Console.WriteLine(keplet);
            writer.WriteLine(keplet);
        }

        static void Feladat5()
        {
            Kiir(5);
            // az aktuális lánc kezdete
            int kezdet = 0;
            // az egyes láncokat tartalmazó lista
            // az elemek a lánc-darabok elejét és végét tartalmazzák.
            List<Tuple<int, int>> lancok = new List<Tuple<int, int>>();
            for (int i = 0; i < bsa.Length; i++)
            {
                // ha az i. aminosav Y, W vagy F, akkor a láncot a listához adjuk
                // majd a kezdetet a következö elemre állítjuk
                switch (bsa[i])
                {
                    case 'Y':
                    case 'W':
                    case 'F':
                        lancok.Add(Tuple.Create(kezdet, i));
                        kezdet = i + 1;
                        break;
                }
            }
            // ha a kezdet a lánc elemeinek számátnál kisebb, akkor az utolsó láncot is a listához adjuk
            if (kezdet < bsa.Length)
                lancok.Add(Tuple.Create(kezdet, bsa.Length - 1));

            // az elsö láncdarab hosszát kiszámoljuk
            int max = 1 + lancok[0].Item2 - lancok[0].Item1, maxIndex = 0;
            // a második lánctól végigmegyünk az egyes láncokon
            for (int i = 1; i < lancok.Count; i++)
            {
                // kiszámoljuk az i. lánc hosszát
                // a lánc hossza 1 + lánc vége - lánc eleje
                var hossz = 1 + lancok[i].Item2 - lancok[i].Item1;
                // ha az aktuális lánc hossza nagyobb, mint az eddigi maximum, akkor ennek a láncnak az értékeit tároljuk
                if (hossz > max)
                {
                    max = hossz;
                    maxIndex = i;
                }
            }
            // a lánc pozíciójához is egyet hozzáadunk, mert a tömb indexelése 0-val kezdödik, de a lánc elsö elemének sorszáma 1
            Console.WriteLine($"Leghosszabb darab hossza: {max}, kezdete: {lancok[maxIndex].Item1 + 1}, vége: {lancok[maxIndex].Item2 + 1}");
        }

        static void Feladat6()
        {
            Kiir(6);
            int cisztein = 0;
            // végigmegyünk a teljes lánc hosszán
            for (int i = 0; i < bsa.Length; i++)
            {
                // ha az aminosav R és van utána következö (i<bsa.Length-1)
                // és a következö aminsov A vagy V, akkor befejezzük a ciklust
                if (bsa[i] == 'R' && i < bsa.Length - 1 && (bsa[i + 1] == 'A' || bsa[i + 1] == 'V'))
                    break;
                // ha az aminosav C, akkor megnöveljük a változónkat 1-el
                if (bsa[i] == 'C')
                    cisztein++;
            }
            // kiírjuk a cisztein változó értékét
            Console.WriteLine($"A hasítás utáni elsö fehérjeláncban {cisztein} Cisztein található.");
        }

        static void Kiir(int feladat)
        {
            Console.WriteLine($"{feladat}. feladat");
        }
    }
}
