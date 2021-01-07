using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AutoPiac
{
    class Program
    {
        public struct Auto
        {
            public string rsz;
            public string tipus;
            public int ev;
            public int ar;
        }


        static void Main(string[] args)
        {
            List<Auto> autok = new List<Auto>();
            StreamReader sr = new StreamReader("autopiac.txt",Encoding.UTF8);
            string sor = null;
            while (!sr.EndOfStream)
            {
                sor = sr.ReadLine();
                string[] d = sor.Split(';');
                Auto a = new Auto();
                a.rsz = d[0];
                a.tipus = d[1];
                a.ev = Convert.ToInt32(d[2]);
                a.ar = Convert.ToInt32(d[3]);
                autok.Add(a);
            }

            Console.WriteLine("Ennyi autó van a fájlban: " + autok.Count);

            //az autók összértéke 1. megoldás
            int osszErtek = autok.Sum(a => a.ar);
            Console.WriteLine("Az összérték: " + osszErtek);

            //autók összértéke HAGYOMÁNYOS MEGOLDÁS
            int osszeg = 0;
            for (int i = 0; i < autok.Count; i++)
            {
                osszeg += autok[i].ar;
            }
            Console.WriteLine("Az összérték: " + osszeg);

            //Hány Opel van az autók között
            int opelDB = 0;
            foreach (Auto a in autok)
            {
                if (a.tipus == "Opel")
                {
                    opelDB++;
                }
            }
            Console.WriteLine("Ennyi Opel van: " + opelDB);

            //Mi a legrégebbi autó típusa, évjárata és mennyi az ára?
            int minEv = autok[0].ev;
            int minEvIndex = 0;
            for (int i = 0; i < autok.Count; i++)
            {
                if (autok[i].ev < minEv)
                {
                    minEv = autok[i].ev;
                    minEvIndex = i;
                }
            }
            Console.WriteLine("Legöregebb autó gyártási éve: " + minEv);
            Console.WriteLine("Típusa: " + autok[minEvIndex].tipus);
            Console.WriteLine("Ára: " + autok[minEvIndex].ar);

            int skodaOsszeg = 0;
            int skodaDB = 0;
            foreach (Auto a in autok)
            {
                if (a.tipus == "Skoda")
                {
                    skodaOsszeg += a.ar;
                    skodaDB++;
                }
            }
            Console.WriteLine("Skoda átlagos ár: " + (double)skodaOsszeg/skodaDB);

            Console.ReadKey();
        }
    }
}
