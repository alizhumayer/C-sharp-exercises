using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSGradSolutions
{
    [Erettsegi(2011, 10, "Pitypang", 3)]
    class Y2011M10
    {
        static string Be = System.IO.Path.Combine(Program.BasePath, "Forrasok\\4_Pitypang\\pitypang.txt");
        static string Ki = System.IO.Path.Combine(Program.BasePath, "megoldas\\bevetel.txt");

        // egy foglalas adataik
        class Foglalas
        {
            // a turnusok árai
            static int[] TurnusArak = { 9000, 10000, 8000 };

            // a foglalás száma
            public int Sorszam { get; }
            // a szoba száma
            public int SzobaSzam { get; }
            // az érkezés idöpontja
            public int Erkezes { get; }
            // a távozás idöpontja
            public int Tavozas { get; }
            // a vendegek száma
            public int VendegekSzama { get; }
            // kérnek-e reggelit
            public int Reggeli { get; }
            // a foglalás azonosítója
            public string Azonosito { get; }

            // a turnus száma
            public int Turnus
            {
                get
                {
                    if (Erkezes < 121)
                        return 0;
                    else if (Erkezes < 244)
                        return 1;
                    else
                        return 2;
                }
            }

            // a tartózkodás hossza
            public int Tartozkodas
            {
                get { return Tavozas - Erkezes; }
            }

            // a szoba ára
            public int Ar
            {
                get
                {
                    // az alapár a turnus ára
                    int ar = TurnusArak[Turnus];
                    // az árhoz hozzáadjuk a reggeli összegét
                    // a reggeli 1, ha kérték, 0 ha nem
                    // 0|1 * vendégek száma * 1100 -> 0 ha nem kértek, vendégek száma * 1100, ha kértek
                    // majd ezt megszorozzuk a tartózkodás hosszával
                    ar = Tartozkodas * (ar + Reggeli * VendegekSzama * 1100);
                    // ha 3 vendég volt, akkor éjszakánként + 2000
                    if (VendegekSzama == 3)
                        ar += Tartozkodas * 2000;
                    return ar;
                }
            }

            public Foglalas(int sorszam, int szobaszam, int erkezes, int tavozas, int vendegekSzama, int reggeli, string azonosito)
            {
                Sorszam = sorszam;
                SzobaSzam = szobaszam;
                Erkezes = erkezes;
                Tavozas = tavozas;
                VendegekSzama = vendegekSzama;
                Reggeli = reggeli;
                Azonosito = azonosito;
            }
        }

        // a napok száma az egyes hónapokban
        static int[] HonapNapok = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        // a foglalások
        static Foglalas[] foglalasok;

        static void Main(string[] args)
        {
            Feladat1();
            Feladat2();
            Feladat3();
            Feladat4();
            Feladat5();
        }

        static void Feladat1()
        {
            var sorok = System.IO.File.ReadAllLines(Be);
            // a foglalások tömb példányosítása
            foglalasok = new Foglalas[int.Parse(sorok[0])];
            for (int i = 0; i < foglalasok.Length; i++)
            {
                var sor = sorok[i + 1].Split(' ');
                foglalasok[i] = new Foglalas(
                    int.Parse(sor[0]),  // sorszám
                    int.Parse(sor[1]),  // szobaszám
                    int.Parse(sor[2]),  // érkezés
                    int.Parse(sor[3]),  // távozás
                    int.Parse(sor[4]),  // vendégek száma
                    int.Parse(sor[5]),  // reggeli
                    sor[6]              // azonosító
                    );
            }
        }

        static void Feladat2()
        {
            Kiir(2);
            // a foglalásokat a tartózkodás szerint csökkenö sorrendbe rendezzük, majd az elsöt vesszük
            var leghosszabbTartozkodas = foglalasok.OrderByDescending(f => f.Tartozkodas).First();
            Console.WriteLine("A leghosszab tartózkodás:");
            // kiírjuk a foglalás adatait
            Console.WriteLine($"{leghosszabbTartozkodas.Azonosito} ({leghosszabbTartozkodas.Erkezes}) - {leghosszabbTartozkodas.Tartozkodas}");
        }

        static void Feladat3()
        {
            Kiir(3);
            // az éves bevételt tároljuk
            int evesBevetel = 0;
            using (var writer = System.IO.File.CreateText(Ki))
            {
                // végigmegyünk a foglalásokon
                for (int i = 0; i < foglalasok.Length; i++)
                {
                    // az árat kiszámoljuk
                    var ar = foglalasok[i].Ar;
                    // ha ez nem az elsö foglalás, egy sortörést írunk a fájlba
                    if (i > 0)
                        writer.WriteLine();
                    // a fájlba írjuk a foglalás árát
                    writer.Write($"{foglalasok[i].Sorszam}:{ar}");
                    // hozzáadjuk a szoba árát az éves bevételhez
                    evesBevetel += ar;
                }
            }
            // kiírjuk az éves bevételt
            Console.WriteLine($"A szálloda éves bevétele {evesBevetel} Ft.");
        }

        static void Feladat4()
        {
            Kiir(4);
            // az egyes hónapokban eltöltött éjszakák száma
            int[] honapok = new int[12];
            // végigmegyünk a foglalásokon
            for (int i = 0; i < foglalasok.Length; i++)
            {
                // az érkezés napjától a távozás napjáig
                for (int nap = foglalasok[i].Erkezes; nap < foglalasok[i].Tavozas; nap++)
                {
                    // az adott napról megállapítjuk, hogy melyik hónapban van
                    // majd az adott hónaphoz hozzádjuk a vendégek számát
                    honapok[NapSzamHonapra(nap) - 1] += foglalasok[i].VendegekSzama;
                }
            }

            Console.WriteLine("A szálloda statisztikája: ");
            for (int i = 0; i < honapok.Length; i++)
            {
                // kiírjuk az egyes hónapokhoz tartozó éjszakák számát
                Console.WriteLine($"{i + 1}: {honapok[i]} vendégéj");
            }
        }

        static void Feladat5()
        {
            Kiir(5);
            // a 28 szoba
            bool[] szobak = new bool[27];
            Console.Write("Adja meg az érkezés napjának sorszámát: ");
            // az érkezés napja
            int erkezes = int.Parse(Console.ReadLine());
            Console.Write("Adja meg az eltöltendö éjszakák számát: ");
            // a távozás napja (érkezés + eltoltendö éjszakák)
            int tavozas = erkezes + int.Parse(Console.ReadLine());

            // végigmegyünk a foglalásokon
            for (int i = 0; i < foglalasok.Length; i++)
            {
                // ha a foglalás a távozás elött kezdödik és az érkezés után végzödik
                if (foglalasok[i].Erkezes < tavozas && foglalasok[i].Tavozas > erkezes)
                {
                    // akkor a foglalás legalább egy napja a megadott tartózkodással egybeesik
                    // a szobát igazra állítjuk
                    szobak[foglalasok[i].SzobaSzam - 1] = true;
                }
            }
            // megszámoljuk, hogy hány olyan szoba van ami hamis
            var szabadSzobak = szobak.Count(sz => !sz);
            Console.WriteLine($"A megadott idöszakban {szabadSzobak} szoba szabad.");
        }

        static int NapSzamHonapra(int nap)
        {
            // a hónap száma
            int index = 0;
            // amíg a napok száma több, mint a napok száma az adott hónapban
            while (nap > HonapNapok[index])
            {
                // a napok számából kivonjuk a hónap napjainak a számát
                nap -= HonapNapok[index];
                // +1 a hónaphoz
                index++;
            }
            // a nap az index+1. hónapban van
            return index + 1;
        }

        static void Kiir(int feladat)
        {
            Console.WriteLine($"{feladat}. feladat");
        }
    }
}
