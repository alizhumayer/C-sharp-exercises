using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stadionokeuropa
{
    class Program
    {
        struct stadionok
        {
            public int sorszam;
            public string nev;
            public double nezoszam;
            public string varos;
            public int epult;
        }
        /* Létrehozzuk a 2000 elemből álló tömböt amely elemei stadionok típusú összetett adatszerkezet */
        static stadionok[] stadion = new stadionok[2000];
        static void Main(string[] args)
        {
            string[] fajlbol = File.ReadAllLines("stadionok.txt");

            int sorokszama = 0;//sorok száma a fájlban
            int i;//ciklusváltozó

            for (int k = 0; k < fajlbol.Count(); k++)
            {

                string[] egysordarabolva = fajlbol[k].Split(';');
                stadion[sorokszama].sorszam = Convert.ToInt32(egysordarabolva[0]);
                stadion[sorokszama].nev = egysordarabolva[1];
                stadion[sorokszama].nezoszam = Convert.ToDouble(egysordarabolva[2]);
                stadion[sorokszama].varos = egysordarabolva[3];
                stadion[sorokszama].epult = Convert.ToInt32(egysordarabolva[4]);
                sorokszama++;
            }

            Console.WriteLine("A stadionek listája fájlból");
            int stadionszama = sorokszama;

            //Console.SetCursorPosition(20, 5);//oszlop,sor koordináta megadása
            Console.WriteLine("sorszám   név                           nézőszám    város               épült");

            for (i = 0; i < stadionszama; i++)
            {
                Console.SetCursorPosition(0, 2 + i);
                Console.Write(" {0}", stadion[i].sorszam);
                Console.SetCursorPosition(5, 2 + i);
                Console.Write(" {0}", stadion[i].nev);
                Console.SetCursorPosition(45, 2 + i);
                Console.Write(" {0}", stadion[i].nezoszam);
                Console.SetCursorPosition(55, 2 + i);
                Console.Write(" {0}", stadion[i].varos);
                Console.SetCursorPosition(85, 2 + i);
                Console.Write(" {0}", stadion[i].epult);
                
                
            }
            //legnagyobb befogadóképességű stadion
            double max = stadion[0].nezoszam;
            int maxi = 0;
            for (i = 1; i < stadionszama; i++)
            {
                if ((stadion[i].nezoszam) > max)
                {
                    max = stadion[i].nezoszam;
                    maxi = i;
                }
            }

            Console.WriteLine("\nA legnagyobb befogadóképességű stadion");
            Console.WriteLine("sorszám   név       nézőszám            város      épült");


            Console.WriteLine(" {0}       {1}       {2}       {3}       {4}      ", stadion[maxi].sorszam, stadion[maxi].nev, stadion[maxi].nezoszam, stadion[maxi].varos, stadion[maxi].epult);
            string stadionnev = "";
            Console.WriteLine("kérem a stadion nevét: ");
            stadionnev = Console.ReadLine();
            i = 0;
            bool van = true;
            while ((i < stadionszama) && (stadion[i].nev != stadionnev)) { i++; }
            van = (i < stadionszama) ? true : false;
            int sorszam = i;
            if (van)
            {
                Console.WriteLine("\nA keresett stadion adatai");
                Console.WriteLine("sorszám   név       nézőszám            város      épült");

                Console.WriteLine(" {0}       {1}       {2}       {3}       {4}      ", stadion[sorszam].sorszam, stadion[sorszam].nev, stadion[sorszam].nezoszam, stadion[sorszam].varos, stadion[sorszam].epult);
            }
            else
                Console.WriteLine("A keresett stadion: {0} nem található", stadionnev);

            //Londoni és Budapesti stadionok listája átlagéletkora
            double london = 0, budapest = 0;
            int londondb = 0, budapestdb = 0;
            Console.WriteLine("Londoni és Budapesti stadionok listája");
            Console.WriteLine("sorszám   név       nézőszám            város      épült");
            for (i = 0; i < stadionszama; i++)
            {
                if (stadion[i].varos == "London") 
                {
                    london +=2018- stadion[i].epult;
                    londondb++;
                    Console.WriteLine(" {0}       {1}       {2}       {3}       {4}      ", stadion[i].sorszam, stadion[i].nev, stadion[i].nezoszam, stadion[i].varos, stadion[i].epult);
                 }
                if (stadion[i].varos == "Budapest")
                {
                    budapest += 2018 - stadion[i].epult;
                    budapestdb++;
                    Console.WriteLine(" {0}       {1}       {2}       {3}       {4}      ", stadion[i].sorszam, stadion[i].nev, stadion[i].nezoszam, stadion[i].varos, stadion[i].epult);
                }
            }
            Console.WriteLine("Londoni stadionok átlagéletkora= {0}",london/londondb);
            Console.WriteLine("Budapesti stadionok átlagéletkora= {0}", budapest / budapestdb);
            /* Megállítjuk a programot, egy bill. lenyomásig */
            Console.ReadKey();
        }
    }
}
