using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSGradSolutions
{
    [Erettsegi(2017, 5, "Tesztverseny", 2)]
    class Y2017M05
    {
        static string Be = System.IO.Path.Combine(Program.BasePath, "Forrasok\\4_Tesztverseny\\valaszok.txt");
        static string Ki = System.IO.Path.Combine(Program.BasePath, "megoldas\\pontok.txt");

        // egy versenyzö adatait tároló osztály
        class Versenyzo
        {
            public string Azonosito { get; }
            public string Valaszok { get; }

            public Versenyzo(string azonosito, string valaszok)
            {
                Azonosito = azonosito;
                Valaszok = valaszok;
            }
        }

        // a helyes válaszokat tároló változó
        static string helyesValaszok;
        // a versenyzöket tároló lista
        static List<Versenyzo> versenyzok = new List<Versenyzo>();

        static void Main(string[] args)
        {
            Feladat1();
            Feladat2();
            var versenyzo = Feladat3();
            Feladat4(versenyzo);
            Feladat5();
            var pontszamok = Feladat6();
            Feladat7(pontszamok);
        }

        static void Feladat1()
        {
            Console.WriteLine("1. feladat: Az adatok beolvasása");
            using (var reader = System.IO.File.OpenText(Be))
            {
                // a helyes válaszok beolvasása
                helyesValaszok = reader.ReadLine();
                while (!reader.EndOfStream)
                {
                    // egy sor szóközzel tagolva
                    var sor = reader.ReadLine().Split(' ');
                    versenyzok.Add(
                        new Versenyzo(
                            sor[0], // azonosító
                            sor[1]  // válaszok
                        )
                    );
                }
            }
            Console.WriteLine();
        }

        static void Feladat2()
        {
            // kiírjuk a versenyzök számát
            Console.WriteLine($"2. feladat: A vetélkedön {versenyzok.Count} versenyzö indult.");
            Console.WriteLine();
        }

        static Versenyzo Feladat3()
        {
            Console.Write($"3. feladat: A versenyzö azonosítója = ");
            // beolvassuk a versenyzö azonosítóját
            var azonosito = Console.ReadLine();
            // megkeressük a versenyzöt a listában
            Versenyzo versenyzo = versenyzok.First(v => v.Azonosito == azonosito);

            // kiírjuk a versenyzö válaszait
            Console.Write(versenyzo.Valaszok);
            Console.WriteLine("\t(a versenyzö válasza");
            Console.WriteLine();
            // visszaadjuk a versenyzöt a következö feladatokhoz
            return versenyzo;
        }

        static void Feladat4(Versenyzo versenyzo)
        {
            Console.WriteLine($"4. feladat:");
            // kiírjuk a helyes válaszokat
            Console.Write(helyesValaszok);
            Console.WriteLine($"\t(a helyes megoldás)");
            // végigmegyünk a helyes válasz karakterein
            for (int i = 0; i < helyesValaszok.Length; i++)
            {
                // ha a versenyzö válaszának i. karaktere megegyezik a helyes válasz i. karakterével
                // akkor kiírunk egy +-t
                if (versenyzo.Valaszok[i] == helyesValaszok[i])
                    Console.Write("+");
                // különben egy szóközt
                else
                    Console.Write(" ");
            }
            Console.WriteLine("\t(a versenyzö helyes válaszai)");
            Console.WriteLine();
        }

        static void Feladat5()
        {
            Console.Write("5. feladat: A feladat sorszáma = ");
            // bekérünk egy számot (-1 az indexelés miatt)
            int sorszam = int.Parse(Console.ReadLine()) - 1;
            // a helyesen válaszolók száma
            float helyesenValaszolok = 0f;
            for (int i = 0; i < versenyzok.Count; i++)
            {
                // ha a versenyzö helyesen válaszolt, megnöveljük a helyesen válaszolók számát
                if (versenyzok[i].Valaszok[sorszam] == helyesValaszok[sorszam])
                    helyesenValaszolok++;
            }
            // kiírjuk az eredményt (0.00 formázás a két tizedesjegyre való kerekítéshez)
            Console.WriteLine($"A feladatra {helyesenValaszolok} fő, a versenyzők {helyesenValaszolok / versenyzok.Count * 100f:0.00}%-a adott helyes választ.");
            Console.WriteLine();
        }

        static int[] Feladat6()
        {
            Console.WriteLine("6. feladat: A versenyzők pontszámának meghatározása");
            Console.WriteLine();

            // az összes versenyzö pontjait tároló tömb
            int[] pontszamok = new int[versenyzok.Count];
            using (var writer = System.IO.File.CreateText(Ki))
            {
                // végigmegyünk a versenyzökön
                for (int i = 0; i < versenyzok.Count; i++)
                {
                    // // megállapítjuk és eltároljuk a versenyzö pontszámát
                    pontszamok[i] = Pontszam(versenyzok[i].Valaszok, helyesValaszok);
                    // fájlba írjuk a versenyzö azonosítóját és az elért pontszámokat
                    writer.WriteLine($"{versenyzok[i].Azonosito} {pontszamok[i]}");
                }
            }
            return pontszamok;
        }

        static void Feladat7(int[] pontszamok)
        {
            // a 3 legmagasabb pontszámot tároló tömb
            // 0. a legmagasabb pontszám
            // 1. a második legmagasabb pontszám
            // 2. a harmadik legmagasabb pontszám
            int[] legmagasabbPontszamok = new int[] { -1, -1, -1 };
            // végigmegyünk a pontszámokon
            for (int i = 0; i < pontszamok.Length; i++)
            {
                // ha a pontszám nagyobb, mint a legmagasabb pontszám
                if (pontszamok[i] > legmagasabbPontszamok[0])
                {
                    // a 2. legmagasabb pontszám a 3. lesz
                    // a legmagasabb pedig a 2.
                    // az aktuális pontszám pedig a legmagasabb
                    legmagasabbPontszamok[2] = legmagasabbPontszamok[1];
                    legmagasabbPontszamok[1] = legmagasabbPontszamok[0];
                    legmagasabbPontszamok[0] = pontszamok[i];
                }
                // különben ha az aktuális pontszám magasabb, mint a második legmagasabb, de kisebb, mint a legmagasabb
                else if (pontszamok[i] > legmagasabbPontszamok[1] && pontszamok[i] < legmagasabbPontszamok[0])
                {
                    // a 2. legmagasabb a 3. lesz
                    // az aktuális pedig a 2.
                    legmagasabbPontszamok[2] = legmagasabbPontszamok[1];
                    legmagasabbPontszamok[1] = pontszamok[i];
                }
                // különben ha az aktuális pontszám magasabb, mint a harmadik és alacsonyabb mint a második
                // akkor az aktuális pontszám lesz a 3. legmagasabb
                else if (pontszamok[i] > legmagasabbPontszamok[2] && pontszamok[i] < legmagasabbPontszamok[1])
                    legmagasabbPontszamok[2] = pontszamok[i];
            }

            Console.WriteLine("7. feladat: A verseny legjobbjai:");
            // végigmegyünk a legmagasabb pontszámokon
            for (int i = 0; i < legmagasabbPontszamok.Length; i++)
            {
                // ha a pontszám -1 (akkor nem volt elég versenyzö különbözö pontszámokkal)
                // kilépünk a ciklusból
                if (legmagasabbPontszamok[i] == -1)
                    break;

                // végigmegyünk a versenyzökön
                for (int j = 0; j < pontszamok.Length; j++)
                {
                    // ha a versenyzö pontszáma megegyezik az aktuális legmagasabb pontszámmal
                    if (pontszamok[j] == legmagasabbPontszamok[i])
                    {
                        // akkor kiírjuk a díjat (+1!), a kapott pontokat (lehetne pontszamok[j] is), és a versenyzö azonosítóját
                        Console.WriteLine($"{i + 1}. díj ({legmagasabbPontszamok[i]} pont): {versenyzok[j].Azonosito}");
                    }
                }
            }
        }

        static int Pontszam(string valaszok, string helyesValaszok)
        {
            // a kapott pontszámok
            int eredmeny = 0;
            // végigmegyünk a válasz karakterein
            for (int i = 0; i < helyesValaszok.Length; i++)
            {
                // ha a válasz helyes
                if (valaszok[i] == helyesValaszok[i])
                {
                    // hozzáadjuk a kérdésért járó pontokat az eredményhez
                    // 1-5. kérdés (0-4)
                    if (i < 5)
                        eredmeny += 3;
                    // 6-10. kérdés (5-9)
                    else if (i < 10)
                        eredmeny += 4;
                    // 11-13. kérdés (10-12)
                    else if (i < 13)
                        eredmeny += 5;
                    // 14. kérdés
                    else
                        eredmeny += 6;
                }
            }
            return eredmeny;
        }
    }
}
