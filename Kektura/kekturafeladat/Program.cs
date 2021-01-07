using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kekturafeladat
{
    
    class Program
    {
         struct adatsor
        {
            public string kezdopont;
            public string vegpont;
            public double turahossz;
            public int emelkedes;
            public int lejtes;
            public bool pecset;
            public int magassag;
        }
         static bool HianyosNev(string vpont)
         {
             if (vpont.Contains("pecsetelohely"))
                 return false;
             else
                 return true;
         }
        static void Main(string[] args)
        {
            string[] fajlbol = File.ReadAllLines("kektura.csv");
            adatsor[] adatok = new adatsor[100];
            int vegpontmagassag = Convert.ToInt32(fajlbol[0]);
            Console.WriteLine(vegpontmagassag);
            int tindex = 0;//sorok száma a fájlban
            double szumhossz = 0;//túra teljes hossza
            int min = 0;//legrövidebb szakasz indexe
            int hianyosnevekdb = 0;//hiányos nevű végpontok száma
            int max = 0;//tengerszint feletti legnagyobb magasság
            for (int i = 1; i < fajlbol.Count(); i++)
            {
                string[] egysordarabolva = fajlbol[i].Split(';');
                adatok[tindex].kezdopont = egysordarabolva[0];
                adatok[tindex].vegpont = egysordarabolva[1];
                adatok[tindex].turahossz = Convert.ToDouble(egysordarabolva[2]);
                adatok[tindex].emelkedes = Convert.ToInt32(egysordarabolva[3]);
                adatok[tindex].lejtes = Convert.ToInt32(egysordarabolva[4]);
                if (egysordarabolva[5] == "i") adatok[tindex].pecset = true;
                else adatok[tindex].pecset = false;
                
                //4.feladat
                szumhossz += adatok[tindex].turahossz;
                Console.WriteLine(szumhossz);
                //5. feladat
                if (adatok[min].turahossz > adatok[tindex].turahossz)
                {
                    min = tindex;
                }
                //6. 7. feladat
                if (adatok[tindex].pecset && HianyosNev(adatok[tindex].vegpont))
                    hianyosnevekdb++;
                vegpontmagassag += adatok[tindex].emelkedes - adatok[tindex].lejtes;
                adatok[tindex].magassag = vegpontmagassag;
                if (adatok[max].magassag < adatok[tindex].magassag) max = tindex;
                tindex++;
            }
            //adatok kiíratása
            for (int i = 0; i < fajlbol.Count(); i++)
            {
                Console.Write(adatok[i].kezdopont);
                Console.Write(";");
                Console.Write(adatok[i].vegpont);
                Console.Write(";");
                Console.Write(adatok[i].turahossz);
                Console.Write(";");
                Console.Write(adatok[i].emelkedes);
                Console.Write(";");
                Console.Write(adatok[i].lejtes);
                Console.Write(";");
                Console.WriteLine(adatok[i].pecset);
                Console.Write(";");
                Console.WriteLine(adatok[i].magassag);
            }
           //3. feladat szakaszok száma
            Console.WriteLine("3. feladat: szakaszok száma: {0} db",tindex);
            //4. feladat a túra teljes hossza
            Console.WriteLine("4. feladat: A túra teljes hossza: {0} km",szumhossz);
            //5. feladat legrövidebb szakasz adatai
            Console.WriteLine("5. feladat: legrövidebb szakasz adatai:");
            Console.WriteLine("\tKezdete: {0} ", adatok[min].kezdopont);
            Console.WriteLine("\tVége: {0}",  adatok[min].vegpont);
            Console.WriteLine("\tTávolság: {0} km",  adatok[min].turahossz);
            //Console.WriteLine("\tmin: {0}", min);
            //7. feladat a túra teljes hossza
            Console.WriteLine("7. feladat: Hiányos állomásnevek: ");
            if (hianyosnevekdb == 0) Console.WriteLine("Nincs hiányos állomásnév!");
            else foreach (var elem in adatok)
                {
                    if (elem.pecset && HianyosNev(elem.vegpont))
                    {
                        Console.WriteLine("\t{0}",elem.vegpont);
                    }
                }
            //8. feladat a túra legmagasabban fekvő végpontja
            Console.WriteLine("8. feladat: A túra legmagasabban fekvő végpontja:");
            Console.WriteLine("\tA végpont neve: {0} ", adatok[max].vegpont);
            Console.WriteLine("\tA végpont tengerszint feletti magassága: {0}", adatok[max].magassag);
            //9. feladat kektura2.csv fájl elkészítése
            FileStream fnev = new FileStream("kektura2.csv", FileMode.Create);
            StreamWriter fajlbairo = new StreamWriter(fnev);
            fajlbairo.WriteLine(fajlbol[0]);
            for (int i = 0; i < tindex; i++)
            {
                fajlbairo.Write("{0};", adatok[i].kezdopont);
                if (adatok[i].pecset && HianyosNev(adatok[i].vegpont))                
                    fajlbairo.Write("{0} pecsetelohely;", adatok[i].vegpont);
                    else
                    fajlbairo.Write("{0};", adatok[i].vegpont);
                fajlbairo.Write("{0};", adatok[i].turahossz);
                fajlbairo.Write("{0};", adatok[i].emelkedes);
                fajlbairo.Write("{0};", adatok[i].lejtes);
                fajlbairo.WriteLine(adatok[i].pecset?"i":"n");
            }
            fajlbairo.Close();
            fnev.Close();
                Console.ReadKey();
            
        }
    }
}
