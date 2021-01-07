using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fuvar
{
    class Program
    {
        struct fuvarozas//Készítsen összetett változót az adatok tárolására!
        {
            public int taxiid;
            public string indulas;
            public int idotartam;
            public double tavolsag;
            public double viteldij;
            public double borravalo;
            public string fizetesmod;
        }
        static fuvarozas[] adatok = new fuvarozas[2000];//Az állományban legfeljebb 2000 sor lehet. 
        struct fuvarozas2//Készítsen összetett változót az adatok tárolására!
        {
            public int taxiid;
            public string indulas;
            public int idotartam;
            public double tavolsag;
            public double viteldij;
            public double borravalo;
            public string fizetesmod;
        }
        static fuvarozas2[] adatok2 = new fuvarozas2[2000]; 
        static void Main(string[] args)
        {
            string[] fajlbol = File.ReadAllLines("fuvar.csv");
            int sorokszama = 0;//sorok száma a fájlban
            int i,j;//ciklusváltozó
            for (int k = 1; k < fajlbol.Count(); k++)//Ügyeljen arra, hogy az állomány első sora az adatok fejlécét tartalmazza!
            {
                string[] egysordarabolva = fajlbol[k].Split(';');//Az adatokat pontosvessző választja el.
                adatok[sorokszama].taxiid = Convert.ToInt32(egysordarabolva[0]);
                adatok[sorokszama].indulas = egysordarabolva[1];               
                adatok[sorokszama].idotartam = Convert.ToInt32(egysordarabolva[2]);
                adatok[sorokszama].tavolsag = Convert.ToDouble(egysordarabolva[3]);
                adatok[sorokszama].viteldij = Convert.ToDouble(egysordarabolva[4]);
                adatok[sorokszama].borravalo = Convert.ToDouble(egysordarabolva[5]);
                adatok[sorokszama].fizetesmod = egysordarabolva[6];
                sorokszama++;
            }
            int fuvarokszama = sorokszama;
            
            /*Console.WriteLine("Az adatok listája fájlból");
            
            Console.WriteLine(" taxi_id   indulas        idotartam    tavolsag    viteldij    borravalo    fizetes_modja");
            for (i = 0; i < fuvarokszama; i++)
            {
                Console.WriteLine("{0,-6} {1,-15} {2,-10} {3,-10} {4,-10} {5,-10} {6} ", adatok[i].taxiid, adatok[i].indulas, adatok[i].idotartam, adatok[i].tavolsag, adatok[i].viteldij, adatok[i].borravalo, adatok[i].fizetesmod);
            }*/

            //3. Hatérozza meg és írja ki a képernyőre a minta szerint, hogy hany utazás került feljegyzésre az áIlományban!

            Console.WriteLine("3. feladat: {0} fuvar", fuvarokszama);
            //4. Határozza meg és írja ki a képernyőre a minta szerint, 
            //hogy a 6185-ös azonosítójú taxisnak mennyi volt a bevétele, 
            //és ez hány fuvarból állt! FeltéteIezheti, hogy van ilyen azonosítójú taxis.
            //összegzés tétele, megszámlálás tétele
            double osszesen = 0;
            int db = 0;
            for (i = 0; i < fuvarokszama; i++)
            {
                if (adatok[i].taxiid == 6185)
                {
                    osszesen += adatok[i].viteldij;
                    db++;
                }
            }
            Console.WriteLine("4. feladat: {0} fuvar alatt: {1} $", db,osszesen);
            /*5. Programjával hatátozza meg az áIlomány adataibő| a fizetési módokat, 
             * majd összesítse, hogy az egyes fizetési módokat hányszot vá|asztották az utak során! 
             * Ezeket az eredményeket a minta szerint írja a képernyőre! 
             * A kiírás során a fizetési módok sorrendje bármilyen lehet.*/
            //adott egy sorozat, határozzuk meg hány különböző eleme van és gyűjtsük ki egy tömbbe
            int kulonbozoelemekszama = 0;
            string[] fizetesimodok = new string[100];
            int[] fizetesszam = new int[100];
            for (i = 0; i < fuvarokszama; i++)
            {
                j = 0;
                while ((j <= kulonbozoelemekszama) && (adatok[i].fizetesmod != fizetesimodok[j]))
                {
                    j++;
                }
                if (j > kulonbozoelemekszama)
                {
                    kulonbozoelemekszama++;
                    fizetesimodok[kulonbozoelemekszama] = adatok[i].fizetesmod;
                }

            }
            //megszámlálás tétele            
            for (i = 0; i < fuvarokszama; i++)
            {
                for (int k = 1; k <= kulonbozoelemekszama; k++)

                {
                    if (fizetesimodok[k] == adatok[i].fizetesmod) fizetesszam[k]++;
                }

            }
            Console.WriteLine("5. feladat:");
            for (i = 1; i <= kulonbozoelemekszama; i++)                
                    Console.WriteLine("\t{0}: {1} fuvar ", fizetesimodok[i], fizetesszam[i]);

            /*6. Határozza meg és írja ki a képernyőre a minta szerint, 
             * hogy osszesen hány km-t tettek meg a taxisok (1 mérfold : 1,6 km)! 
             * Az eredményt két tizedesjegyre kerekítve jelenítse meg a képernyőn!*/
            //összegzés tétele
            double osszesmerfold = 0;
            for (i = 0; i < fuvarokszama; i++)
            {
                osszesmerfold += adatok[i].tavolsag;
            }
            Console.WriteLine("6. feladat: {0} km",Math.Round(osszesmerfold*1.6,2));
            //7.	Határozza meg és írja ki a képernyőre a minta szerint az időben leghosszabb fuvar adatait! 
            //Feltételezheti, hogy nem alakult ki holtverseny.
            //maximumkiválasztás tétele
            int maxfuvar= adatok[0].idotartam;//feltételezem, hogy az első a legnagyobb
            int maxi = 0;//sorszám
            for (i = 0; i < fuvarokszama; i++)
            {
                if (adatok[i].idotartam > maxfuvar)
                {
                    maxfuvar = adatok[i].idotartam;
                    maxi = i;
                }
            }
            Console.WriteLine("7. feladat: Leghosszabb\n\tFuvar hossza: {0} másodperc", adatok[maxi].idotartam);
            Console.WriteLine("\tTaxi azonosító: {0}", adatok[maxi].taxiid);
            Console.WriteLine("\tMegtett távolság: {0} km", adatok[maxi].tavolsag*1.6);
            Console.WriteLine("\tViteldíj: {0} $", adatok[maxi].viteldij);

            /*8.	Hozzon létre hibak.txt néven egy UTF-8 kódolású szöveges állományt, 
             * ami tartalmazza azokat az adatokat, amelyek esetében hiba van az eredeti állományban! 
             * Hibás sornak tekintjük azokat az eseteket, amelyekben az utazás időtartama és a viteldíj egy nullánál nagyobb érték, 
             * de a hozzá tartozó megtett távolság értéke nulla. 
             * A sorok indulási időpont szerint növekvő rendben legyenek az állományban! 
             * A hibak.txt állomány szerkezete egyezzen meg a fuvar.csv állomány szerkezetével!*/
            Console.WriteLine("8. feladat: hibak.txt");
            //hibás adatok kiválogatása
            int idb = 0;
            for (i = 0; i < fuvarokszama; i++)
            {
                if (adatok[i].idotartam>0 && adatok[i].viteldij > 0 && adatok[i].tavolsag == 0)
                {
                    adatok2[idb].taxiid= adatok[i].taxiid;
                    adatok2[idb].indulas= adatok[i].indulas;
                    adatok2[idb].idotartam= adatok[i].idotartam;
                    adatok2[idb].tavolsag= adatok[i].tavolsag;
                    adatok2[idb].viteldij= adatok[i].viteldij;
                    adatok2[idb].borravalo= adatok[i].borravalo;
                    adatok2[idb].fizetesmod= adatok[i].fizetesmod;
                    idb++; 
                }
            }
            int hibakszama = idb;
            //sorbarendezés min kiválasztással  

            int mini = 0;
            string min;
            for (i = 0; i < hibakszama; i++)
            {
                mini = i;
                min = adatok2[i].indulas;
                for (j = i; j < hibakszama; j++)
                {
                    int x = String.Compare(adatok2[j].indulas, min);
                    if (x < 0)
                    {
                        mini = j;
                        min = adatok2[j].indulas;
                    }
                }
                //csere
                var s = adatok2[i];
                adatok2[i] = adatok2[mini];
                adatok2[mini] = s;
            }
            /*Console.WriteLine("hibás adatok sorbarendezve");

            Console.WriteLine(" taxi_id   indulas        idotartam    tavolsag    viteldij    borravalo    fizetes_modja");
            for (i = 0; i < hibakszama; i++)
            {
                Console.WriteLine("{0,-6} {1,-15} {2,-10} {3,-10} {4,-10} {5,-10} {6} ", adatok2[i].taxiid, adatok2[i].indulas, adatok2[i].idotartam, adatok2[i].tavolsag, adatok2[i].viteldij, adatok2[i].borravalo, adatok2[i].fizetesmod);
            }*/
            FileStream fnev = new FileStream("hibak.txt", FileMode.Create);
            StreamWriter fajlbairo = new StreamWriter(fnev);
            fajlbairo.WriteLine("taxi_id;indulas;idotartam;tavolsag;viteldij;borravalo;fizetes_modja");
            for (i = 0; i < hibakszama; i++)
            {                
                    fajlbairo.Write("{0};", adatok2[i].taxiid);
                    fajlbairo.Write("{0};", adatok2[i].indulas);
                    fajlbairo.Write("{0};", adatok2[i].idotartam);
                    fajlbairo.Write("{0};", adatok2[i].tavolsag);
                    fajlbairo.Write("{0};", adatok2[i].viteldij);
                    fajlbairo.Write("{0};", adatok2[i].borravalo);
                    fajlbairo.Write("{0}", adatok2[i].fizetesmod);                  
                    fajlbairo.WriteLine("\n");//sortörés                
            }
            fajlbairo.Close();
            fnev.Close();

            Console.ReadKey();
        }
    }
}
