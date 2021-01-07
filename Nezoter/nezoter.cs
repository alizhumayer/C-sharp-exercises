using System;
using System.IO;

namespace nezoter
{
    class Program
    {
        static int sorok = 15;
        static int szekek = 20;
        static int kategoriak = 5;
        static string[] foglalt = new string[sorok];
        static string[] arkat = new string[sorok];
        static int[] eladott = new int[kategoriak];
        static int[] arak = new int[] { 5000, 4000, 3000, 2000, 1500 };

        static void Main(string[] args)
        {
            Feladat1();
            Feladat2();
            Feladat3();
            Feladat4();
            Feladat5();
            Feladat6();
            Feladat7();

            Console.ReadKey();
        }

        static void Feladat1()
        {
            Console.WriteLine("1. feladat. Az adatok beolvas�sa");

            StreamReader olvaso = new StreamReader("foglaltsag.txt");
            for (int i = 0; i < sorok; i++)
                foglalt[i] = olvaso.ReadLine();

            olvaso = new StreamReader("kategoria.txt");
            for (int i = 0; i < sorok; i++)
                arkat[i] = olvaso.ReadLine();
            olvaso.Close();
        }

        static void Feladat2()
        {
            Console.Write("2. feladat. A kiv�lasztott sor = ");
            int sor = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.Write("A kiv�lasztott sz�k = ");
            int szek = Convert.ToInt32(Console.ReadLine()) - 1;
            if (foglalt[sor][szek] == 'x')
            {
                Console.WriteLine("A kiv�lasztott hely m�r foglalt.");
            }
            else
            {
                Console.WriteLine("A kiv�lasztott hely m�g szabad.");
            }
        }

        static void Feladat3()
        {
            int db = 0;
            for (int i = 0; i < sorok; i++)
                for (int j = 0; j < szekek; j++)
                    if (foglalt[i][j] == 'x')
                        db++;
            double szazalek = (double) 100 * db / (sorok * szekek);
            Console.WriteLine("3. feladat. Az el�ad�sra eddig {0} jegyet adtak el, ez a n�z�t�r {1}%-a.", db, Math.Round(szazalek));
        }

        static void Feladat4()
        {
            for (int i = 0; i < sorok; i++)
                for (int j = 0; j < szekek; j++)
                    if (foglalt[i][j] == 'x')
                    {
                        int kat = Convert.ToInt32(arkat[i].Substring(j, 1)) - 1;
                        eladott[kat]++;
                    }
            int maxh = 0;
            for (int i = 0; i < kategoriak; i++)
                if (eladott[i] > eladott[maxh])
                    maxh = i;
            Console.WriteLine("4. feladat. A legt�bb jegyet a(z) {0}. �rkateg�ri�ban �rt�kes�tett�k.", maxh + 1);
        }

        static void Feladat5()
        {
            int bevetel = 0;
            for (int i = 0; i < kategoriak; i++)
                bevetel += eladott[i] * arak[i];
            Console.WriteLine("5. feladat. A sz�nh�z jelenlegi bev�tele {0} Ft lenne.", bevetel);
        }

        static void Feladat6()
        {
            int db = 0;
            for (int i = 0; i < sorok; i++)
            {
                if (foglalt[i].Substring(0, 2) == "ox")
                    db++;
                for (int j = 0; j < szekek - 2; j++)
                    if (foglalt[i].Substring(j, 3) == "xox")
                        db++;
                if (foglalt[i].Substring(szekek - 2, 2) == "xo")
                    db++;
            }
            Console.WriteLine("6. feladat. A n�z�t�ren {0} db egyed�l�ll� �res hely van.", db);
        }

        static void Feladat7()
        {
            Console.WriteLine("7. feladat. A szabad.txt f�jl el��ll�t�sa.");
            StreamWriter iro = new StreamWriter("szabad.txt");

            for (int i = 0; i < sorok; i++)
            {
                string egysor = "";
                for (int j = 0; j < szekek; j++)
                {
                    if (foglalt[i][j] == 'o')
                    {
                        egysor += arkat[i][j];
                    }
                    else
                    {
                        egysor += 'x';
                    }
                }
                iro.WriteLine(egysor);
            }
            iro.Close();
        }
    }
}
