using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_inf_16maj_cs
{
    class Program
    {
        // Deklaralasok
        public struct VASARLAS {
            public List<String> termekek;
        };

        public struct TERMEK
        {
            public int First, Last, Count;
        };

        // Fuggvenyek

        static void sfbeolv(String fileName, out List<VASARLAS> lst)
        {
            lst = new List<VASARLAS>();
            String[] temp = File.ReadAllLines(fileName);
            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i].Length > 0)
                {
                    VASARLAS itm = new VASARLAS();
                    itm.termekek = new List<String>();
                    while (temp[i] != "F" || temp[i].Length == 0)
                    {
                        itm.termekek.Add(temp[i]);
                        i++;
                    }
                    lst.Add(itm);
                }
            }
        }

        static void sfkiir(List<VASARLAS> lst)
        {
            Console.WriteLine("VASARLAS:={");
            for (int i = 0; i < lst.Count; i++)
            {
                Console.WriteLine("\tTERMEKEK:={");
                for (int j = 0; j < lst[i].termekek.Count; j++)
                {
                    Console.WriteLine("\t\t\"" + lst[i].termekek[j] + "\"" + (j + 1 == lst[i].termekek.Count ? "" : ","));
                }
                Console.WriteLine("\t}" + (i + 1 == lst.Count ? "" : ","));
            }
            Console.WriteLine("}");
        }

        #region TermekAdatok

        public static int FIRSTBUY(List<VASARLAS> lst, String termeknev)
        {
            for (int i = 0; i < lst.Count; i++)
            {
                for (int j = 0; j < lst[i].termekek.Count; j++)
                {
                    if (lst[i].termekek[j] == termeknev)
                    {
                        return i + 1;
                    }
                }
            }
            return 0;
        }

        public static int LASTBUY(List<VASARLAS> lst, String termeknev)
        {
            for (int i = lst.Count - 1; i > 0; i--)
            {
                for (int j = 0; j < lst[i].termekek.Count; j++)
                {
                    if (lst[i].termekek[j] == termeknev)
                    {
                        return i + 1;
                    }
                }
            }
            return 0;
        }

        public static int COUNTBUY(List<VASARLAS> lst, String termeknev)
        {
            int db = 0, db_temp=0;
            for (int i = 0; i < lst.Count; i++)
            {
                db_temp = 0;
                for (int j = 0; j < lst[i].termekek.Count; j++)
                {
                    if (lst[i].termekek[j] == termeknev)
                    {
                        db_temp++;
                    }
                }
                if (db_temp > 0) db++;
            }
            return db;
        }

        public static TERMEK TermekAdatok(List<VASARLAS> lst, String termeknev)
        {
            TERMEK tmp = new TERMEK();

            tmp.First = FIRSTBUY(lst, termeknev);
            tmp.Last = LASTBUY(lst, termeknev);
            tmp.Count = COUNTBUY(lst, termeknev);

            return tmp;
        }

        #endregion

        #region Fizetendő

        public static int Fizetendo(int darabszam)
        {
            return (darabszam * 400 + 100 + (darabszam >= 2 ? 50 : 0));
        }

        public static int Fizetendo(VASARLAS vas)
        {
            int fizet = 0, darabszam;
            List<String> termek_temp = new List<string>();
            for (int i = 0; i < vas.termekek.Count; i++)
            {
                if(!TermekKiirva(termek_temp, vas.termekek[i]))
                {
                    darabszam = VasarlasDarab(vas, vas.termekek[i]);
                    fizet += Fizetendo(darabszam);
                    termek_temp.Add(vas.termekek[i]);
                }
            }
            return fizet;
        }

        #endregion


        public static int VasarlasDarab(VASARLAS vas, String termeknev)
        {
            int db = 0;
            for (int i = 0; i < vas.termekek.Count; i++)
            {
                if (vas.termekek[i] == termeknev)
                {
                    db++;
                }
            }
            return db;
        }

        public static bool TermekKiirva(List<string> termek_temp, String termeknev)
        {
            for (int i = 0; i < termek_temp.Count; i++)
            {
                if (termek_temp[i]==termeknev)
                {
                    return true;
                }
            }
            return false;
        }

        public static void VasarlasAdatok(List<VASARLAS> lst, int sorszam) {
            VASARLAS vasarlas = lst[sorszam - 1];

            List<String> termek_temp = new List<String>();

            for (int i = 0; i < vasarlas.termekek.Count; i++)
            {
                if(!TermekKiirva(termek_temp, vasarlas.termekek[i]))
                {
                    Console.WriteLine(VasarlasDarab(vasarlas, vasarlas.termekek[i]) + " " + vasarlas.termekek[i]);
                    termek_temp.Add(vasarlas.termekek[i]);
                }
            }
        }

        // Feladatok::
        #region Feladatok
        static void Feladat2(List<VASARLAS> lst)
        {
            Console.WriteLine("2. feladat");

            Console.WriteLine("A fizetések száma: " + lst.Count);

            Console.WriteLine();
        }

        static void Feladat3(List<VASARLAS> lst)
        {
            Console.WriteLine("3. feladat");

            Console.WriteLine("Az első vásárló " + lst[0].termekek.Count + " darab árucikket vásárolt.");

            Console.WriteLine();
        }

        static void Feladat4(out int sorsz, out string cnev, out int darab)
        {
            Console.WriteLine("4. feladat");

            Console.Write("Adja meg egy vásárlás sorszámát! ");
            sorsz = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adja meg egy árucikk nevét! ");
            cnev = Console.ReadLine();
            Console.Write("Adja meg a vásárolt darabszámot! ");
            darab = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine();
        }

        static void Feladat5(List<VASARLAS> lst, String arucikk)
        {
            Console.WriteLine("5. feladat");

            Console.WriteLine("Az első vásárlás sorszáma: " + TermekAdatok(lst, arucikk).First);
            Console.WriteLine("Az utolsó vásárlás sorszáma: " + TermekAdatok(lst, arucikk).Last);
            Console.WriteLine(TermekAdatok(lst, arucikk).Count + " vásárlás során vettek belőle. ");

            Console.WriteLine();
        }

        static void Feladat6(int darab)
        {
            Console.WriteLine("6. feladat");

            Console.WriteLine(darab + " darab vételekor fizetendő: " + Fizetendo(darab));

            Console.WriteLine();
        }

        static void Feladat7(List<VASARLAS> lst, int sorszam)
        {
            Console.WriteLine("7. feladat");

            VasarlasAdatok(lst, sorszam);

            Console.WriteLine();
        }

        static void Feladat8(List<VASARLAS> lst)
        {
            Console.WriteLine("8. feladat");

            List<String> output = new List<String>();

            for (int i = 0; i < lst.Count; i++)
            {
                output.Add((i + 1) + ": " + Fizetendo(lst[i]));
            }

            File.WriteAllLines("osszeg.txt", output);

            Console.WriteLine("Kimeneti fájl létrehozása sikeres");
			
            Console.WriteLine();
        }
        #endregion

        static void Main(string[] args)
        {
            List<VASARLAS> vasarlasok = new List<VASARLAS>();

            sfbeolv("penztar.txt", out vasarlasok);
            //sfkiir(vasarlasok);
            Feladat2(vasarlasok);
            Feladat3(vasarlasok);
            Feladat4(out int sorszam, out String cikknev, out int darabszam);
            Feladat5(vasarlasok, cikknev);
            Feladat6(darabszam);
            Feladat7(vasarlasok, sorszam);
            Feladat8(vasarlasok);
            Console.Read();
        }
    }
}
