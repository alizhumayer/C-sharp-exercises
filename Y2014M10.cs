using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSGradSolutions
{
    [Erettsegi(2014, 10, "Nézőtér", 2)]
    class Y2014M10
    {
        static string Be1 = System.IO.Path.Combine(Program.BasePath, "Forrasok\\4_Nezoter\\foglaltsag.txt");
        static string Be2 = System.IO.Path.Combine(Program.BasePath, "Forrasok\\4_Nezoter\\kategoria.txt");
        static string Ki = System.IO.Path.Combine(Program.BasePath, "megoldas\\szabad.txt");

        // a helyeket tároló tömb
        static char[,] helyek = new char[15, 20];
        // a kategóriákat tároló tömb
        static byte[,] kategoriak = new byte[15, 20];
        // az összes hely száma
        static float helyekSzama = 15 * 20;


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
            using (var readerHely = System.IO.File.OpenText(Be1))
            using (var readerKategoria = System.IO.File.OpenText(Be2))
            {
                int sor = 0;
                while (!readerHely.EndOfStream)
                {
                    // beolvasunk egy sort a foglaltságról
                    var helySor = readerHely.ReadLine();
                    // és a hozzá tartozó kategóriákat
                    var kategoriaSor = readerKategoria.ReadLine();
                    for (int i = 0; i < helySor.Length; i++)
                    {
                        // a sorok karaktereit eltároljuk a megfelelö tömbökben
                        helyek[sor, i] = helySor[i];
                        kategoriak[sor, i] = (byte)(kategoriaSor[i] - '0');
                    }
                    sor++;
                }
            }
        }

        static void Feladat2()
        {
            Kiir(2);
            // beolvasunk egy sort és egy széket
            Console.Write("Adja meg a sor számát: ");
            int sor = int.Parse(Console.ReadLine());
            Console.Write("Adja meg a szék számát: ");
            int szek = int.Parse(Console.ReadLine());
            // a helyek tömb tartalmazza a foglaltságot, ha az érték 'x', akkor foglalt
            Console.WriteLine($"A(z) {sor}. sor {szek}. helye {(helyek[sor - 1, szek - 1] == 'x' ? "foglalt" : "szabad")}.");
        }

        static void Feladat3()
        {
            Kiir(3);
            float foglaltHelyek = 0f;
            // megszámoljuk a foglalt helyeket
            // elöször a sorokon megyünk végig
            for (int i = 0; i < 15; i++)
            {
                // majd a székeken
                for (int j = 0; j < 20; j++)
                {
                    // ha a szék foglalt, megnöveljük a foglalt helyek számát
                    if (helyek[i, j] == 'x')
                        foglaltHelyek++;
                }
            }
            // a százalékot egész számra kerekítjük a 0 formázással
            var eladottJegyekSzazalek = (foglaltHelyek / helyekSzama) * 100;
            Console.WriteLine($"Az elöadásra eddig {foglaltHelyek} jegyet adtak el, ez a nezötér {eladottJegyekSzazalek:0}%-a.");
        }

        static void Feladat4()
        {
            Kiir(4);
            // az egyes kategóriákban eladott jegyek száma
            int[] kategoriaJegyek = new int[5];
            // a legtöbb jegy kategóriájának indexe
            int max = 0;
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    // ha a hely foglalt
                    if (helyek[i, j] == 'x')
                    {
                        // akkor megnöveljük a kategóriában eladott jegyek számát
                        // majd megvizsgáljuk, hogy ez a szám nagyobb, mint az eddigi maximum
                        // akkor a max-ban tárolt értéket a kategória indexére változtatjuk
                        if (++kategoriaJegyek[kategoriak[i, j] - 1] > kategoriaJegyek[max])
                            max = kategoriak[i, j] - 1;
                    }

                }
            }
            // kiírjuk az eredményt
            Console.WriteLine($"A legtöbb jegyet a(z) {max + 1}. árkategóriában értékesítették.");
        }

        static void Feladat5()
        {
            Kiir(5);
            // a teljes bevétel
            int bevetel = 0;
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    // ha a hely foglalt
                    if (helyek[i, j] == 'x')
                    {
                        // akkor a kategóriának megfelelö árat a bevételhez adjuk
                        switch (kategoriak[i, j])
                        {
                            case 1: bevetel += 5000; break;
                            case 2: bevetel += 4000; break;
                            case 3: bevetel += 3000; break;
                            case 4: bevetel += 2000; break;
                            case 5: bevetel += 1500; break;
                        }
                    }
                }
            }
            // kiírjuk az eredményt
            Console.WriteLine($"A színház bevétele a pillanatnyilag eladott jegyek alapján {bevetel} Ft.");
        }

        static void Feladat6()
        {
            Kiir(6);
            // az egyedülálló helyek száma
            int egyedulalloHelyek = 0;
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    // ha a hely szabad
                    if (helyek[i, j] == 'o')
                    {
                        // és ez az elsö hely a sorban és a második szék foglalt
                        if (j == 0 && helyek[i, 1] == 'x')
                            egyedulalloHelyek++;
                        // vagy ez az utolsó hely és az elöttelévö szék foglalt
                        else if (j == 19 && helyek[i, 18] == 'x')
                            egyedulalloHelyek++;
                        // vagy a hely elötti és utáni székek foglaltak, akkor megnöveljük az egyedülálló helyek számát
                        else if (j > 0 && j < 19 && helyek[i, j - 1] == 'x' && helyek[i, j + 1] == 'x')
                            egyedulalloHelyek++;
                    }
                }
            }
            // kiírjuk az eredményt
            Console.WriteLine($"A nézötéren {egyedulalloHelyek} egyedülálló üres hely van.");
        }

        static void Feladat7()
        {
            using (var writer = System.IO.File.CreateText(Ki))
            {
                // végigmegyün ka székeken
                for (int i = 0; i < 15; i++)
                {
                    for (int j = 0; j < 20; j++)
                    {
                        // ha a szék foglalt, egy x-et írunk a fájlba
                        if (helyek[i, j] == 'x')
                            writer.Write('x');
                        // különben a kategória számát
                        else
                            writer.Write(kategoriak[i, j]);
                    }
                    writer.WriteLine();
                }
            }
        }

        static void Kiir(int feladat)
        {
            Console.WriteLine($"{feladat}. feladat");
        }
    }
}
