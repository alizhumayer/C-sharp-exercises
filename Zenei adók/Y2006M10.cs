using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSGradSolutions
{
    [Erettsegi(2006, 10, "Zenei adók", 3)]
    public class Y2006M10
    {
        static string Be = System.IO.Path.Combine(Program.BasePath, "Forrasok\\4_Zenei_adok\\musor.txt");
        static string Ki = System.IO.Path.Combine(Program.BasePath, "megoldas\\keres.txt");

        class Zene
        {
            public int Radio { get; }
            public TimeSpan Hossz { get; }
            public string Eloado { get; }
            public string Cim { get; }

            public string Azonosito { get; }

            public Zene(int radio, TimeSpan hossz, string azonosito)
            {
                Radio = radio;
                Hossz = hossz;
                Azonosito = azonosito;
            }
        }

        static Zene[] zenek;

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
            // a zeneszámok számának meghatározása
            zenek = new Zene[int.Parse(sorok[0])];
            for (int i = 0; i < zenek.Length + 1; i++)
            {
                // a zene sora i+1, mert a 0. sorban a zenék száma van
                var sor = sorok[i + 1].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                zenek[i] = new Zene(
                    int.Parse(sor[0]),  // az adó száma
                    new TimeSpan(0, int.Parse(sor[1]), int.Parse(sor[2])),  // a zeneszám hossza
                    string.Join(" ", sor.Skip(3)) // az elöadó és a szám címe (mindkettö tartalmazhat szóközöket, ezért az elsö 3 elem kivételével a többi elmböl szóközzel tagolt szöveget készítpnk
                    );
            }
        }

        static void Feladat2()
        {
            Kiir(2);
            int[] adok = new int[3];
            for (int i = 0; i < zenek.Length; i++)
            {
                // az adó 1-3, tehát minden szám esetén a tömb adó-1. elemét növeljük meg
                adok[zenek[i].Radio - 1]++;
            }
            for (int i = 0; i < adok.Length; i++)
            {
                // kiírjuk az adókon elhangzott számok számát
                Console.WriteLine($"Számok a(z) {i + 1} adón: {adok[i]}");
            }
        }

        static void Feladat3()
        {
            Kiir(3);
            var eloado = "Eric Clapton";
            // az elso szám kezdetét, az utolsó végét és az aktuális idöt tároljuk el
            TimeSpan elsoKezdete = TimeSpan.Zero, utolsoVege = TimeSpan.Zero, ido = TimeSpan.Zero;

            for (int i = 0; i < zenek.Length; i++)
            {
                // csak az 1. adót vesszük figyelembe
                if (zenek[i].Radio == 1)
                {
                    // ha az elöadó Eric Clapton
                    if (zenek[i].Azonosito.StartsWith(eloado))
                    {
                        // ha ez az elsö szám (az elsö kezdete 00:00:00), akkor eltároljuk a szám kezdetét (ido)
                        if (elsoKezdete == TimeSpan.Zero)
                            elsoKezdete = ido;
                        // az utolsó szám vég az aktuális idö + a szám hossza
                        utolsoVege = ido + zenek[i].Hossz;
                    }
                    // az aktuális idöhöz hozzáadjuk a szám hosszát
                    ido += zenek[i].Hossz;
                }
            }
            // az idötartam az utolsó vége és az elsö kezdete között eltelt idö
            var idotartam = utolsoVege - elsoKezdete;
            Console.WriteLine($"Az 1. adón az elsö és utolsó {eloado} szam között eltelt idö: {idotartam.Hours}:{idotartam.Minutes}:{idotartam.Seconds}");
        }

        static void Feladat4()
        {
            Kiir(4);
            Zene[] utolsoSzamok = new Zene[3];
            // eltároljuk, melyik adón, melyik szám szól éppen
            for (int i = 0; i < zenek.Length; i++)
            {
                // ha az aktuális szám az amelyiket keressük
                if (zenek[i].Azonosito == "Omega:Legenda")
                {
                    // kiírjuk az adó számát
                    Console.WriteLine($"Omega: Legenda a(z) {zenek[i].Radio} adón szólt.");
                    // végigmenyünk az utolsó számokon
                    for (int j = 0; j < utolsoSzamok.Length; j++)
                    {
                        // ha nem az aktuális adóról van szó
                        if (j != zenek[i].Radio - 1)
                        {
                            // kiírjuk, hogy melyik szám szólt a másik adón
                            Console.WriteLine($"A(z) {i + 1} adón {utolsoSzamok[i].Azonosito} szólt.");
                        }
                    }
                    // végeztünk a ciklussal
                    break;
                }
                else
                {
                    // eltároljuk a tömb megfelelö elemébe, melyik szám szól
                    utolsoSzamok[zenek[i].Radio - 1] = zenek[i];
                }
            }
        }

        static void Feladat5()
        {
            Kiir(5);
            Console.Write("Adja meg a felismert karaktereket: ");
            // a beolvasott kulcsszót kisbetüssé alakítjuk
            var kulcsszo = Console.ReadLine().ToLower();
            using (var writer = System.IO.File.CreateText(Ki))
            {
                for (int i = 0; i < zenek.Length; i++)
                {
                    // a szám azonosítóját kisbetüssé alakítjuk
                    var azon = zenek[i].Azonosito.ToLower();
                    int karakterek = 0;
                    // végigmegyünk a szám azonosítójának karakterein
                    for (int j = 0; j < azon.Length; j++)
                    {
                        // ha a sza´m azonosítójának karaktere megegyezik a kulcsszó aktualis karakterével
                        if (azon[j] == kulcsszo[karakterek])
                        {
                            // akkor a következö karakterre váltunk
                            karakterek++;
                            // ha a talált karakterek száma megegyezik a kulcsszó karaktereinek számával
                            // akkor a szám azonosítója a megfelelö sorrendben tartalmazza az összes keresett karaktert
                            if (karakterek == kulcsszo.Length)
                            {
                                // a fájlba írjuk a szám azonosítóját
                                writer.WriteLine(zenek[i].Azonosito);
                                // végeztünk a belsö ciklussal
                                break;
                            }
                        }
                    }
                }
            }
        }

        static void Feladat6()
        {
            Kiir(6);
            // egy perc hossza
            TimeSpan egyPerc = new TimeSpan(0, 1, 0);
            // az aktuális idö (00:03:00) mert híradóval kezdünk
            TimeSpan ido = new TimeSpan(0, 3, 0);

            for (int i = 0; i < zenek.Length; i++)
            {
                // csak az 1. adón játszott számokat vizsgáljuk
                if (zenek[i].Radio != 1) continue;

                // a szám hossza egy perccel megnövelve
                var hossz = egyPerc + zenek[i].Hossz;
                // a szám végének ideje
                var ujIdo = ido + hossz;

                // átérne a következö napra
                if (ujIdo.TotalHours > 24)
                {
                    ido = new TimeSpan(23, 59, 59);
                    break;
                }

                // ha a szám vége a következö órában érne véget
                if (ujIdo.Hours > ido.Hours)
                {
                    // akkor a következö óra + 3 perchez adjuk a szám egy perccel növelt hosszát
                    ido = new TimeSpan(ido.Hours + 1, 3, 0) + hossz;
                }
                else
                {
                    // különben az aktuális idö a szám hosszával növelt idö
                    ido = ujIdo;
                }
            }
            // kiírjuk az eredményt
            Console.WriteLine($"A müsor {ido.Hours}:{ido.Minutes}:{ido.Seconds} érne véget.");
        }

        static void Kiir(int feladat)
        {
            Console.WriteLine($"{feladat}. feladat");
        }
    }
}
