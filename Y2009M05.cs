using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSGradSolutions
{
    [Erettsegi(2009, 5, "Lift", 4)]
    class Y2009M05
    {
        static string Be = System.IO.Path.Combine(Program.BasePath, "Forrasok\\4_Lift\\igeny.txt");
        static string Ki = System.IO.Path.Combine(Program.BasePath, "megoldas\\blokkol.txt");

        // egy lift hívásának adatai
        class LiftIgeny
        {
            // a lift hívásának ideje
            public TimeSpan Ido { get; }
            // a csapat száma
            public int Csapat { get; }
            // a kindulási szint
            public int Induloszint { get; }
            // a célszint
            public int Celszint { get; }

            public LiftIgeny(TimeSpan ido, int csapat, int induloszint, int celszint)
            {
                Ido = ido;
                Csapat = csapat;
                Induloszint = induloszint;
                Celszint = celszint;
            }
        }

        // a szintek és a csapatok száma, valamint a kiindulási szint
        static int szintekSzama, csapatokSzama, induloSzint;
        static LiftIgeny[] igenyek;

        static void Main(string[] args)
        {
            Feladat1();
            Feladat2();
            Feladat3();
            Feladat4();
            Feladat5();
            Feladat6();
            // egy véletlen csapat meghatározása
            var veletlenCsapat = new Random().Next(0, csapatokSzama) + 1;
            Feladat7(veletlenCsapat);
            Feladat8(veletlenCsapat);
        }

        static void Feladat1()
        {
            var sorok = System.IO.File.ReadAllLines(Be);
            // a szintek száma
            szintekSzama = int.Parse(sorok[0]);
            // a csapatok száma
            csapatokSzama = int.Parse(sorok[1]);
            // az igények számával példányosított tömb
            igenyek = new LiftIgeny[int.Parse(sorok[2])];
            for (int i = 0; i < igenyek.Length; i++)
            {
                var sor = sorok[i + 3].Split(' ');
                igenyek[i] = new LiftIgeny(
                    new TimeSpan(int.Parse(sor[0]), int.Parse(sor[1]), int.Parse(sor[2])), // a hívás ideje
                    int.Parse(sor[3]),   // csapat
                    int.Parse(sor[4]),   // induló szint
                    int.Parse(sor[5])    // célszint
                    );
            }
        }

        static void Feladat2()
        {
            Kiir(2);
            Console.Write("Adja meg a lift indulási helyét: ");
            // beolvassuk a kiindulási szintet
            induloSzint = int.Parse(Console.ReadLine());
        }

        static void Feladat3()
        {
            Kiir(3);
            // az utolsó igény a tömb utolsó eleme, ennek a célszintjét kell kiírnunk
            var utolsoIgeny = igenyek[igenyek.Length - 1];
            Console.WriteLine($"A lift a(z) {utolsoIgeny.Celszint}. szinten áll az utolsó igény teljesítése után.");
        }

        static void Feladat4()
        {
            Kiir(4);
            // a legalacsonyabb és legmagasabb szint (a kiindulási szintent érintettük)
            int min = induloSzint, max = induloSzint;
            for (int i = 0; i < igenyek.Length; i++)
            {
                // ha az indulószint kisebb mint az eddigi legalacsonyabb
                // vagy nagyobb min az eddigi legmagasabb
                // akkor a megfelelö változó értékét frissítjük
                // ugyanígy a célszinttel
                if (igenyek[i].Induloszint < min)
                    min = igenyek[i].Induloszint;
                if (igenyek[i].Induloszint > max)
                    max = igenyek[i].Induloszint;
                if (igenyek[i].Celszint < min)
                    min = igenyek[i].Celszint;
                if (igenyek[i].Celszint > max)
                    max = igenyek[i].Celszint;
            }
            // kiírjuk az eredményt
            Console.WriteLine($"A(z) {min}. szint volt a legalacsonyabb, a(z) {max}. szint volt a legmagasabb, amelyet a lift érintett.");
        }

        static void Feladat5()
        {
            Kiir(5);
            // az a szint, ahol a lift éppen áll
            var aktualisSzint = induloSzint;
            // a felfelé indulások számai
            int felUtassal = 0, felUtasNelkul = 0;
            for (int i = 0; i < igenyek.Length; i++)
            {
                // ha az indulószint nagyobb, mint ahol a lift áll, akkor utas nélkül megy fel
                if (igenyek[i].Induloszint > aktualisSzint)
                {
                    felUtasNelkul++;
                }
                // ha a célszint nagyobb, mint az indulószint, akkor utassal megy fel
                if (igenyek[i].Induloszint > igenyek[i].Celszint)
                {
                    felUtassal++;
                }
                // az éppen aktuális szint az, aho la lift megáll
                aktualisSzint = igenyek[i].Celszint;
            }
            // az eredmény kiírása
            Console.WriteLine($"A lift {felUtassal} alkalomman indult felfelé utassal, {felUtasNelkul} alkalommal pedig utas nélkül.");
        }

        static void Feladat6()
        {
            Kiir(6);
            // a csapatok
            bool[] csapatok = new bool[csapatokSzama];
            for (int i = 0; i < igenyek.Length; i++)
            {
                // ha a csapat igénybevette a liftet, akkor igaz
                csapatok[igenyek[i].Csapat - 1] = true;
            }

            Console.WriteLine("Az alábbi csapatok nem vették igénybe a liftet: ");
            // változó, ami azt mondja meg, hogy volt-e olyan csapat, akik nem lifteztek
            bool vanLiftNelkuliCsapat = false;
            for (int i = 0; i < csapatok.Length; i++)
            {
                if (!csapatok[i])
                {
                    // ha már kiírtunk egy csapatot, akkor egy szóközt írunk ki
                    if (vanLiftNelkuliCsapat)
                        Console.Write(" ");
                    // kiírjuk a csapat számát (+1!)
                    Console.Write(i + 1);
                    // a lift nélküli csapat változót igazra állítjuk
                    vanLiftNelkuliCsapat = true;
                }
            }
            // ha nincs nem liftezö csapat, kiírjuk, hogy nincs ilyen
            if (!vanLiftNelkuliCsapat)
                Console.Write("Nincs olyan csapat, amelyik nem vette igénybe a liftet.");
            Console.WriteLine();
        }

        static void Feladat7(int csapat)
        {
            Kiir(7);
            // az a szint, ahol a csapat tartózkodott
            int aktualisSzint = -1;
            List<string> szabalytalanKozlekedesek = new List<string>();
            for (int i = 0; i < igenyek.Length; i++)
            {
                // ha az igény a keresett csapathoz tartozik
                if (igenyek[i].Csapat == csapat)
                {
                    // ha az aktuális szint -1, akkor ez a csapat elsö igénye
                    // eltároljuk azt a szintet, ahova a csapat ment
                    if (aktualisSzint == -1)
                        aktualisSzint = igenyek[i].Celszint;
                    else
                    {
                        // különben, ha nem arról a szintröl hívják a liftet, ahol elözöleg voltak
                        if (aktualisSzint != igenyek[i].Induloszint)
                        {
                            // akkor van szabálytalanság
                            // az elözö szintröl mentek arra a szintre, ahonnan most a liftet hívják
                            szabalytalanKozlekedesek.Add($"{aktualisSzint} - {igenyek[i].Induloszint}");
                        }
                        // eltároljuk az aktuális célszintent
                        aktualisSzint = igenyek[i].Celszint;
                    }
                }
            }

            // ha volt szabálytalanság
            if (szabalytalanKozlekedesek.Count > 0)
            {
                // kiírjuk a szinteket egy ;-vel elválasztva
                Console.WriteLine($"A(z) {csapat}. csapat az alábbi szintek között szabálytalanul közlekedett:");
                Console.WriteLine(string.Join("; ", szabalytalanKozlekedesek));
            }
            else
            {
                // különben azt, hogy nem volt szabálytalanság
                Console.WriteLine($"A(z) {csapat}. csapat esetében nem bizonyítható szabálytalanság.");
            }
        }

        static void Feladat8(int csapat)
        {
            Kiir(8);

            // ez a feladat feleslegesen túl van bonyolítva
            // a feladat lényege, hogy minden liftbe szálláskor az óra megkérdezi, hogy sikeres volt-e a munka
            // és azt, hogy mi a következö munka kódja
            // tehát a kimenet el van "tolva"
            // minden lift igény esetén a következöt írjuk ki:

            // Befejezés ideje: {az igény ideje}
            // Az elözö munka eredménye: {eredmeny}
            // ----
            // Indulási emelet: {induloszint}
            // Célemelet: {celszint}
            // Feladatkód: {feladatkod}

            Console.WriteLine("Adja meg a blokkolóóra adatait!");
            using (var writer = System.IO.File.CreateText(Ki))
            {
                for (int i = 0; i < igenyek.Length; i++)
                {
                    // csak a keresett csapatot vizsgáljuk
                    if (igenyek[i].Csapat == csapat)
                    {
                        // kiírjuk a befejezés idejét
                        writer.WriteLine($"Befejezés ideje: {igenyek[i].Ido.Hours}:{igenyek[i].Ido.Minutes}:{igenyek[i].Ido.Seconds}");
                        Console.Write("Az elözö munka eredménye (befejezett/befejezetlen): ");
                        // bekérjük és kiírjuk a munka sikerességét
                        writer.WriteLine($"Sikeresség: {Console.ReadLine()}");
                        // kiírunk 4 kötöjelet
                        writer.WriteLine("----");
                        // indulási emelet
                        writer.WriteLine($"Indulási emelet: {igenyek[i].Induloszint}");
                        // célemelet
                        writer.WriteLine($"Célemelet: {igenyek[i].Celszint}");
                        Console.Write("A következö feladat kódja (1-99): ");
                        // bekérjük és kiírjuk a munka kódját
                        writer.WriteLine($"Feladatkód: {Console.ReadLine()}");
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
