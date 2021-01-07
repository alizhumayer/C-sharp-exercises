using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teli_olimpia
{
    class Program
    {
        struct olimpiak
        {
            public int ev;
            public string helyszin;
            public string sportag;
            public string versenyszam;
            public int helyezes;
            public string versenyzok;
        }
        static olimpiak[] adatok = new olimpiak[100];
        // 6. feladat saját függvény egész értékkel tér vissza
        //egy adott téli olimpián hány pontszerző helyezést értek el a magyar versenyzők
        static int Olimpia(int evszam)           
        {
            int db = 0;//pontszerző helyek száma
            for (int i = 0; i < adatok.Length; i++)
            {
                if (adatok[i].ev == evszam)
                {
                    db++;
                }
            }
            return db;
        }
        static void Main(string[] args)
        {
            string[] fajlbol = File.ReadAllLines("teli.csv", Encoding.Default);//beolvasás fájlból
            int sorokszama = 0;
            int i;
            int pontszerzohelyekszama = 0;
            //adatok beolvasása
            for(int k = 0; k < fajlbol.Count(); k++)
            {
                string[] egysordarabolva = fajlbol[k].Split(';');
                adatok[sorokszama].ev = Convert.ToInt32(egysordarabolva[0]);
                adatok[sorokszama].helyszin = egysordarabolva[1];
                adatok[sorokszama].sportag = egysordarabolva[2];
                adatok[sorokszama].versenyszam = egysordarabolva[3];
                adatok[sorokszama].helyezes = Convert.ToInt32(egysordarabolva[4]);
                adatok[sorokszama].versenyzok = egysordarabolva[5];
                sorokszama++;
            }
            //3. feladat megszámlálás tétele
            //összesen hány pontszerző helyünk volt eddigi téli olimpiákon
            for (i = 0; i < sorokszama; i++)
            {
                if (adatok[i].helyezes <= 6) pontszerzohelyekszama++;
            }
            Console.WriteLine("3. feladat");
            Console.WriteLine("A téli olimpiákon eddig {0} pontszerző helyezésünk volt",pontszerzohelyekszama);

            //4. feladat
            //Regőczy Krisztina, Sallay András kettős 1980-ban Lake Placidben
            //milyen érmet szereztek, melyik sportág, mely ver-senyszámában!
            i = 0;
            string erem="";

            while((i<sorokszama)&&(adatok[i].ev!=1980)&&(adatok[i].helyszin!="Lake Placid"))
            {
                i++;
            }
            switch (adatok[i].helyezes)
            {
                case 1: erem = "arany";break;
                case 2: erem = "ezüst"; break;
                case 3: erem = "bronz"; break;
            }
            
            Console.WriteLine("4. feladat");
            Console.WriteLine("Regőczy Krisztina, Sallay András dobogós helyezése:");
            Console.WriteLine("{0} érem {1} {2}",erem, adatok[i].ev, adatok[i].helyszin);
            Console.WriteLine("{0}, {1}", adatok[i].sportag, adatok[i].versenyszam);
            //5. feladat
            //a téli olimpiákon Magyarország hány olimpiai pontot szerzett összesen
            int olimpiaipont = 0;
            for (i = 0; i < sorokszama; i++)
            {
                if (adatok[i].helyezes == 1) { olimpiaipont += 7; }
                else { olimpiaipont += 7- adatok[i].helyezes; }
                
            }
            Console.WriteLine("5. feladat");
            Console.WriteLine("Olimpiai pontok száma: {0}", olimpiaipont);

            //7. feladat
            //Kérje be a program egy adott téli olimpia évét
            //kik hányadik helyezést értek el az adott olimpián
            Console.Write("7. feladat: Adja meg az olimpia évét: "); 
            int olimpiaev = Convert.ToInt16(Console.ReadLine());
            if (Olimpia(olimpiaev) == 0)//Ha az adott évben nem volt pontszerzőnk
            {
                Console.WriteLine("\tNem volt pontszerző helyezésünk.");
            }
            else
            {
                for ( i = 0; i < adatok.Length; i++)
                {
                    if (adatok[i].ev == olimpiaev)//kiválogatás tétele
                    {
                        Console.WriteLine("\t{0}. helyezés\t{1}", adatok[i].helyezes, adatok[i].versenyzok);
                    }
                }
            }

            //8. feladat
            //Gyűjtse ki egy teli_ermesek.txt szöveges állományba a téli olimpiák érmes helyezéseit
            FileStream fnev = new FileStream("teli_ermesek.txt", FileMode.Create);
            StreamWriter fajlbairo = new StreamWriter(fnev);
           
            for ( i = 0; i < sorokszama; i++)
            {
                if (adatok[i].helyezes < 4)
                {
                    fajlbairo.WriteLine("{0}\t{1}\t{2}", adatok[i].helyezes, adatok[i].versenyzok, adatok[i].ev);
                }                   
            }
            fajlbairo.Close();
            fnev.Close();

            Console.ReadKey();

        }
    }
}
