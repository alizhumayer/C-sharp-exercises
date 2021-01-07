using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace varosok
{
    class Program
    {/*2. Olvassa be a varosok.csv állomány sorait és hozzon lére osztálypéldányt (objektumot) minden egyes városhoz!
        Az osztálypéldányokat egy összetett változóban (pl. vektor, lista stb.) tárolja,
        mely használatával a további feladatok megoldhatók! 
        Hozzon létre saját osztályt Város azonosítóval! 
        A város nevének, országának és a lakosok számának a tárolására készítsen megfelelő típusú publikus jellemzőket! 
        Egy város adatait tartalmazza a következő minta szerint: 
        Tokió;Japán;38,001000
        Delhi;India;25,703168
        Shanghai;Kína;23,740778
        A város nevét és országát a város lakossága követi (millió fő). 
        Az adatokat pontosvessző választja el. 
 */
        struct varos
        {
            public string nev;
            public string orszag;
            public double nepesseg;            
        }
        static varos[] adatok = new varos[100];//Az állományban legfeljebb 100 sor lehet. 
        static void Main(string[] args)
        {
            string[] fajlbol = File.ReadAllLines("varosok.csv");
            int sorokszama = 0;//sorok száma a fájlban
            int i,j,k;//ciklusváltozó
            for (k = 1; k < fajlbol.Count(); k++)//Ügyeljen arra, hogy az állomány első sora az adatok fejlécét tartalmazza!
            {
                string[] egysordarabolva = fajlbol[k].Split(';');//Az adatokat pontosvessző választja el.
                adatok[sorokszama].nev = egysordarabolva[0];
                adatok[sorokszama].orszag = egysordarabolva[1];                
                adatok[sorokszama].nepesseg =Convert.ToDouble(egysordarabolva[2]);
                sorokszama++;
            }
            int varosokszama = sorokszama;
           
            //Console.WriteLine("Az adatok listája fájlból");
            
            Console.WriteLine("  név                     ország                            népesség");
            for (i = 0; i < varosokszama; i++)
            {
                Console.WriteLine("{0,-20} {1,-40} {2} ", adatok[i].nev, adatok[i].orszag, adatok[i].nepesseg);
            }
            //3. Határozza meg és írja ki a képernyőre a minta szerint, hogy hány város található az állományban!
            Console.WriteLine("3. feladat: Városok száma: {0} db", varosokszama);
            //4. Határozza meg és írja ki a képernyőre – a minta szerint – az indiai nagyvárosok lakosságának összegét! 
            //összegzés tétele
            double indiaiosszesen = 0;
            for (i = 0; i < varosokszama; i++)
            {
                if (adatok[i].orszag == "India")
                {
                    indiaiosszesen += adatok[i].nepesseg;
                }
            }
            Console.WriteLine("4. feladat: indiai nagyvárosok lakosságának összeg: {0} fő", indiaiosszesen*1000000);
            //5. Határozza meg és írja ki a képernyőre a minta szerint a legnagyobb lakosságú város adatait! 
            //maximum kiválasztás tétele
            double max = adatok[0].nepesseg;//feltételezem, hogy az első adat a legnagyobb
            int maxi = 0;//maximális elem sorszáma
            for (i = 1; i < varosokszama; i++)
            {
                if (adatok[i].nepesseg > max)//ha találok nagyobb értéket
                {
                    max = adatok[i].nepesseg;//az aktuális elem lesz a legnagyobb
                    maxi = i;//megjegyzem a sorszámot is
                }
            }
            Console.WriteLine("5. feladat: A legnagyobb lakosságú város adatai:");
            Console.WriteLine("\tNév: {0}", adatok[maxi].nev);
            Console.WriteLine("\tOrszág: {0}", adatok[maxi].orszag);
            Console.WriteLine("\tLakosság: {0} ezer fő", adatok[maxi].nepesseg*1000);
            //6. Döntse el, hogy az adatok között van-e magyar város! 
            //A keresést ne folytassa, ha a választ meg tudja adni! A képernyőre írást a minta szerint végezze! 
            //keresés tétele
            Boolean van = true;
            i = 0;
            while (i < varosokszama && !adatok[i].orszag.ToLower().Contains("magyarország"))
            {
                i++;
            }
            van = i < varosokszama ? true : false;
            if (van)
            {
                Console.WriteLine("6. feladat: Van Magyarországi város: \n\tNév: {0}\n\tNépesség: {1} ezer fő", adatok[i].nev, adatok[i].nepesseg*1000);
            }

            else
                Console.WriteLine("6. feladat: Nincs magyar város az adatok között ");
            //7. Határozza meg és írja ki a képernyőre a minta szerint azoknak a városoknak a számát, 
            //amelyek nevében pontosan egy szóköz található! 
            //megszámlálás tétele
            int egyszokozszama = 0;
            int egyszokozttartalmaz = 0;
            string varosnev="";
            char szokoz = ' ';
            //Console.Write("Egy szóközt tartalmazó városok: ");
            for (i = 0; i < varosokszama; i++)
            {
                if (adatok[i].nev.Contains(" "))//ha van szóköz a városnévben
                {
                    egyszokozszama = 0;
                    varosnev = adatok[i].nev;
                    for (j=0;j< varosnev.Length; j++)
                    {
                        if(varosnev[j]==szokoz)
                        {
                            egyszokozszama++;
                        }
                    }
                    if (egyszokozszama == 1)
                    {
                        egyszokozttartalmaz++;
                        //Console.Write(" {0},",varosnev);
                    }
                }
            }
            Console.WriteLine("\n7. feladat: Városok egy szóközzel: {0} db",egyszokozttartalmaz);
            //8. Készítsen statisztikát országok szerint a nagyvárosok számáról! 
            //A képernyőre írást a minta szerint végezze! 
            Console.WriteLine("8. feladat: Ország statisztika ");
            //adott egy sorozat, határozzuk meg hány különböző eleme van és gyűjtsük ki egy tömbbe
            int kulonbozoelemekszama = 0;
            string[] orszagok = new string[100];
            int[] orszagszam = new int[100];
            for (i = 0; i < varosokszama; i++)
            {
                j = 0;
                while ((j <= kulonbozoelemekszama) && (adatok[i].orszag != orszagok[j]))
                {
                    j++;
                }
                if (j > kulonbozoelemekszama)
                {
                    kulonbozoelemekszama++;
                    orszagok[kulonbozoelemekszama] = adatok[i].orszag;
                }

            }
            //megszámlálás tétele            
            for (i = 0; i < varosokszama; i++)
            {
                for (k = 1; k <= kulonbozoelemekszama; k++)

                {
                    if (orszagok[k] == adatok[i].orszag) orszagszam[k]++;
                }

            }
            for (i = 1; i <= kulonbozoelemekszama; i++)
                if(orszagszam[i]>1)
                Console.WriteLine("\t{0}: {1} db ", orszagok[i], orszagszam[i]);
            //9. A kina.txt állományba válogassa ki a kínai nagyvárosok adatait! 
            //Az állomány soraiba a város neve és lakossága kerüljenek pontosvesszővel elválasztva a minta szerint! 
            //kiválogatás tétele
            Console.WriteLine("9. feladat: kínai nagyvárosok adatai");
            FileStream fnev = new FileStream("kina.txt", FileMode.Create);
            StreamWriter fajlbairo = new StreamWriter(fnev);
            fajlbairo.WriteLine("város;népesség");
            for (i = 0; i < varosokszama; i++)
            {
                if (adatok[i].orszag.ToLower().Contains("kína"))
                {
                    fajlbairo.Write("{0};", adatok[i].nev);
                    fajlbairo.Write("{0}", adatok[i].nepesseg);
                    Console.Write("\t{0};", adatok[i].nev);
                    Console.WriteLine("\t{0}", adatok[i].nepesseg);
                    fajlbairo.WriteLine("\n");//sortörés
                }
            }
            fajlbairo.Close();
            fnev.Close();



            Console.ReadKey();
        }
    }
}
