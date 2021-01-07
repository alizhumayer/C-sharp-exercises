using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helsinki1952
{
    class Program
    {
        //adatszerkezet létrehozása
        struct adatsor
        {
            public int helyezes;
            public int sportolokszama;
            public string sportag;
            public string versenyszam;
        }
        static adatsor[] adatok = new adatsor[200];//maximum 200 adatot tartalmazhat az adatok
        static void Main(string[] args)
        {
            string[] fajlbol = File.ReadAllLines("helsinki.txt");//adatok beolvasása fájlból

            int tindex = 0;//sorok száma a fájlban
            //adatok tárolása a struktúrában
            for (int i = 0; i < fajlbol.Count(); i++)
            {
                string[] egysordarabolva = fajlbol[i].Split(' ');
                adatok[tindex].helyezes = Convert.ToInt32(egysordarabolva[0]);
                adatok[tindex].sportolokszama = Convert.ToInt32(egysordarabolva[1]);
                adatok[tindex].sportag = egysordarabolva[2];
                adatok[tindex].versenyszam = egysordarabolva[3];
                tindex++;
            }
            //Határozza meg és írja ki a képernyőre a minta szerint, 
            //hogy hány pontszerző helyezést értek el a magyar olimpikonok!
            int pontszerzohelyezesekszama = 0;
            for (int i = 0; i < tindex; i++)
            {
                if (adatok[i].helyezes <= 6)
                {
                    pontszerzohelyezesekszama++;
                }
            }
            Console.WriteLine("3. feladat:\nPontszerző helyezések száma: {0}", pontszerzohelyezesekszama);

            //Készítsen statisztikát a megszerzett érmek számáról,
            //majd összesítse az érmek számát a minta szerint!
                        int[] ermek = new int[3];
            for (int i = 0; i < 2; i++)
            {
                ermek[i] = 0;
            }
                int osszeserem = 0;
            for (int i = 0; i < tindex; i++)
            {
                if (adatok[i].helyezes < 4)
                {
                    ermek[adatok[i].helyezes-1]++;
                    osszeserem++;
                }
            }
            Console.WriteLine("4. feladat:");
            Console.WriteLine("Arany: {0}", ermek[0]);
            Console.WriteLine("Ezüst: {0}", ermek[1]);
            Console.WriteLine("Bronz: {0}", ermek[2]);
            Console.WriteLine("Összesen: {0}",osszeserem);

            //Határozza meg és írja ki a minta
            //szerint az elért olimpiai pontok összegét
            int olimpiaipontok = 0;
            for (int i = 0; i < tindex; i++)
            {
                if (adatok[i].helyezes <= 6)
                {
                    if (adatok[i].helyezes == 1) olimpiaipontok += 7;
                    else olimpiaipontok += 7- adatok[i].helyezes;
                }
            }
                Console.WriteLine("5. feladat:");
            Console.WriteLine("Olimpiai pontok száma: {0}", olimpiaipontok);

            //Határozza meg és írja ki a minta szerint, hogy az 1952-es nyári olimpián melyik
            //sportágban szereztek több érmet a sportolók!Ha az érmek száma egyenlő, 
            //akkor az „Egyenlő volt az érmek száma” felirat jelenjen meg!
            int eremdbuszas = 0;
            int eremdbtorna = 0;
            for (int i = 0; i < tindex; i++)
            {
                if (adatok[i].helyezes <= 3 && adatok[i].sportag == "uszas") eremdbuszas++;
                if (adatok[i].helyezes <= 3 && adatok[i].sportag == "torna") eremdbtorna++;
            }
            Console.WriteLine("6. feladat:");
            if (eremdbuszas == eremdbtorna) Console.WriteLine("Egyenlő volt az érmek száma");
            else if (eremdbtorna > eremdbuszas) Console.WriteLine("Torna sportágban szereztek több érmet");
            else Console.WriteLine("Úszás sportágban szereztek több érmet");

            //A helsinki.txt állományba hibásan, egybeírva „kajakkenu” került a kajak-kenu
            //sportág neve. Készítsen szöveges állományt helsinki2.txt néven, amelybe helyesen,
            //kötőjellel kerül a sportág neve!Az új állomány tartalmazzon minden helyezést a
            //forrásállományból, a sportágak neve elé kerüljön be a megszerzett olimpiai pont is a minta szerint!
            //A sorokban az adatokat szóközzel válassza el egymástól!

            //fájlbaírás
            FileStream fnev = new FileStream("helsinki2.txt", FileMode.Create);
            StreamWriter fajlbairo = new StreamWriter(fnev);


            for (int i = 0; i < tindex; i++)
            {
                
                    fajlbairo.Write("{0} ", adatok[i].helyezes);
                fajlbairo.Write("{0} ", adatok[i].sportolokszama);
                if(adatok[i].helyezes==1) fajlbairo.Write("7 ");
                else fajlbairo.Write("{0} ", 7-adatok[i].helyezes);
                if (adatok[i].sportag == "kajakkenu") fajlbairo.Write("kajak-kenu ");      
                else fajlbairo.Write("{0} ", adatok[i].sportag);               
                fajlbairo.Write("{0} ", adatok[i].versenyszam);
                fajlbairo.WriteLine("\n");//sortörés
                
            }
            fajlbairo.Close();
            fnev.Close();

            //Határozza meg, hogy melyik pontszerző helyezéshez fűződik a legtöbb sportoló! 
            //Írja ki a minta szerint a helyezést, a sportágat, a versenyszámot és a sportolók számát!
            //Feltételezheti, hogy nem alakult ki holtverseny.
            int maxi = 0;
            for (int i = 1; i < tindex; i++)
            {
                if (adatok[i].sportolokszama > adatok[maxi].sportolokszama) maxi = i;
            }
            Console.WriteLine("8. feladat:");
            Console.WriteLine("Helyezés: {0}", adatok[maxi].helyezes);
            Console.WriteLine("Sportág: {0}", adatok[maxi].sportag);
            Console.WriteLine("Versenyszám: {0}", adatok[maxi].versenyszam);
            Console.WriteLine("Sportolók száma: {0}", adatok[maxi].sportolokszama);
            Console.ReadKey();
        }
    }
}
