using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20160503
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Állitsunk elő egészeket tartalmazó tömb elemei alapján egy másik tömböt, amely ungyanezen számok négyzeteit tartalmazza (másolás tétel) */

            //int szamokszama = 10;
            //int[] alap = new int[szamokszama];
            //int[] negyzet = new int[szamokszama];
            //int i = 0;
            //Random vsz = new Random();

            //for (i = 0; i < szamokszama; i++)
            //{
            //    alap[i] = vsz.Next(0, 11);
            //    Console.Write("{0, 2},", alap[i]);
            //}
            //Console.WriteLine("");
            //for (i = 0; i < szamokszama; i++)
            //{
            //    alap[i] = Convert.ToInt32(Math.Pow(alap[i], 2));

            //    Console.Write("{0},", alap[i]);
            //}

            //Console.ReadKey();

            /*Állítsunk elő egy tömb elemeit fordított sorrendben*/

            //int szamokszama = 10;
            //int[] alap = new int[szamokszama];
            //int[] fordalap = new int[szamokszama];
            //int i = 0;
            //Random vsz = new Random();

            //for (i = 0; i < szamokszama; i++)
            //{
            //    alap[i] = vsz.Next(0, 11);
            //    Console.Write("{0,3}", alap[i]);

            //}
            //Console.WriteLine("");
            //Console.WriteLine("");
            //for (int j = 9; j >= 0; j--)
            //{
            //    fordalap[9-j] = alap[j];
            //    Console.Write("{0,3}", fordalap[9-j]);
            //}
            //for ( i = 0; i < 10; i++)
            //{
            //    Console.Write("{0,3}",fordalap[i]);
            //}

            //Console.ReadKey();

            /*Hat.meg két + egész legkisebb közös többszörösét*/

            //int a = 0, b = 0;
            //Console.WriteLine("Kérek egy számot:");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Kérek még egy számot:");
            //b = Convert.ToInt32(Console.ReadLine());

            //int a = 0, b = 0, max=0, lkkt=0; //legkissebb közös töbszörös
            //Console.WriteLine("Kérek egy számot:");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Kérek még egy számot:");
            //b = Convert.ToInt32(Console.ReadLine());

            //if(a > b)
            //{
            //    max = a;
            //}
            //else
            //{
            //    max = b;
            //}
            //int j = max;

            //while (!(j % a == 0 && j % b == 0))
            //{
            //    j++;
            //}
            //lkkt = j;
            //Console.Write("A {0} és a {1} legkisebb közös többszöröse: {2}",a,b,lkkt);
            //Console.ReadKey();




            /*Adott egy egészeket tart. tömb, válogassuk ki belőle azokat amelyek az elemekátlagától legfeljebb egyel térnek el*/

            int szamokszama = 10;
            int osszeg = 0;
            double atlag = 0;
            int[] alaptomb = new int[szamokszama];
            int[] kitomb = new int[szamokszama];

            int i = 0;
            Random vsz = new Random();

            for (i = 0; i < szamokszama; i++)
            {
                alaptomb[i] = vsz.Next(0, 11);
                Console.Write("{0, 2},", alaptomb[i]);
            }

            for ( i = 0; i < szamokszama; i++)
            {
                osszeg = osszeg + alaptomb[i];
            }
            atlag = Convert.ToDouble(osszeg) / szamokszama;
            int db = 0;
            for (i = 0; i < szamokszama; i++)
            {
                if (Math.Abs(alaptomb[i]-atlag)<=1)
                {
                    kitomb[db] = alaptomb[i];
                    db++;
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Átlag: {0}",atlag);
            for ( i = 0; i < db; i++)
            {
                Console.Write("{0,3}",kitomb[i]);
            }




            Console.ReadKey();
        }
    }
}
