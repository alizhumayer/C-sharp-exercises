using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tanfel
{
    class Program
    {
        struct Egyrovat
        {
            public string tanár;
            public string tantárgy;
            public string osztály;
            public int óraszám;
        }

        static int n = 0;
        static Egyrovat[] rovat = new Egyrovat[1000];
        static string[] tanlist = new string[100];

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

        //Tanárok száma
        static void Feladat7()
        {
            tanlist[0] = rovat[0].tanár;
            int tn = 1;
            bool volt;
            for (int i = 1; i < n; i++)
            {
                volt = false;
                for (int j = 0; j < tn && !volt; j++)
                    volt = (rovat[i].tanár == tanlist[j]);
                if (!volt)
                {
                    tanlist[tn] = rovat[i].tanár;
                    tn++;
                }
            }
            Console.WriteLine("7. feladat\nAz iskolában {0} tanár tanít.", tn);
        }

        //Bekérünk egy osztályt és egy tantárgyat, és kiírjuk, hogy csoportbontott-e
        static void Feladat6()
        {
            Console.WriteLine("6. feladat");
            Console.Write("Osztály= ");
            string oszt = Console.ReadLine();
            Console.Write("Tantárgy= ");
            string tant = Console.ReadLine();
            int db = 0;
            for (int i = 0; i < n; i++)
                if (rovat[i].osztály == oszt && rovat[i].tantárgy == tant)
                    db++;
            if (db > 1)
                Console.WriteLine("Csoportbontásban tanulják.");
            else
                Console.WriteLine("Osztályszinten tanulják.");
        }

        //Az osztályfőnökök listája
        static void Feladat5()
        {
            StreamWriter sw = new StreamWriter("of.txt");
            for (int i = 0; i < n; i++)
                if (rovat[i].tantárgy == "osztalyfonoki")
                    sw.WriteLine(rovat[i].osztály + " - " + rovat[i].tanár);
            sw.Close();
        }

        //Adott tanár heti összóraszáma
        static void Feladat4()
        {
            Console.Write("4. feladat\nEgy tanár neve= ");
            string tannév = Console.ReadLine();
            int s = 0;
            for (int i = 0; i < n; i++)
                if (rovat[i].tanár == tannév)
                    s += rovat[i].óraszám;
            Console.WriteLine("A tanár heti óraszáma: {0}.", s);
        }

        //Heti összóraszám
        static void Feladat3()
        {
            int s = 0;
            for (int i = 0; i < n; i++)
                s += rovat[i].óraszám;
            Console.WriteLine("3. feladat\nAz iskolában a heti összóraszám: {0}.", s);
        }

        //Hány bejegyzés van a fájlban
        static void Feladat2()
        {
            Console.WriteLine("2. feladat\nA fájlban {0} bejegyzés van.", n);
        }

        //Beolvasás
        static void Feladat1()
        {
            StreamReader sr = new StreamReader("beosztas.txt");
            string[] egysor = new string[5];

            while (sr.Peek() > -1)
            {
                rovat[n].tanár = sr.ReadLine();
                rovat[n].tantárgy = sr.ReadLine();
                rovat[n].osztály = sr.ReadLine();
                rovat[n].óraszám = Convert.ToInt32(sr.ReadLine());
                n++;
            }
        }
    }
}
