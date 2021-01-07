using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSGradSolutions
{
    [Erettsegi(2013, 10, "Közúti ellenőrzés", 3)]
    class Y2013M10
    {
        static string Be = System.IO.Path.Combine(Program.BasePath, "Forrasok\\4_Kozuti_ellenorzes\\jarmu.txt");
        static string Ki = System.IO.Path.Combine(Program.BasePath, "megoldas\\vizsgalt.txt");

        // egy jármü adatait tároló osztály
        class Jarmu
        {
            // az áthaladás ideje
            public TimeSpan Ido { get; }
            // a jármü rendszáma
            public string Rendszam { get; }
            public Jarmu(int ora, int perc, int masodperc, string rendszam)
            {
                Ido = new TimeSpan(ora, perc, masodperc);
                Rendszam = rendszam;
            }
        }

        static Jarmu[] jarmuvek;

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
            // a fájl sorainak beolvasása
            var sorok = System.IO.File.ReadAllLines(Be);
            jarmuvek = new Jarmu[sorok.Length];
            for (int i = 0; i < sorok.Length; i++)
            {
                // egy sor szóközzel tagolva
                var sor = sorok[i].Split(' ');
                jarmuvek[i] = new Jarmu(
                    int.Parse(sor[0]),  // óra
                    int.Parse(sor[1]),  // perc
                    int.Parse(sor[2]),  // másodperc
                    sor[3]              // rendszám
                    );

            }
        }

        static void Feladat2()
        {
            Kiir(2);
            // az ellenörzés kezdete az elsö jármü áthaladásának órája
            var kezdet = jarmuvek[0].Ido.Hours;
            // a vége, az utolsó jármü idöpontjának órája + 1 (pl: 13:49:00 -> 13+1=14 óra)
            var veg = jarmuvek[jarmuvek.Length - 1].Ido.Hours + 1;
            // az eredmény a vége - kezdet számú óra
            Console.WriteLine($"A járörök legalább {veg - kezdet} órát dolgoztak.");
        }

        static void Feladat3()
        {
            Kiir(3);
            Console.WriteLine("Müszaki ellenörzésre kiválasztott jármüvek:");
            // végigmegyün ka jármüveken
            for (int i = 0; i < jarmuvek.Length; i++)
            {
                // az elsö jármüvet ellenörzik (i==0)
                // majd azokat a jármüveket ellenörzik, amelyek áthaladásának órája nagyobb, mint az elözö jármüé
                // pl: jármü1 9:52, jármü2 10:01, jármü 3: 10:05 -> 10>9, jármü2-t ellenörzik, 10<>10, jármü3-at nem ellenörzik
                if (i == 0 || jarmuvek[i].Ido.Hours > jarmuvek[i - 1].Ido.Hours)
                {
                    // kiírjuk az órát (a jármü elhaladásának ideje alapján) és a rendszámot
                    Console.WriteLine($"{jarmuvek[i].Ido.Hours} óra: {jarmuvek[i].Rendszam}");
                }
            }
        }

        static void Feladat4()
        {
            Kiir(4);
            // az egyes jármüvek száma
            int auto = 0, busz = 0, motor = 0, kamion = 0;
            for (int i = 0; i < jarmuvek.Length; i++)
            {
                // ha a jármü rendszáma B, K vagy M karaketrrel kezdodik (Rendszam[0]), akkor a megfelelö változót növeljük meg
                // különben személygépjarmüröl van szo (auto)
                switch (jarmuvek[i].Rendszam[0])
                {
                    case 'B': busz++; break;
                    case 'K': kamion++; break;
                    case 'M': motor++; break;
                    default: auto++; break;
                }
            }
            // kiírjuk az eredményt
            Console.WriteLine("Az ellenörzö pont elött elhaladó jármüvek kategóriánként:");
            Console.WriteLine($"Személygépkocsi: {auto}");
            Console.WriteLine($"Motor: {motor}");
            Console.WriteLine($"Busz: {busz}");
            Console.WriteLine($"Kamion: {kamion}");
        }

        static void Feladat5()
        {
            Kiir(5);
            // a forgalommentes idoszak kezdete, vége és a hossza, ez az idöszak az elsö jármüvel kezdödik
            TimeSpan kezdet = jarmuvek[0].Ido, veg = kezdet, forgalommentesIdoszak = TimeSpan.Zero;
            // végigmegyünk a jármüveken (1-töl)
            for (int i = 1; i < jarmuvek.Length; i++)
            {
                // ha a jármü elhaladásának ideje és az utolsó elhaladó jármü ideje közötti idö nagyobb,
                // mint az eddigi legnagyobb forgalommentes idöszak
                if (jarmuvek[i].Ido - jarmuvek[i - 1].Ido > forgalommentesIdoszak)
                {
                    // eltároljuk az elözö jármü idejét, mint kezdet
                    kezdet = jarmuvek[i - 1].Ido;
                    // az i. jármü idejét, mint vég
                    veg = jarmuvek[i].Ido;
                    // a forgalommentes idöszakot a vég-kezdet adja meg
                    forgalommentesIdoszak = veg - kezdet;
                }
            }

            // kiírjuk a forgalommentes idöszakot
            Console.WriteLine($"A leghosszabb forgalommentes idöszak: {kezdet.Hours}:{kezdet.Minutes}:{kezdet.Seconds} - {veg.Hours}:{veg.Minutes}:{veg.Seconds}");
        }

        static void Feladat6()
        {
            Kiir(6);
            Console.Write("Adja meg a keresett rendszámot: ");
            // beolvasunk egy rendszámot
            var rendszam = Console.ReadLine();
            Console.WriteLine("A keresett rendszámnak megfelelö jármüvek:");

            // végigmegyünk a jármüveken
            for (int i = 0; i < jarmuvek.Length; i++)
            {
                // a talált karakterek száma
                int karakterek = 0;
                // végigmegyünk a jármü rendszámának karakterein
                for (int j = 0; j < rendszam.Length; j++)
                {
                    // ha a megadott rendszámban a j. helyen * szerepel (bármilyen karater a rendszámban elfogadott)
                    // vagy a rendszám j. karaktere megegyezik a i. jármü rendszámának j. karakterével
                    // akkor a talált karakterek számát megnöveljük
                    if (rendszam[j] == '*' || rendszam[j] == jarmuvek[i].Rendszam[j])
                        karakterek++;
                    // különben kilépünk a ciklusból
                    else
                        break;
                }
                // ha a talált karakterek száma megegyezik a rendszám hosszával,
                // akkor minden karakter megfelelö
                // kiírjuk a jármü rendszámát
                if (karakterek == rendszam.Length)
                    Console.WriteLine(jarmuvek[i].Rendszam);
            }
        }

        static void Feladat7()
        {
            // öt percet és az utolsó ellenörzés végét tárolót változók
            TimeSpan otPerc = new TimeSpan(0, 5, 0), ellenorzesVege = TimeSpan.Zero;
            using (var writer = System.IO.File.CreateText(Ki))
            {
                // végigmegyünk a jármüveken
                for (int i = 0; i < jarmuvek.Length; i++)
                {
                    // ha ez az elsö jármü (i==0),
                    // vagy ha a jármü elhaladásának idöpontja az utolsó ellenörzés végén vagy az után érkezik
                    if (i == 0 || jarmuvek[i].Ido >= ellenorzesVege)
                    {
                        // kiírjuk a jármü érkezését és rendszámát a fájlba
                        writer.WriteLine($"{jarmuvek[i].Ido:hh\\ mm\\ ss} {jarmuvek[i].Rendszam}");
                        // ennek az ellenörzésnek a vége a jármü érkezése + 5 perc
                        ellenorzesVege = jarmuvek[i].Ido + otPerc;
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
