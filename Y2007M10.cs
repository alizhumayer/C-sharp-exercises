using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSGradSolutions
{
    [Erettsegi(2007, 10, "Foci", 2)]
    public class Y2007M10
    {
        static string Be = System.IO.Path.Combine(Program.BasePath, "Forrasok\\4_Foci\\meccs.txt");
        static string Ki = System.IO.Path.Combine(Program.BasePath, "megoldas\\stat.txt");

        // egy meccset leíró osztály
        class Meccs
        {
            // a forduló száma
            public int Fordulo { get; }
            // a hazai gólok száma
            public int HazaiGolok { get; }
            // a vendégek góljainak száma
            public int VendegGolok { get; }
            // a hazai gólok a félidöben
            public int HazaiGolokFelido { get; }
            // a vendégek góljai félidöben
            public int VendegGolokFelido { get; set; }
            // a hazai csapat neve
            public string HazaiCsapat { get; }
            // a vendég csapat neve
            public string VendegCsapat { get; }

            // megadja, hogy a meccs végére megfordult-e az elsö félidei állás
            public bool FelidoForditas
            {
                get
                {
                    return (HazaiGolokFelido < VendegGolokFelido && VendegGolok > HazaiGolok) ||
                        (VendegGolokFelido < HazaiGolokFelido && HazaiGolok > VendegGolok);
                }
            }

            // megadja az eredményt szöveg formájában
            public string Eredmeny
            {
                get
                {
                    if (HazaiGolok > VendegGolok)
                        return HazaiGolok.ToString() + "-" + VendegGolok.ToString();
                    else
                        return VendegGolok.ToString() + "-" + HazaiGolok.ToString();
                }
            }

            public Meccs(int fordulo, int hazaiGolok, int vendegGolok, int hazaiGolokFelido, int vendegGolokFelido, string hazaiCsapat, string vendegCsapat)
            {
                Fordulo = fordulo;
                HazaiGolok = hazaiGolok;
                VendegGolok = vendegGolok;
                HazaiGolokFelido = hazaiGolokFelido;
                VendegGolokFelido = vendegGolokFelido;
                HazaiCsapat = hazaiCsapat;
                VendegCsapat = vendegCsapat;
            }
        }

        // a meccseket tároló tömb
        static Meccs[] meccsek;

        static void Main(string[] args)
        {
            Feladat1();
            Feladat2();
            Feladat3();
            var csapat = Feladat4();
            Feladat5(csapat);
            Feladat6(csapat);
            Feladat7();
        }

        static void Feladat1()
        {
            var sorok = System.IO.File.ReadAllLines(Be);
            // meghatározzuk a meccsek számát és ezzel példányosítjuk a tömböt
            meccsek = new Meccs[int.Parse(sorok[0])];
            for (int i = 0; i < meccsek.Length; i++)
            {
                var sor = sorok[i + 1].Split(' ');
                meccsek[i] = new Meccs(
                    int.Parse(sor[0]),   // forduló
                    int.Parse(sor[1]),   // hazai gólok
                    int.Parse(sor[2]),   // vendég gólok
                    int.Parse(sor[3]),   // hazai gólok (félidö)
                    int.Parse(sor[4]),   // vendég gólok (félidö)
                    sor[5],              // hazai csapat
                    sor[6]               // vendég csapat
                    );
            }
        }

        static void Feladat2()
        {
            Kiir(2);
            Console.Write("Adja meg a forduló számát: ");
            // beolvassuk egy forduló számát
            int fordulo = int.Parse(Console.ReadLine());
            // végigmegyünk azon meccseken, amelyek ebben a fordulóban voltak
            foreach (var meccs in meccsek.Where(m => m.Fordulo == fordulo))
            {
                // kiírjuk az eredményeket
                // az azonos pozícióhoz a csapatneveket 20 karakter hosszúságúra növeljük szóközök használatával
                Console.WriteLine($"{meccs.HazaiCsapat.PadRight(20, ' ')}-{meccs.VendegCsapat.PadRight(20, ' ')}: {meccs.HazaiGolok}-{meccs.VendegGolok} ({meccs.HazaiGolokFelido}-{meccs.VendegGolokFelido})");
            }
        }

        static void Feladat3()
        {
            Kiir(3);
            // kiválasztjuk azokat a meccseket, ahol a félidöshöz képest megfordult az állás
            // majd ezeket a forduló szerint növekvö sorrendbe rendezzük
            foreach (var meccs in meccsek.Where(m => m.FelidoForditas).OrderBy(m => m.Fordulo))
            {
                // kiírjuk a forduló számát és a gyöztes nevét
                Console.WriteLine($"{meccs.Fordulo} {(meccs.HazaiGolok > meccs.VendegGolok ? meccs.HazaiCsapat : meccs.VendegCsapat)}");
            }
        }

        static string Feladat4()
        {
            Kiir(4);
            Console.Write("Adja meg a csapat nevét: ");
            // beolvassuk a csapat nevét, majd visszaadjuk azt
            return Console.ReadLine();
        }

        static void Feladat5(string csapat)
        {
            Kiir(5);
            int lottGolok = 0, kapottGolok = 0;
            for (int i = 0; i < meccsek.Length; i++)
            {
                // ha a meccsen az adott csapat volt otthon
                if (meccsek[i].HazaiCsapat == csapat)
                {
                    // akkor a lött gólokhoz adjuk a hazai gólok számát
                    // a kapott gólokhoz pedig a vendég gólok számát
                    lottGolok += meccsek[i].HazaiGolok;
                    kapottGolok += meccsek[i].VendegGolok;
                }
                // különben ha a csapat vendég volt
                else if (meccsek[i].VendegCsapat == csapat)
                {
                    // akkor fordítva adjuk hozzá a gólokat a változók értékéhez
                    kapottGolok += meccsek[i].HazaiGolok;
                    lottGolok += meccsek[i].VendegGolok;
                }
            }
            // kiírjuk az eredményt
            Console.WriteLine($"lött: {lottGolok} kapott: {kapottGolok}");
        }

        static void Feladat6(string csapat)
        {
            Kiir(6);
            // a fordulót egy nagy számra állítjuk
            int fordulo = int.MaxValue;
            // a vendég csapat nevét tároló változó
            string vendegCsapat = "";

            for (int i = 0; i < meccsek.Length; i++)
            {
                // ha a csapat otthon játszott és a vendég csapat gyözött (vendég gólok > hazai gólok)
                // és a forduló száma kisebb a tárolt fordulónál
                if (meccsek[i].HazaiCsapat == csapat && meccsek[i].VendegGolok > meccsek[i].HazaiGolok && meccsek[i].Fordulo < fordulo)
                {
                    // akkor eltároljuk a forduló számát
                    // és a vendég csapat nevét
                    fordulo = meccsek[i].Fordulo;
                    vendegCsapat = meccsek[i].VendegCsapat;
                }
            }

            // ha a forduló nem az a szám, amit az elején eltároltunk,
            // akkor a csapat kikapott otthon
            if (fordulo < int.MaxValue)
            {
                // kiírjuk a forduló számát és a vendég csapat nevét
                Console.WriteLine($"A csapat a(z) {fordulo}. fordulóban kapott ki a(z) {vendegCsapat} csapattól.");
            }
            else
            {
                // különben nem kaptak ki
                Console.WriteLine("A csapat otthon veretlen maradt.");
            }
        }

        static void Feladat7()
        {
            // a meccseket az eredmény szerint csoportosítjuk (az Eredmeny tulajdonság felhasználásával), 
            // majd mindegyik csoportból kiválasztjuk az eredményt és a meccsek számát szöveggé alakítva
            // és ezeket a fájlba írjuk
            System.IO.File.WriteAllLines(Ki, meccsek.GroupBy(m => m.Eredmeny).Select(g => $"{g.Key}: {g.Count()} darab"));
        }

        static void Kiir(int feladat)
        {
            Console.WriteLine($"{feladat}. feladat");
        }
    }
}
