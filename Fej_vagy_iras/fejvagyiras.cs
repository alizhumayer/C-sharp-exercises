using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace fejvagyiras
{
    class Program
    {
        static Random rnd = new Random();
        static double n = 0;
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

        static string Dobas()
        {
            string egydobas = "";
            if (rnd.Next(0, 2) == 0)
                egydobas = "F";
            else
                egydobas = "I";
            return egydobas;
        }

        static void Feladat1()
        {
            Console.WriteLine("1. feladat");
            Console.WriteLine("A pénzfeldobás eredménye: " + Dobas());
        }

        static void Feladat2()
        {
            Console.WriteLine("2. feladat");
            Console.Write("Tippeljen! (F/I)= ");
            string tipp = Console.ReadLine();
            string dobott = Dobas();
            Console.WriteLine("A tipp {0}, a dobás eredménye {1} volt.", tipp, dobott);
            if (tipp == dobott)
                Console.WriteLine("Ön eltalálta.");
            else
                Console.WriteLine("Ön nem taláta el.");
        }

        static void Feladat3()
        {
            Console.WriteLine("3. feladat");
            StreamReader sr = new StreamReader("kiserlet.txt");

            while (sr.Peek() > -1)
            {
                string x = sr.ReadLine();
                n++;
            }
            sr.Close();
            Console.WriteLine("A kísérlet {0} dobásból állt.", n);
        }

        static void Feladat4()
        {
            Console.WriteLine("4. feladat");
            double dbF = 0;
            StreamReader sr = new StreamReader("kiserlet.txt");

            while (sr.Peek() > -1)
            {
                string x = sr.ReadLine();
                if (x == "F") dbF++;
            }
            sr.Close();
            Console.WriteLine("A kísérlet során a fej relatív gyakorisága {0}% volt.", (dbF / n * 100).ToString("F2"));
        }

        static void Feladat5()
        {
            Console.WriteLine("5. feladat");
            double dbFF = 0;
            StreamReader sr = new StreamReader("kiserlet.txt");

            string x = String.Concat(sr.ReadLine(), sr.ReadLine(), sr.ReadLine());
            if (x == "FFI") dbFF++;
            x = String.Concat(" ", x);

            while (sr.Peek() > -1)
            {
                x = String.Concat(x.Substring(1, 3), sr.ReadLine());
                if (x == "IFFI") dbFF++;
            }
            sr.Close();

            if (x.Substring(1, 3) == "IFF") dbFF++;
            Console.WriteLine("A kísérlet során {0} alkalommal dobtak pontosan két fejet egymás után.", dbFF);
        }

        static void Feladat6()
        {
            Console.WriteLine("6. feladat");
            StreamReader sr = new StreamReader("kiserlet.txt");
            int max = 0;
            int maxh = 0;
            int i = 0;
            string x;

            while (sr.Peek() > -1)
            {
                x = sr.ReadLine();
                i++;

                if (x == "F")
                {
                    int db = 1;
                    while (sr.Peek() > -1 && sr.ReadLine() == "F")
                        db++;
                    if (db > max)
                    {
                        max = db;
                        maxh = i;
                    }
                    i = i + db;
                }
            }
            sr.Close();
            Console.WriteLine("A leghosszabb tisztafej sorozat {0} tagból áll, kezdete a(z) {1}. dobás.", max, maxh);
        }

        static void Feladat7()
        {
            int dbs = 1000;
            string[] sor = new string[dbs];
            int dbFFFF = 0;
            int dbFFFI = 0;

            for (int i = 0; i < dbs; i++)
            {
                sor[i] = Dobas() + Dobas() + Dobas() + Dobas();
                if (sor[i] == "FFFF") dbFFFF++;
                if (sor[i] == "FFFI") dbFFFI++;
            }

            StreamWriter sw = new StreamWriter("dobasok.txt");
            sw.WriteLine("FFFF: {0}, FFFI: {1}", dbFFFF, dbFFFI);
            for (int i = 0; i < dbs - 1; i++)
                sw.Write(sor[i] + " ");
            sw.WriteLine(sor[dbs - 1]);
            sw.Close();
        }
    }
}
