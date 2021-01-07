using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSGradSolutions
{
    [Erettsegi(2006, 2, "Telefonszámla", 1)]
    public class Y2006M02
    {
        static string Be = System.IO.Path.Combine(Program.BasePath, "Forrasok\\4_Telefonszamla\\HIVASOK.TXT");
        static string Ki = System.IO.Path.Combine(Program.BasePath, "megoldas\\percek.txt");

        // egy beszélgetéset tartalmazó osztály
        class Beszelgetes
        {
            // a beszélgetés kezdete
            public TimeSpan Kezdet { get; }
            // a beszélgetés vége
            public TimeSpan Veg { get; }
            // a hívott telefonszám
            public string Telefonszam { get; }

            // csúcsidei hívás-e
            public bool Csucsido
            {
                get
                {
                    return Kezdet.Hours >= 7 && Kezdet.Hours < 18;
                }
            }

            // mobil hívás-e
            public bool Mobil
            {
                get
                {
                    return Telefonszam.StartsWith("39") || Telefonszam.StartsWith("41") || Telefonszam.StartsWith("71");
                }
            }

            // a számlázott percek száma
            public int SzamlazottPercek
            {
                get
                {
                    // Math.Ceiling, mert a megkezdett perc egész percnek számít
                    return (int)Math.Ceiling((Veg - Kezdet).TotalMinutes);
                }
            }

            public Beszelgetes(TimeSpan kezdet, TimeSpan veg, string telefonszam)
            {
                Kezdet = kezdet;
                Veg = veg;
                Telefonszam = telefonszam;
            }
        }

        static List<Beszelgetes> beszelgetesek = new List<Beszelgetes>();

        static void Main(string[] args)
        {
            Feladat1();
            Feladat2();
            Beolvas();
            Feladat3();
            Feladat4();
            Feladat5();
            Feladat6();
        }

        static void Feladat1()
        {
            Kiir(1);
            Console.Write("Adjon meg egy telefonszámot: ");
            var telefonszam = Console.ReadLine();

            // egy beszelgetes példányt készítünk a telefonszámmal, majd megállapítjuk, hogy mobil szám-e
            var mobil = new Beszelgetes(TimeSpan.Zero, TimeSpan.Zero, telefonszam);
            Console.WriteLine($"A megadott telefonszám {(mobil.Mobil ? "" : "nem ")} mobil.");
        }

        static void Feladat2()
        {
            Kiir(2);
            Console.Write("Adja meg a hívás kezdetét (óó pp mm): ");
            var kezdet = IdopontSzovegbol(Console.ReadLine());
            Console.Write("Adja meg a hívás végét (óó pp mm): ");
            var veg = IdopontSzovegbol(Console.ReadLine());
            // egy beszélgetést példányosítunk, hogy megállapítsuk a számlázott perceket
            var beszelgetes = new Beszelgetes(kezdet, veg, "");
            Console.WriteLine($"A beszélgetés idötartama: {beszelgetes.SzamlazottPercek}");
        }

        static void Beolvas()
        {
            // a fájl sorait beolvassuk
            var sorok = System.IO.File.ReadAllLines(Be);
            // a ciklus változóját 2-vel növelkjünk, mert két soronként tartalmaz adatokat
            for (int i = 0; i < sorok.Length; i += 2)
            {
                // minden "elsö" sort szóközönként tagolunk és egész számmá alakítunk
                var sor = sorok[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(s => int.Parse(s)).ToArray();
                // a számokból egy beszélgetést példányosítunk
                beszelgetesek.Add(
                    new Beszelgetes(
                        new TimeSpan(sor[0], sor[1], sor[2]), // a beszélgetés kezdete
                        new TimeSpan(sor[3], sor[4], sor[5]), // a beszélgetés vége
                        sorok[i + 1] // a telefonszám a következö sorban található
                    )
                );
            }
        }

        static void Feladat3()
        {
            // a beszélgetéseket szöveggé alakítjuk:
            // számlázott percek[szóköz]telefonszám
            // és ezeket a fájlba írjuk
            System.IO.File.WriteAllText(Ki, string.Join(Environment.NewLine, beszelgetesek.Select(b => $"{b.SzamlazottPercek} {b.Telefonszam}")));
        }

        static void Feladat4()
        {
            Kiir(4);
            // a csúcsidös hívások száma
            var csucsido = beszelgetesek.Where(b => b.Csucsido).Count();
            // a csúcsidön kívüli beszélgetések száma: összes hívás - csúcsidös hívások
            var csucsidonKivul = beszelgetesek.Count - csucsido;
            Console.WriteLine($"Hívások csúcsidöben: {csucsido}, csúcsidön kívül: {csucsidonKivul}");
        }

        static void Feladat5()
        {
            Kiir(5);
            int mobil = 0, vezetekes = 0;
            for (int i = 0; i < beszelgetesek.Count; i++)
            {
                // ha a hívás mobil, akkor a mobil, különben a vezetekes változó értékét növeljük a beszélgetés számlázott perceinek számával
                if (beszelgetesek[i].Mobil)
                    mobil += beszelgetesek[i].SzamlazottPercek;
                else
                    vezetekes += beszelgetesek[i].SzamlazottPercek;
            }

            Console.WriteLine($"Vezetékes hívások: {vezetekes} perc, mobil hívások: {mobil} perc");
        }

        static void Feladat6()
        {
            Kiir(6);
            int mobil = 0, vezetekes = 0;
            for (int i = 0; i < beszelgetesek.Count; i++)
            {
                // csak a csúcsidös hívásokat vesszük figyelembe
                // a percek megállapításánál ugyanúgy járunk el, mint az elözö feladatnál
                if (beszelgetesek[i].Csucsido)
                {
                    if (beszelgetesek[i].Mobil)
                        mobil += beszelgetesek[i].SzamlazottPercek;
                    else
                        vezetekes += beszelgetesek[i].SzamlazottPercek;
                }
            }

            // az ár megállapítása
            var ar = mobil * 69.175 + vezetekes * 30;
            Console.WriteLine($"Csúcsidei hívások díja: {ar} Ft");
        }

        static TimeSpan IdopontSzovegbol(string ertek)
        {
            // a megadott idöpontot szóközönként elválasztjuk, minden elemet egész számmá alakítunk, 
            // majd az eredményböl TimeSpan példányt készítünk
            var reszek = ertek.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(s => int.Parse(s)).ToArray();
            return new TimeSpan(reszek[0], reszek[1], reszek[2]);
        }

        static void Kiir(int feladat)
        {
            Console.WriteLine($"{feladat}. feladat");
        }
    }
}
