using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace enaplo
{
    class Program
    {
        static List<EnaploClass> naploLista = new List<EnaploClass>();

        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("enaplo.txt",Encoding.UTF8);
            string sor = ""; //nincs fejléc adatsor
            while (!sr.EndOfStream)
            {
                sor = sr.ReadLine();
                EnaploClass e = new EnaploClass(sor);
                naploLista.Add(e);
            }

            Console.WriteLine("3. feladat");
            Console.WriteLine("Ennyi tanuló van: " + naploLista.Count);

            Console.WriteLine("5. feladat");
            for (int i = 0; i < naploLista.Count; i++)
            {
                Console.WriteLine(naploLista[i].Nev + ": " + naploLista[i].OsszPont);
            }

            Console.WriteLine("6. feladat");
            int osszeg = 0;
            for (int i = 0; i < naploLista.Count; i++)
            {
                osszeg += naploLista[i].OsszPont;
            }
            double atlag = (double)osszeg / naploLista.Count;
            Console.WriteLine("A pontszámok átlaga: " + Math.Round(atlag,2));

            Console.WriteLine("7. feladat");
            int jelesDB = 0;
            for (int i = 0; i < naploLista.Count; i++)
            {
                if (naploLista[i].Otos > 50)
                {
                    jelesDB++;
                }
            }
            Console.WriteLine("50-nél több jelese van: " + jelesDB + " tanuló");

            Console.WriteLine("8.feladat");
            int maxPont = naploLista[0].OsszPont;
            //int maxPont = int.MinValue;
            for (int i = 0; i < naploLista.Count; i++)
            {
                if (naploLista[i].OsszPont > maxPont)
                {
                    maxPont = naploLista[i].OsszPont;
                }
            }
            Console.WriteLine("A legnagyobb pontszám: " + maxPont);
            for (int i = 0; i < naploLista.Count; i++)
            {
                if (naploLista[i].OsszPont == maxPont)
                {
                    Console.WriteLine(naploLista[i].Nev);
                }
            }
            Console.ReadKey();
        }
    }
}
