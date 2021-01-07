using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSGradSolutions
{
    [Erettsegi(2010, 5, "Helyjegy", 3)]
    class Y2010M05
    {
        static string Be = System.IO.Path.Combine(Program.BasePath, "Forrasok\\4_Helyjegy\\eladott.txt");
        static string Ki = System.IO.Path.Combine(Program.BasePath, "megoldas\\kihol.txt");

        // egy jegy adait tartalmazó osztály
        class Jegy
        {
            // a hely száma
            public int Hely { get; }
            // a felszállás km-e
            public int Felszallas { get; }
            // a leszállás km-e
            public int Leszallas { get; }

            public Jegy(int hely, int felszallas, int leszallas)
            {
                Hely = hely;
                Felszallas = felszallas;
                Leszallas = leszallas;
            }

            // megadja a jegy árát az alapárral számolva
            public int Jegyar(int alapAr)
            {
                // a megtett út hossza
                var km = Leszallas - Felszallas;
                // az út ára 10 kilóméterenként
                // a megtett utat 10-el osztjuk, majd ha az nem osztható 10-el maradék nélkül, akkor egyet hozzáadunk
                // majd ezt szorozzuk meg az út alapárával
                var ar = (km / 10 + (km % 10 == 0 ? 0 : 1)) * alapAr;
                // majd 5 Ft-ra kerekítünk
                // 1|6 mod 5 = 1 -> -1
                // 2|7 mod 5 = 2 -> -2
                // 3|8 mod 5 = 3 -> 5-3=+2
                // 4|9 mod 5 = 4 -> 5-4=+1
                // 0|5 mod 5 = 0 -> +/-0
                var maradek = ar % 5;
                if (maradek < 3)
                    ar -= maradek;
                else
                    ar += 5 - maradek;
                return ar;
            }
        }

        // eladott jegyek
        static Jegy[] jegyek;
        // alapár, út hossza
        static int alapAr, utHossz;

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
            var sorok = System.IO.File.ReadAllLines(Be);
            var sor = sorok[0].Split(' ');
            // az eladott jegyek száma alapján tömb példányosítás
            jegyek = new Jegy[int.Parse(sor[0])];
            utHossz = int.Parse(sor[1]); // az út hossza
            alapAr = int.Parse(sor[2]);  // a jegyek alapára

            for (int i = 0; i < jegyek.Length; i++)
            {
                sor = sorok[i + 1].Split(' ');
                jegyek[i] = new Jegy(
                    int.Parse(sor[0]),  // hely
                    int.Parse(sor[1]),  // felszállás
                    int.Parse(sor[2])   // leszállás
                    );
            }
        }

        static void Feladat2()
        {
            Kiir(2);
            // az utolsó jegy adatai
            var utolso = jegyek[jegyek.Length - 1];
            Console.WriteLine($"Az utolsó vásárló a {utolso.Hely}. helyen ült és {utolso.Leszallas - utolso.Felszallas} km-t tett meg.");
        }

        static void Feladat3()
        {
            Kiir(3);
            Console.WriteLine("Az alábbit utasok utazták végig a teljes utat:");
            // van-e olyan utas, aki végig utazott
            bool vanUtas = false;
            for (int i = 0; i < jegyek.Length; i++)
            {
                // ha a felszállás a 0. km-nél történt, a leszállás pedig az utolsó km-nél,
                // akkor végigutazta az utat
                if (jegyek[i].Felszallas == 0 && jegyek[i].Leszallas == utHossz)
                {
                    // ha ez az elsö ilyen utas, akkor kiírjuk a számát (i+1 a tömb indexelése miatt)
                    if (!vanUtas)
                        Console.Write(i + 1);
                    else
                        Console.Write($" {i + 1}"); // különben egy szóközzel elválasztva írjuk ki a számát
                    vanUtas = true;
                }
            }
            // ha nem volt olyan utas, akkor kiírjuk, hogy nem volt ilyen
            if (!vanUtas)
                Console.Write("Nincs olyan utas, aki végigutazta az utat.");
            Console.WriteLine();
        }

        static void Feladat4()
        {
            Kiir(4);
            // összeadjuk a jegyek árát
            // egy jegy árát a jegy.Jegyar(alapAr) függvény adja vissza
            // ezeket adjuk össze a Sum függvény segítségével
            Console.WriteLine($"A társaságnak {jegyek.Sum(j => j.Jegyar(alapAr))} Ft bevétele származott.");
        }

        static void Feladat5()
        {
            Kiir(5);
            // az utolsó megálló km-e
            int utolsoMegalloKm = 0;
            // a le- és felszállók száma
            int leszallok = 0, felszallok = 0;
            for (int i = 0; i < jegyek.Length; i++)
            {
                // ha a leszállás a végállomás elött történt
                // és a leszállás megállója nagyobb, mint az eddigi legutolsó megálló
                if (jegyek[i].Leszallas < utHossz && jegyek[i].Leszallas > utolsoMegalloKm)
                {
                    // akkor az utolsó megálló az ezen jegy leszállása
                    utolsoMegalloKm = jegyek[i].Leszallas;
                    // és 1 fö szállt le, 0 fel
                    leszallok = 1;
                    felszallok = 0;
                }
                // különben, ha a felszállás megállója az eddigi utolsó megálló után van
                else if (jegyek[i].Felszallas > utolsoMegalloKm)
                {
                    // akkor az utolsó megállo az ezen jegy felszállása
                    utolsoMegalloKm = jegyek[i].Felszallas;
                    // és 1 fö szállt fel, 0 le
                    felszallok = 1;
                    leszallok = 0;
                }
                // különben, ha a felszállás megállója megegyezik az eddigi utolsóval
                else if (jegyek[i].Felszallas == utolsoMegalloKm)
                    felszallok++;   // akkor +1 felszálló
                // különben, ha a leszállás megállója megegyezik az eddigi utolsóval
                else if (jegyek[i].Leszallas == utolsoMegalloKm)
                    leszallok++;    // akkor +1 leszálló
            }
            // kiírjuk az eredményt
            Console.WriteLine($"Az utolsó megállóban {leszallok} utas szállt le és {felszallok} utas szállt fel.");
        }

        static void Feladat6()
        {
            Kiir(6);
            // az összes felszálló és leszálló megállót vesszük, a 0. és utHossz. megállókat kivesszük, 
            // majd megszámoljuk, hogy hány egyedi (Distinct) megálló van
            var megallok = jegyek.Select(j => j.Felszallas).Concat(jegyek.Select(j => j.Leszallas)).Where(km => km > 0 && km < utHossz).Distinct().Count();
            Console.WriteLine($"A busz {megallok} megállóban állt meg.");
        }

        static void Feladat7()
        {
            Kiir(7);
            Console.Write("Adja meg a kiindulási ponttól mért távolságot kilóméterben: ");
            // beolvassuk a távolságot
            int km = int.Parse(Console.ReadLine());

            // a 48 hely tömbje
            int[] helyek = new int[48];
            // végigmegyünk a jegyeken
            for (int i = 0; i < jegyek.Length; i++)
            {
                // ha az utas a megadott km-en, vagy az elött szállt fel
                // és a megadott km után szállt le
                if (jegyek[i].Felszallas <= km && jegyek[i].Leszallas > km)
                {
                    // akkor a buszon utazott és a helyhez eltároljuk a jegy sorszámát
                    // hely-1 és i+1 az indexelés miatt
                    helyek[jegyek[i].Hely - 1] = i + 1;
                }
            }
            // fájlba írjuk az eredményt
            // a Select függvény paraméterként egy olyan kifejezést is kaphat, aminek 2. paramétere az adott elem indexe
            System.IO.File.WriteAllLines(
                Ki,
                helyek.Select(
                    (utas, hely) => $"{hely + 1}. ülés: {(utas > 0 ? $"{utas}. utas" : "üres")}"
                )
            );
        }

        static void Kiir(int feladat)
        {
            Console.WriteLine($"{feladat}. feladat");
        }
    }
}
