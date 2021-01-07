using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSGradSolutions
{
    [Erettsegi(2009, 10, "Útépítés", 2)]
    class Y2009M10
    {
        static string Be = System.IO.Path.Combine(Program.BasePath, "Forrasok\\4_Utepites\\forgalom.txt");
        static string Ki = System.IO.Path.Combine(Program.BasePath, "megoldas\\also.txt");

        class Jarmu
        {
            // a jármü útszakaszhoz érkezése
            public TimeSpan Ido { get; }
            // az átérési idö másodpercben
            public int AteresiIdo { get; }
            // a város, ahonnan a jármü érkezik
            public string Varos { get; }

            // a jármü sebessége (m/s)
            public double Sebesseg
            {
                get
                {
                    return Math.Round(1000d / AteresiIdo, 1, MidpointRounding.AwayFromZero);
                }
            }

            public Jarmu(TimeSpan ido, int ateresiIdo, string kiindulasiVaros)
            {
                Ido = ido;
                AteresiIdo = ateresiIdo;
                Varos = kiindulasiVaros;
            }
        }

        // a jarmüveket tároló tömb
        static Jarmu[] jarmuvek;

        static void Main(string[] args)
        {
            Feladat1();
            Feladat2();
            Feladat3();
            Feladat4();
            Feladat5();
            Feladat6();
        }

        static void Feladat1()
        {
            var sorok = System.IO.File.ReadAllLines(Be);
            // a tömb példányosítása a fájl elsö sorában tárolt számmal
            jarmuvek = new Jarmu[int.Parse(sorok[0])];
            for (int i = 0; i < jarmuvek.Length; i++)
            {
                var sor = sorok[i + 1].Split(' ');
                jarmuvek[i] = new Jarmu(
                    new TimeSpan(int.Parse(sor[0]), int.Parse(sor[1]), int.Parse(sor[2])),  // idö
                    int.Parse(sor[3]),  // sebesség
                    sor[4]              // város
                    );
            }
        }

        static void Feladat2()
        {
            Kiir(2);
            Console.Write("Adja meg a jármü sorszámát: ");
            // beolvasunk egy számot
            var szam = int.Parse(Console.ReadLine());
            // ha a jármü A város felöl érkezik, akkor Felsö, különben Alsó város felé halad
            Console.WriteLine($"A(z) {szam}. jármü {(jarmuvek[szam - 1].Varos == "A" ? "Felsö" : "Alsó")} város felé haladt.");
        }

        static void Feladat3()
        {
            Kiir(3);
            // az utolsó és utolsó elötti jármü
            Jarmu utolso = null, utolsoElotti = null;
            for (int i = jarmuvek.Length - 1; i >= 0; i--)
            {
                // csak az A városból érkezö jármüvek érdekelnek
                if (jarmuvek[i].Varos == "A")
                {
                    // ha még nincs utolsó jármü, akkor azt tároljuk el
                    if (utolso == null)
                    {
                        utolso = jarmuvek[i];
                    }
                    else
                    {
                        // különben az utolsó elöttit
                        utolsoElotti = jarmuvek[i];
                        break;
                    }
                }
            }
            // ha nem haladna két autó Felsö város felé
            if (utolsoElotti == null || utolso == null)
                Console.WriteLine("Nem haladt két jármü Felsö város felé.");
            else
            {
                // a két autó érkezésének különbségét másodpercben a két idopont kivovásával kapjuk meg
                Console.WriteLine($"Az utolsó két, Felsö város felé haladó jármü az út kezdetét {(int)(utolso.Ido - utolsoElotti.Ido).TotalSeconds} másodperc különbséggel érte el.");
            }
        }

        static void Feladat4()
        {
            Kiir(4);
            // egy 2 dimenziós tömb, amelynek elsö dimenziója az órákat (0-24), a második pedig a városokat (0: A, 1: F) jelenti
            // tömb értékei az adott órában és város felöl érkezö jármüvek száma
            int[,] orak = new int[24, 2];
            for (int i = 0; i < jarmuvek.Length; i++)
            {
                orak[jarmuvek[i].Ido.Hours, jarmuvek[i].Varos == "A" ? 0 : 1]++;
            }

            Console.WriteLine("A szakaszt az alábbi számban érték el a jármüvek óránként (óra, Alsó felöl, Felsö felöl");
            for (int i = 0; i < 24; i++)
            {
                // ha legalább az egyik érték nagyobb, mint 0, akkor volt abban az órában jármü
                if (orak[i, 0] > 0 || orak[i, 1] > 0)
                {
                    Console.WriteLine($"Óra: {i} A: {orak[i, 0]} F: {orak[i, 1]}");
                }
            }
        }

        static void Feladat5()
        {
            Kiir(5);
            // a jármüveket az átérési idö szerint növekvö sorrendbe rendezzük és az elsö 10-et vesszük
            var leggyorsabbak = jarmuvek.OrderBy(j => j.AteresiIdo).Take(10);
            Console.WriteLine("A 10 leggyorsabb jármü:");
            // végigmegyünk az elemeken
            foreach (var item in leggyorsabbak)
            {
                // kiírjuk az elemet
                // a sebességet a 0.0 formázással egy tizedesjegyre kerekítjük
                Console.WriteLine($"Belépési idö: {item.Ido.Hours}:{item.Ido.Minutes}:{item.Ido.Seconds}, Város: {(item.Varos == "A" ? "Alsó" : "Felsö")}, Sebesség: {item.Sebesseg:0.0} m/s");
            }
        }

        static void Feladat6()
        {
            using (var writer = System.IO.File.CreateText(Ki))
            {
                // az utolsó kilépés ideje
                TimeSpan utolsoKilepes = TimeSpan.Zero;
                for (int i = 0; i < jarmuvek.Length; i++)
                {
                    // csak az F város felöl érkezöket vesszük figyelembe
                    if (jarmuvek[i].Varos == "F")
                    {
                        // a kilepes ideje = érkezés ideje + átérés ideje
                        var kilepes = jarmuvek[i].Ido + TimeSpan.FromSeconds(jarmuvek[i].AteresiIdo);
                        // ha a jármü az utolsó kilépés után ér az út végére
                        if (kilepes > utolsoKilepes)
                        {
                            // akkor a kilepes változóban tárolt idöpontban hagyja el az utszakaszt
                            writer.WriteLine($"{kilepes.Hours} {kilepes.Minutes} {kilepes.Seconds}");
                            // eltároljuk az új kilépési idöt
                            utolsoKilepes = kilepes;
                        }
                        else
                        {
                            // különben a jármü gyosabb az elözönél, ezért az ö ideje, a lassabb jármü kilépése
                            writer.WriteLine($"{utolsoKilepes.Hours} {utolsoKilepes.Minutes} {utolsoKilepes.Seconds}");
                        }
                    }
                }
            }
        }

        static void Kiir(int feladat)
        {
            Console.WriteLine($"{feladat}. feladat");
        }
    }
}
