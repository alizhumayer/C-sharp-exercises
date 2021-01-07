using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSGradSolutions
{
    [Erettsegi(2010, 10, "Anagramma", 3)]
    class Y2010M10
    {
        static string Be = System.IO.Path.Combine(Program.BasePath, "Forrasok\\4_Anagramma\\szotar.txt");
        static string Ki = System.IO.Path.Combine(Program.BasePath, "megoldas\\abc.txt");
        static string Ki2 = System.IO.Path.Combine(Program.BasePath, "megoldas\\rendezve.txt");

        const byte A = (byte)'a';

        static string[] szavak;

        static void Main(string[] args)
        {
            Feladat1();
            Feladat2();
            Feladat3();
            Feladat4();
            Feladat5();
            Feladat6();
            Feladat7();
        }

        static void Feladat1()
        {
            Kiir(1);
            Console.Write("Adjon meg egy szót: ");
            // beolvasung egy szót
            string szo = Console.ReadLine();
            // a karakterekre bontjuk, elhagyjuk a dupla karaktereket (Distinct)
            var karakterek = szo.ToCharArray().Distinct().ToArray();

            // az egyedi karaktereket szöveggé alakítjuk, vesszövel elválasztva
            Console.WriteLine($"A szó {karakterek.Length} karakterböl áll: {string.Join(", ", karakterek)}");
        }

        static void Feladat2()
        {
            Kiir(2);
            Console.WriteLine("Szavak beolvasása.");
            // beolvassuk a szavakat
            szavak = System.IO.File.ReadAllLines(Be);
        }

        static void Feladat3()
        {
            Kiir(3);
            Console.WriteLine("Szavak karaktereinek fájlba írása.");
            using (var writer = System.IO.File.CreateText(Ki))
            {
                // végigmegyünk a szavakon
                foreach (var szo in szavak)
                {
                    // a szót karakter-tömbbé alakítjuk, a karaktereket pedig sorba rendezzük
                    // majd ezt a fájlba írjuk
                    writer.WriteLine(szo.ToCharArray().OrderBy(c => c).ToArray(), 0, szo.Length);
                }
            }
        }

        static void Feladat4()
        {
            Kiir(4);
            // beolvasunk 2 szót
            Console.Write("Adja meg az elsö szót: ");
            var szo1 = Console.ReadLine();
            Console.Write("Adja meg a második szót: ");
            var szo2 = Console.ReadLine();

            // majd megvizsgáljuk, hogy anagramma-e
            if (Anagramma(szo1, szo2))
                Console.WriteLine("Anagramma");
            else
                Console.WriteLine("Nem anagramma");
        }

        static void Feladat5()
        {
            Kiir(5);
            // beolvasunk egy szót
            Console.Write("Adjon meg egy szót: ");
            var szo = Console.ReadLine();
            Console.WriteLine("A szó anagrammái:");
            // változó, amiben eltároljuk, hogy találtunk-e anagrammát
            bool talalat = false;
            // végigmegyünk a szavakon
            for (int i = 0; i < szavak.Length; i++)
            {
                // ha a beolvasott szó az i. szó anagrammája
                if (Anagramma(szo, szavak[i]))
                {
                    // akkor kiírjuk a szót és a találatot igazra állítjuk
                    talalat = true;
                    Console.WriteLine(szavak[i]);
                }
            }
            // ha nem találtunk egy anagrammát sem, kiírjuk, hogy nem volt találat
            if (!talalat)
                Console.WriteLine("Nincs a szótárban anagramma");
        }

        static void Feladat6()
        {
            Kiir(6);
            Console.WriteLine("A leghosszabb szavak: ");
            // a szavakat hosszúságuk szerint csoportba rendezzük
            // majd a hossz szerint csökkenö sorrendbe rendezzük és az elsöt kiválasztjuk
            var leghosszabbSzavak = szavak.GroupBy(sz => sz.Length).OrderByDescending(g => g.Key).First();
            // a szavakat a betüik szerint csoportositjuk
            var rendezettSzavak = Rendezes(leghosszabbSzavak);
            // végigmegyün kaz egyes csoportok elemein
            foreach (var item in rendezettSzavak.Values.SelectMany(s => s))
            {
                // kiírjuk az egyes szavakat
                Console.WriteLine(item);
            }
        }

        static void Feladat7()
        {
            Kiir(7);
            Console.WriteLine("A szavak rendezése és fájlba írása.");
            // a szavakat anagrammánként csoportosítjuk
            var rendezettSzavak = Rendezes(szavak);
            // az utolsó szavak hosszát eltároljuk
            int utolsoHossza = -1;
            using (var writer = System.IO.File.CreateText(Ki2))
            {
                // a csoportosított szavakar hosszuk szerint rendezzük
                foreach (var item in rendezettSzavak.OrderBy(i => i.Key.Length))
                {
                    // ha az utolsó szavak hossza nem egyezik az aktuális szavak hosszával
                    // és az utlsó hossza nem -1 (ez az elsö csoport)
                    // akkor egy új sort kezdünk, hogy legyen egy üres sor a következö csoport elött
                    if (utolsoHossza > -1 && utolsoHossza != item.Key.Length)
                        writer.WriteLine();
                    // a csoport szavait szóközzel elválasztva a fájlba írjuk
                    writer.WriteLine(string.Join(" ", item.Value));
                    // eltároljuk, hogy mennyi a most írt szavak hossza
                    utolsoHossza = item.Key.Length;
                }
            }
        }

        static Dictionary<string, List<string>> Rendezes(IEnumerable<string> szavak)
        {
            // a csoportosított szavak
            Dictionary<string, List<string>> eredmeny = new Dictionary<string, List<string>>();
            if (szavak == null)
                return eredmeny;
            // végigmegyünk a szavakon
            foreach (var szo in szavak)
            {
                // eltároljuk, hogy volt-e anagramma az eredményben
                bool talalat = false;
                // végigmegyünk az eredményen
                foreach (var item in eredmeny)
                {
                    // ha a szó az eredmény kulcsának anagrammája
                    if (Anagramma(item.Key, szo))
                    {
                        // akkor hozzáadjuk a szót az eredményhez
                        item.Value.Add(szo);
                        // találtunk anagrammát
                        talalat = true;
                        // végeztünk az eredmény-ciklussal
                        break;
                    }
                }
                // ha nem volt anagramma, akkor hozzáadjuk az új szót az eredményhez
                if (!talalat)
                    eredmeny.Add(szo, new List<string> { szo });
            }
            return eredmeny;
        }

        static bool Anagramma(string szo1, string szo2)
        {
            // ha a két szó hossza nem egyezik, akkor nem lehetnek anagrammák
            if (szo1.Length != szo2.Length)
                return false;

            // a szavakat byte-tömbökké alakítjuk
            // nem az egyes karakterek byte-kódjaivá, hanem hogy az egyes karakterek hányszor fordulnak elö!
            var tomb1 = SzoByteTomb(szo1);
            var tomb2 = SzoByteTomb(szo2);
            // végigmegyünk a két tömbön (mindkettö hossza egyenlö)
            for (int i = 0; i < tomb1.Length; i++)
            {
                // ha az aktuális "karakter" száma nem egyezik mindkét tömbben,
                // akkor ez a karakter az egyik szóban nem szerepel annyiszor, mint a másikban
                // thát nem anagramma
                if (tomb1[i] != tomb2[i])
                    return false;
            }
            // különben mindkét szó ugyanazokból a karakterekböl áll
            return true;
        }

        static byte[] SzoByteTomb(string szo)
        {
            // a tömb az angol abc karaktereinek száma szerinti byte-ból áll
            byte[] tomb = new byte[26];
            // végigmegyünk a szó karakterein és megszámoljuk, hogy melyik karakterböl mennyi található meg a szóban
            for (int i = 0; i < szo.Length; i++)
            {
                tomb[szo[i] - A]++;
            }
            return tomb;
        }

        static void Kiir(int feladat)
        {
            Console.WriteLine($"{feladat}. feladat");
        }
    }
}
