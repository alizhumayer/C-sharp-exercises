using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace valogatott
{
    class Program
    {

        /*A magyar labdarúgó-válogatott az 1902-es első pályára lépésétől kezdve sok szép sikert ért el. 
         * Ebben a feladatban a 2016-os Európa-bajnokság végével bezárólag szerepelnek a magyar válogatott mérkőzései. 
1.	Készítsen programot valogatott néven! A mellékelt– tabulátorokkal tagolt,
UTF-8 kódolású – szöveges állományt (merkozes.txt) olvassa be egy olyan adatszerkezetbe, 
melynek segítségével a memóriában tárolhat egyszerre minden adatot! 
Az állomány legfeljebb 1000 adatot tartalmazhat.
Tárolt adatok: 
datum 	A mérkőzés dátuma (dátum) 
varos 	A város, ahol a mérkőzést játszották (szöveg) 
nezoszam 	A mérkőzés nézőszáma (szám) 
ellenfel 	A mérkőzésen a magyar válogatott ellenfele (szöveg) 
lott 	A mérkőzésen a magyar válogatott által lőtt gólok száma (szám) 
kapott 	A mérkőzésen a magyar válogatott által kapott gólok száma (szám) 
Pl.: 	1903.04.05	Budapest	750	Csehország	2	1
*/

        struct merkozesek
        {
            public DateTime datum;
            public string varos;
            public int nezoszam;
            public string ellenfel;
            public int lott;
            public int kapott;
        }
        static merkozesek[] adatok = new merkozesek[1000];

        /*3.	Készítsen logikai értékkel visszatérő függvényt, 
         * amely eldönti, hogy a válogatott megnyerte-e a meccset! 
         * A függvény neve győztünk legyen! Ügyeljen rá, 
         * hogy a függvény minden szükséges paramétert megkapjon!*/
        static bool gyoztunk(int lottgol, int kapottgol)
        {
            if (lottgol > kapottgol)
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
            string[] fajlbol = File.ReadAllLines("merkozes.txt");

            int sorokszama = 0;//sorok száma a fájlban
            int i;//ciklusváltozó
            for (int k = 0; k < fajlbol.Count(); k++)
            {
                string[] egysordarabolva = fajlbol[k].Split('\t');
                adatok[sorokszama].datum =Convert.ToDateTime(egysordarabolva[0]);
                adatok[sorokszama].varos = egysordarabolva[1];
                adatok[sorokszama].nezoszam = Convert.ToInt32(egysordarabolva[2]);
                adatok[sorokszama].ellenfel = egysordarabolva[3];
                adatok[sorokszama].lott = Convert.ToInt32(egysordarabolva[4]);
                adatok[sorokszama].kapott = Convert.ToInt32(egysordarabolva[5]);
                sorokszama++;
            }

            //Console.WriteLine("A mérkőzések listája fájlból");
            int merkozesekszama = sorokszama;
            /*Console.WriteLine("dátum                város         nézőszám                ellenfél     lőtt     kapott ");//adatok kiíratása táblázatosan (nem volt feladat)
            for (i = 0; i < merkozesekszama; i++)
            {
                Console.WriteLine("{0,-15} {1,-20} {2,-10} {3,-20} {4,-10} {5}", adatok[i].datum, adatok[i].varos, adatok[i].nezoszam, adatok[i].ellenfel, adatok[i].lott, adatok[i].kapott);
            }
            Console.WriteLine("1. feladat.\n\tA mérkőzések száma {0} ", merkozesekszama);*/
            /*2.	Jelenítse meg a képernyőn az 500. meccs minden adatát!
2. feladat
Az 500. meccs dátuma: 1902.10.12
Helyszíne: Bécs	
Megnézte 500 fő
Ellenfél: Ausztria	
Végeredmény: 0 - 5
*/

            i = 499;
            Console.WriteLine("2. feladat\nAz 500. meccs dátuma:{0}\nHelyszíne: {1}\nMegnézte {2} fő\nEllenfél {3}\nVégeredmény {4} - {5}", adatok[i].datum, adatok[i].varos, adatok[i].nezoszam, adatok[i].ellenfel, adatok[i].lott, adatok[i].kapott);
            /*4.	Melyik meccsen volt a legtöbb nézője a válogatottnak? 
             * Írja ki a képernyőre a meccs minden adatét és azt, 
             * hogy megnyertük-e a meccset! Lehetőleg használja 
             * a feladat megoldása során a korábban létrehozott győztünk függvényt!
4. feladat
A legnépszerűbb meccset 30000 néző látta
Dátuma: 1902.10.12
Helyszíne: Bécs	
Ellenfél: Ausztria	
Végeredmény: 0 – 5
Sajnos vesztettünk vagy Győztünk!
*/

            int max = adatok[0].nezoszam;
            int maxi = 0;
            for (i = 0; i < merkozesekszama; i++)
            {
                if (adatok[i].nezoszam > max)
                {
                    max = adatok[i].nezoszam;
                    maxi = i;
                }
            }
            Console.WriteLine("4. feladat\nA legnépszerűbb meccset {0} néző látta\nDátuma: {1}\nHelyszíne: {2}\nEllenfél: {3}\nVégeredmény: {4} – {5}", adatok[maxi].nezoszam, adatok[maxi].datum, adatok[maxi].varos, adatok[maxi].ellenfel, adatok[maxi].lott, adatok[maxi].kapott);
//Sajnos vesztettünk vagy Győztünk!");

            if(gyoztunk(adatok[maxi].lott, adatok[maxi].kapott))
            {
                Console.WriteLine("Győztünk");
            }
            else
            {
                Console.WriteLine("Sajnos vesztettünk");
            }

            /*5.	Ausztria általában hasonló játékerőt képviselt, mint a magyar csapat, 
             * mégis előfordult, hogy az eredményben nagy különbség mutatkozott. 
             * Készítsen állományt ausztria.txt néven, amely tartalmazza azokat 
             * a magyar-osztrák mérkőzéseket, amelyeken legalább 5 gól különbséggel nyert valamelyik csapat! 
             * A dátum, a város, a lőtt és a kapott gólok száma jelenjen meg az állományban. 
             * minden meccs külön sorban szerepeljen, az egyes adatokat tabulátorral válassza el egymástól!*/
            int golkulonbseg = 0;
           FileStream fnev = new FileStream("ausztria.txt", FileMode.Create);
            StreamWriter fajlbairo = new StreamWriter(fnev);
            for (i = 0; i < merkozesekszama; i++)
            {
                 golkulonbseg = Math.Abs(adatok[i].lott - adatok[i].kapott);
                if (adatok[i].ellenfel == "Ausztria" && golkulonbseg>=5)
                {
                    fajlbairo.Write("{0}\t", adatok[i].datum);
                    fajlbairo.Write("{0}\t", adatok[i].varos);
                    fajlbairo.Write("{0}\t", adatok[i].lott);
                    fajlbairo.WriteLine("{0}", adatok[i].kapott);                    
                }
            }
            fajlbairo.Close();
            fnev.Close();

            /*6.	Hány alkalommal győzte le a magyar válogatott 
             * Anglia csapatát 1902 óta? Az eredményt jelenítse meg a képernyőn!
             * Lehetőleg használja a feladat megoldása során a korábban létrehozott győztünk függvényt!*/
            int hanyszorgyoztunk = 0;
            for (i = 0; i < merkozesekszama; i++)
            {
                if (adatok[i].ellenfel == "Anglia")
                {
                    if(gyoztunk(adatok[i].lott, adatok[i].kapott))
                    {
                        hanyszorgyoztunk++;
                    }
                }
            }
            Console.WriteLine("6. feladat\nAngliát {0} -szor győztük le",hanyszorgyoztunk);

            /*7.	1953.11.25-én Londonban játszotta legendás 6-3 végeredményű 
             * meccsét válogatottunk Anglia csapata ellen. 
             * Volt-e ennél nagyobb gólkülönbségű győzelmünk az angol válogatott ellen? 
             * Ha igen, akkor mikor és mi lett a végeredmény? Válaszát jelenítse meg a képernyőn!
7. feladat
A 6:3-nál nem volt jobb eredményünk.
vagy
7. feladat
1960-ban 7:1-re győztük le Angliát.
*/

            bool van = false;
            int sorszam = 0;
            i = 0;
            while(i<merkozesekszama && !van)
            {
                if (adatok[i].ellenfel == "Anglia")
                {
                    if (adatok[i].lott > adatok[i].kapott + 3)
                    {
                        van = true;
                        sorszam = i;
                    }
                }
                i++;
            }
            if (van)
            {
                Console.WriteLine("7. feladat\n{0}-ben {1}:{2} -re győztük le Angliát", adatok[sorszam].datum.Year, adatok[sorszam].lott, adatok[sorszam].kapott);
            }
            else
            {
                Console.WriteLine("7. feladat\n6:3 - nál nem volt jobb eredményünk.");
            }

            Console.ReadKey();
        }
    }
}
