using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rekordlista
{
    class Program
    {

        /*A horgászat a XV. század óta igazi sportággá nőtte ki magát, 
         * és mint minden sportágban, itt is nagy jelentősége van a rekordoknak. 
         * A Rekordlista, mint a Magyar Horgász egyik legnépszerűbb, értékteremtő rovata 
         * 1966 óta regisztrálja és közli a bejelentett rekordhalakat. 
A rekordok.txt állományban ennek a listának a 2019. március 15-ei állapota található.   
Az állomány minden sora egy horgász rekord adatait tartalmazza tabulátorral elválasztva.
Pl.: 
Minkó Lajos	2017. augusztus 24. 23:30	Törpeharcsa	0,6	25	Balaton (14-002-1-1) | Siófok	-
Az egy sorban tárolt adatok rendre: 
•	A horgász neve. Pl:  Minkó Lajos
•	A fogás pontos időpontja. Pl.: 2017. augusztus 24. 23:30
•	A hal faja. Pl: Törpeharcsa
•	A hal súlya kg-ban. Pl.: 0,6
•	A hal hossza cm-ben. Pl.: 25
	Amennyiben nem ismert az adat, az állományban hosszként 0 szerepel.
•	A fogás helyszíne. Pl.: Balaton (14-002-1-1) | Siófok
•	Visszaengedte-e a horgász a halat?
	Kötőjel (-) amennyiben nem engedte vissza.
	C&R amennyiben visszaengedte. (Catch and Release)
*/

        struct rekordok
        {
            public string nev;
            public DateTime idopont;
            public string faj;
            public double suly;
            public int hossz;
            public string helyszin;
            public string visszaengedte;
        }
        static rekordok[] adatok = new rekordok[100];
        static void Main(string[] args)
        {
            /*3.	Olvassa be a forrásállomány tartalmát és tárolja el úgy, 
             * hogy további feladatok megoldására alkalmasak legyenek! 
             * Írja ki a képernyőre, hogy hány rekord adatait tartalmazza az állomány!
1. feladat: A legjobb 32 fogás adatai.  
*/

            string[] fajlbol = File.ReadAllLines("rekordok.txt");

            int sorokszama = 0;//sorok száma a fájlban
            int i,j,k;//ciklusváltozó
            for ( k = 0; k < fajlbol.Count(); k++)
            {
                string[] egysordarabolva = fajlbol[k].Split('\t');
                adatok[sorokszama].nev = egysordarabolva[0];
                adatok[sorokszama].idopont = Convert.ToDateTime(egysordarabolva[1]);
                adatok[sorokszama].faj = egysordarabolva[2];
                adatok[sorokszama].suly = Convert.ToDouble(egysordarabolva[3]);
                adatok[sorokszama].hossz = Convert.ToInt32(egysordarabolva[4]);
                adatok[sorokszama].helyszin = egysordarabolva[5];
                adatok[sorokszama].visszaengedte = egysordarabolva[6];
                sorokszama++;
            }

            Console.WriteLine("Az rekordlista fájlból");
            int adatokszama = sorokszama;
            Console.WriteLine("név                                      időpont                      faj      suly       hossz       helyszin      visszaengedte ");//adatok kiíratása táblázatosan 
            for (i = 0; i < adatokszama; i++)
            {
                Console.WriteLine("{0,-40} {1,-25} {2,-15} {3,-10} {4,-10} {5,-45} {6}", adatok[i].nev, adatok[i].idopont, adatok[i].faj, adatok[i].suly, adatok[i].hossz, adatok[i].helyszin, adatok[i].visszaengedte);
            }
            Console.WriteLine("1. feladat.\n\tA legjobb {0} fogás adatai.", adatokszama);
            /*4.	Hozza létre a balaton.txt állományt! 
             * Az állományba írja ki a balatoni rekordok adatait! 
             * A listában a horgász neve, a hal fajtája és a fogás dátuma szerepeljen! 
             * Amennyiben nem volt balatoni rekord, a Nincs balatoni rekord felirat jelenjen meg az állományban!
blaton.txt tartalma: 
Minkó Lajos, 2018. augusztus 4-én: Afrikai harcsa
Kiss Péter, 2016. február 27.-én: Süllő
Minkó Lajos, 2017. augusztus 24-én: Törpeharcsa 
*/

            bool van = false;
            FileStream fnev = new FileStream("balaton.txt", FileMode.Create);
            StreamWriter fajlbairo = new StreamWriter(fnev);
            for (i = 0; i < adatokszama; i++)
            {
                if (adatok[i].helyszin.Contains("Balaton"))
                {
                    van = true;
                    fajlbairo.Write("{0},", adatok[i].nev);
                    fajlbairo.Write("{0}-én:", adatok[i].idopont);
                    fajlbairo.WriteLine("{0}", adatok[i].faj);                   
                }
            }
            
            if (!van)
            {
                fajlbairo.WriteLine("Nincs balatoni rekord");
            }
            fajlbairo.Close();
            fnev.Close();

            /*5.	Az év hala 2018-ban a balin volt. 
             * Volt-e olyan rekord, melyben balint fogtak és visszaengedték? 
             * Ha igen, jelenítse meg a horgász nevét, a hal súlyát és a fogás helyét!
             * Amennyiben nem volt ilyen hal, akkor a Nincs a rekordlistában visszaengedett balin felirat jelenjen meg a képernyőn!
3. feladat:
Balogh Péter fogott 6 kg-os balint. 
Helyszín: Búzásvölgyi-víztározó (10-023-1-5) | Recsk 
*/


            van = false;
            int sorszam = 0;
            i = 0;
            while(i<adatokszama && !van)
            {
                if(adatok[i].faj=="Balin" && adatok[i].visszaengedte == "C&R")
                {
                    van = true;
                    sorszam = i;
                }
                i++;
            }
            if (van)
            {
                Console.WriteLine("3. feladat:\n{0} fogott {1} kg - os balint.\nHelyszín: {2}", adatok[sorszam].nev, adatok[sorszam].suly, adatok[sorszam].helyszin);
            }
            else
            {
                Console.WriteLine("3. feladat:\n Nincs a rekordlistában visszaengedett balin");
            }

            /*6.	Mekkora a rekordként bejegyzett halak átlagos hossza? 
             * A számításnál ne vegye figyelembe azokat a rekordokat, 
             * melyeknél nem ismert ez az adat! Az eredményt 3 tizedes pontosággal írja ki a képernyőre!
4. feladat:
A bejegyzett halak átlagos hossza 76,036 cm. 
*/

            double atlag = 0;
            int db = 0;
            for (i = 0; i < adatokszama; i++)
            {
                if (adatok[i].hossz != 0)
                {
                    atlag += adatok[i].hossz;
                    db++;
                }
            }
            Console.WriteLine("4. feladat:\nA bejegyzett halak átlagos hossza {0} cm. ",Math.Round(atlag/db,3));


            /*7.	Jelenítse meg a legnagyobb súlyú hal fogásának minden adatát a minta szerint! 
5. feladat:
A legnagyobb súlyú halat fogta: Surányi Péter
A hal faja: Harcsa
Súlya: 70 kg
Hossza: 186 cm
Fogás helye: Adácsi-tó (10-004-1-4) | Adács
Nem engedte vissza.
*/

            double max = adatok[0].suly;
            int maxi = 0;
            for (i = 0; i < adatokszama; i++)
            {
                if (adatok[i].suly > max)
                {
                    max = adatok[i].suly;
                    maxi = i;
                }
            }
            Console.WriteLine("5. feladat:\nA legnagyobb súlyú halat fogta: {0}\nA hal faja: {1}\nSúlya: {2} kg\nHossza: {3} cm\nFogás helye: {4}", adatok[maxi].nev, adatok[maxi].faj, adatok[maxi].suly, adatok[maxi].hossz, adatok[maxi].helyszin);
            if (adatok[maxi].visszaengedte == "-") Console.WriteLine(" Nem engedte vissza.");
            else Console.WriteLine(" Visszaengedte.");

            /*8.	Hány rekord született az egyes években? 
             * Készítsen róla statisztikát és az eredményt jelenítse meg a képernyőn! 
6. feladat:
2016	21 rekord
2018	3 rekord
2017	7 rekord
2015	1 rekord 
*/

            int kulonbozoelemekszama = 0;
            int[] evek = new int[100];
            int[] rekorddb = new int[100];
            for (i = 0; i < adatokszama; i++)
            {
                j = 0;
                while ((j <= kulonbozoelemekszama) && (adatok[i].idopont.Year != evek[j]))
                {
                    j++;
                }
                if (j > kulonbozoelemekszama)
                {
                    kulonbozoelemekszama++;
                    evek[kulonbozoelemekszama] = adatok[i].idopont.Year;
                }
            }
            //megszámlálás tétele   
            
            for (i = 0; i < adatokszama; i++)
            {
                for (k = 1; k <= kulonbozoelemekszama; k++)

                {
                    if (evek[k] == adatok[i].idopont.Year) rekorddb[k]++;
                }

            }
            Console.WriteLine("6. feladat:");
            for (i = 1; i <= kulonbozoelemekszama; i++)
                Console.WriteLine("\t{0}: {1} db ", evek[i], rekorddb[i]);

            Console.ReadKey();

        }
    }
}
