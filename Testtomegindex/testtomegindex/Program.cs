using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testtomegindex
{
    class Program
    {
        struct tanulok
        {
            
            public string nev;
            public double magassag;
            public double testsuly;
        }
        /* Létrehozzuk a 2000 elemből álló tömböt amely elemei tanulok típusú összetett adatszerkezet */
        static tanulok[] tanulo = new tanulok[2000];
        static void Main(string[] args)
        {
            string[] fajlbol = File.ReadAllLines("nev_magassag_testsuly.csv");

            int sorokszama = 0;//sorok száma a fájlban
            int i;//ciklusváltozó

            for (int k = 0; k < fajlbol.Count(); k++)
            {

                string[] egysordarabolva = fajlbol[k].Split(';');
                tanulo[sorokszama].nev = egysordarabolva[0];
                tanulo[sorokszama].magassag = Convert.ToDouble(egysordarabolva[1]);
                tanulo[sorokszama].testsuly = Convert.ToDouble(egysordarabolva[2]);
                sorokszama++;
            }
            Console.WriteLine("A tanulok listája fájlból");
            int tanulokszama = sorokszama;
            double tti;

            Console.WriteLine("név            magasság(cm)    testsúly(kg)      TTI           jellemzés");
            /*TTI=testtömeg/(magasság*magasság)   a magasságot méterben kell megadni
            30 és felette: elhízás
            [25-30[: túlsúly
            [18-25[: normális
            18 alatt: kóros soványság*/
                        for (i = 0; i < tanulokszama; i++)
                        {
                            Console.SetCursorPosition(0, 2 + i);
                            Console.Write(" {0}", tanulo[i].nev);
                            Console.SetCursorPosition(25, 2 + i);
                            Console.Write(" {0}", tanulo[i].magassag);
                            Console.SetCursorPosition(35, 2 + i);
                            Console.Write(" {0}", tanulo[i].testsuly);
                            tti = tanulo[i].testsuly / (tanulo[i].magassag/100 * tanulo[i].magassag/100);
                            Console.SetCursorPosition(45, 2 + i);
                            Console.Write(" {0}", tti);
                            Console.SetCursorPosition(65, 2 + i);
                            if (tti >= 30) Console.Write(" elhízás");
                            if ((tti >= 25) && (tti < 30)) Console.Write(" túlsúly");
                            if ((tti >= 18) && (tti < 25)) Console.Write(" normális");
                            if (tti < 18) Console.Write(" kóros soványság");
                        }
           
                        //legmagasabb tanuló
                        double max = tanulo[0].magassag;
                        int maxi = 0;
                        for (i = 0; i < tanulokszama; i++)
                        {
                            if (tanulo[i].magassag > max)
                            {
                                max = tanulo[i].magassag;
                                maxi = i;
                            }
                        }
                        Console.WriteLine("\nLegmagasabb tanuló");
                        Console.WriteLine("név            magasság(cm)    testsúly(kg)");
                        Console.WriteLine(" {0}           {1}             {2}", tanulo[maxi].nev, tanulo[maxi].magassag, tanulo[maxi].testsuly);

          
            

                            /* Megállítjuk a programot, egy bill. lenyomásig */
                Console.ReadKey();

        }
    }
}
