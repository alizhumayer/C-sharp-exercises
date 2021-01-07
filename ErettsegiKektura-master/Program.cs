using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace bdc_kektura
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Kektura> lista = new List<Kektura>();
            //beolvasás
            FileStream fs = new FileStream("kektura.csv", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            //első sort beolvassuk - induló magasság
            string sor = sr.ReadLine();
            int kezdoMagassag = Convert.ToInt32(sor);

            while (!sr.EndOfStream)
            {
                sor = sr.ReadLine();
                string[] d = sor.Split(';');
                string kiindulo = d[0];
                string vegpont = d[1];
                double hossz = Convert.ToDouble(d[2]);
                int emelkedes = Convert.ToInt32(d[3]);
                int lejtes = Convert.ToInt32(d[4]);
                string pecset = d[5];
                Kektura k = new Kektura(kiindulo,vegpont,hossz,emelkedes,lejtes,pecset);
                lista.Add(k);
            }

            sr.Close();
            fs.Close();
            Console.WriteLine("Beolvasva!");

            Console.WriteLine("3. feladat");
            Console.WriteLine("Szakaszok száma: " + lista.Count);

            Console.WriteLine("4. feladat");
            double osszHossz = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                //GETTER!!! le tudjuk kérdezni az adatot (private!!)
                osszHossz += lista[i].getHossz;
            }
            Console.WriteLine("A túra teljes hossza: " + osszHossz);

            Console.WriteLine("5. feladat");
            double minHossz = lista[0].getHossz;
            for (int i = 0; i < lista.Count; i++)
            {
                if (minHossz > lista[i].getHossz)
                {
                    minHossz = lista[i].getHossz;
                }
            }
            Console.WriteLine("A legrövidebb szakasz adatai:");
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].getHossz == minHossz)
                {
                    Console.WriteLine("Kezdete: " + lista[i].getKiindulo);
                    Console.WriteLine("Vége: " + lista[i].getVegpont);
                    Console.WriteLine("Kezdete: " + lista[i].getHossz);
                }
            }

            Console.WriteLine("7. feladat");
            Console.WriteLine("Hiányos állomásnevek:");
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].hianyosNev() == true)
                {
                    Console.WriteLine(lista[i].getVegpont);
                }
            }

            Console.WriteLine("8. feladat");
            int aktMagassag = kezdoMagassag + lista[0].getEmelkedes - lista[0].getLejtes;
            int maxMagassag = aktMagassag;
            int maxIndex = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                aktMagassag = kezdoMagassag + lista[i].getEmelkedes - lista[i].getLejtes;
                if (aktMagassag > maxMagassag)
                {
                    maxMagassag = aktMagassag;
                    maxIndex = i;
                }
            }

            Console.WriteLine("A túra legmagasabb pontja:");
            Console.WriteLine(lista[maxIndex].getVegpont);
            Console.WriteLine(maxMagassag);

            //9. feladat
            FileStream fs2 = new FileStream("kektura2.csv", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs2);

            sw.WriteLine(kezdoMagassag);
            for (int i = 0; i < lista.Count; i++)
            {
                sw.Write(lista[i].getKiindulo + ";");
                sw.Write(lista[i].getVegpont);
                if (lista[i].hianyosNev() == true)
                {
                    sw.Write(" pecsetelohely");
                }
                sw.Write(";");
                sw.Write(lista[i].getHossz + ";");
                sw.Write(lista[i].getEmelkedes + ";");
                sw.Write(lista[i].getLejtes + ";");
                sw.Write(lista[i].getPecset + "\n");
            }

            sw.Close();
            fs2.Close();

            Console.ReadKey();

        }
    }
}
