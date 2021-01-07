using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace torna2008
{
    class Program
    {
        //adatszerkezet létrehozása
        struct adatsor
        {
            public int rajtszam;
            public string versenyzo;
            public string orszagkod;
            public string foldresz;
            public double talaj;
            public double lolenges;
            public double gyuru;
            public double nyujto;
            public double korlat;
            public double ugras;
        }

        static adatsor[] adatok = new adatsor[100];//maximum 100 adatot tartalmazhat az adatok
       
        static void Main(string[] args)
        {
            string[] fajlbol = File.ReadAllLines("torna.csv");//adatok beolvasása fájlból
            /*A torna.csv UTF-8 kódolású állományban soronként egy versenyző eredményeit tároljuk. 
             * Az adatokat pontosvessző választja el egymástól. Például: 
             * 178;YANG Wei;CHN;Ázsia;15,400;15,425;16,225;16,550;15,350;14,925
             *  */
            int tindex = 0;//sorok száma a fájlban
            //adatok tárolása a struktúrában
            for (int i = 1; i < fajlbol.Count(); i++)//a ciklus 1-től indul, mertaz első sor a mezőneveket tartalmazza
            {
                string[] egysordarabolva = fajlbol[i].Split(';');
                adatok[tindex].rajtszam =Convert.ToInt32(egysordarabolva[0]);
                adatok[tindex].versenyzo = egysordarabolva[1];
                adatok[tindex].orszagkod = egysordarabolva[2];
                adatok[tindex].foldresz = egysordarabolva[3];
                adatok[tindex].talaj = Convert.ToDouble(egysordarabolva[4]);
                adatok[tindex].lolenges = Convert.ToDouble(egysordarabolva[5]);
                adatok[tindex].gyuru = Convert.ToDouble(egysordarabolva[6]);
                adatok[tindex].nyujto = Convert.ToDouble(egysordarabolva[7]);
                adatok[tindex].korlat = Convert.ToDouble(egysordarabolva[8]);
                adatok[tindex].ugras = Convert.ToDouble(egysordarabolva[9]);
                tindex++;

            }
            //2. feladat
            //Határozza meg és írja ki a képernyőre, 
            //hogy hány versenyző indult el összesen a versenyen!
            Console.WriteLine("2. feladat:\nÖsszesen {0} versenyző indult a versenyen",tindex);

            //3. feladat
            //Határozza meg és írja ki a képernyőre, hogy korláton melyik versenyző nyerte az aranyérmet! 
            //Feltételezheti, hogy nem alakult ki holtverseny!
            double korlatmax = adatok[0].korlat;//feltételezem, hogy az első adat a legnagyobb
            int korlatmaxindex = 0;//a legnagyobb adat sorszáma
            for (int i = 0; i < tindex; i++)
            {
                if (adatok[i].korlat > korlatmax)//ha az aktuális adat nagyobb mint a korlatmax
                {
                    korlatmax = adatok[i].korlat;
                    korlatmaxindex = i;
                }
            }
            Console.WriteLine("3. feladat:\nKorláton {0} szerezte meg az aranyérmet", adatok[korlatmaxindex].versenyzo);
            //4. feladat
            //Kérje be egy versenyző rajtszámát, majd írja ki a képernyőre az adott versenyző gyűrűn elért eredményét.
            //Ha olyan rajtszámot adott meg a felhasználó amilyen számmal nem indult versenyző, akkor írja ki, hogy „Nincs ilyen versenyző!”.
            Console.Write("Kérem a versenyző rajtszámát: ");
            int rajtsz =Convert.ToInt32(Console.ReadLine());
            //keresés tétele
            int k = 0;
            bool van = false;
            while((k<tindex) && adatok[k].rajtszam != rajtsz)
            {
                k++;
            }
            if (k < tindex) van = true;
            if (van) Console.WriteLine("4. feladat:\nA {0} rajtszámú versenyző gyűrűn elért eredménye: {1} pont",rajtsz,adatok[k].gyuru);
            else Console.WriteLine("Nincs ilyen versenyző!");
            //5. feladat
            //Határozza meg és írja ki a képernyőre a minta szerint azoknak a versenyzőknek a neveit, 
            //akik nem értek el legalább 14.5 pontot lólengésben és így nem jutott be a szer döntőjébe!
            //Feltételezheti, hogy legalább egy ilyen versenyző volt!
            Console.WriteLine("5. feladat:\nLólengésben nem jutottak döntőbe: \n");
            for (int i = 0; i < tindex; i++)
            {
                if (adatok[i].lolenges <14.5)
                {
                    Console.WriteLine("\t{0}", adatok[i].versenyzo);
                }
            }
            //6. feladat
            //Határozza meg és írja a képernyőre 
            //abc sorrendben rendezve a minta szerin azokat a földrészeket, amelyekből indult versenyző!
            Console.WriteLine("6. feladat:\nFöldrészek amelyekről versenyzők indultak: ");
            //adott egy sorozat, határozzuk meg hány különböző eleme van és gyűjtsük ki egy tömbbe
            int kulonbozoelemekszama = 0,j;
            string[] foldreszek = new string[100]; 
            for (int i = 0; i < tindex; i++)
            {
                j = 0;
                while((j<=kulonbozoelemekszama)&& (adatok[i].foldresz != foldreszek[j])){
                    j++;
                }
                if (j > kulonbozoelemekszama)
                {
                    kulonbozoelemekszama++;
                    foldreszek[kulonbozoelemekszama] = adatok[i].foldresz;
                }

            }
            for (int i = 0; i < kulonbozoelemekszama; i++)
                Console.Write("{0} ",foldreszek[i]);

            //7.	Határozza meg és írja ki a képernyőre, hogy az egyes országokból hány versenyző indult!
            Console.WriteLine("\n7. feladat:\n");
            int orszagokszama = 0;
            string[] orszagok = new string[100];
            int[] orszagszam = new int[100];
            for (int i = 0; i < 100; i++) orszagszam[i] = 0;//tömb elemeinek nullázása
            //először az országokat kigyűjtöm egy tömbbe
            //kiválogatás tétele
            for (int i = 0; i < tindex; i++)
            {
                j = 1;
                while ((j <= orszagokszama) && (adatok[i].orszagkod != orszagok[j]))
                {
                    j++;
                }
                if (j > orszagokszama)
                {
                    orszagokszama++;
                    orszagok[orszagokszama] = adatok[i].orszagkod;
                }

            }
            
            //megszámlálás tétele
            for (int i = 0; i < tindex; i++)
            {
                for ( k = 1; k<= orszagokszama; k++)
                   
                {
                    if(orszagok[k] == adatok[i].orszagkod) orszagszam[k]++;
                }
                
            }
            for (int i = 1; i <= orszagokszama; i++)
                Console.WriteLine("{0}: {1} fő ", orszagok[i],orszagszam[i]);

            //8. feladat
            //Hozzon létre „francia.txt” néven szövegfájlt, amelybe gyűjtse ki az összes francia (országkódja: „FRA”) 
            //versenyző rajtszámát, nevét és a versenyen elért összpontszámát!
            //Minden versenyző külön sorban szerepeljen, az adatok pontosvesszővel legyenek elválasztva!
            FileStream fnev = new FileStream("francia.txt", FileMode.Create);
            StreamWriter fajlbairo = new StreamWriter(fnev);
            fajlbairo.WriteLine("rajtszám;név;összpontszám");
            for (int i = 0; i < tindex; i++)
            {
                if (adatok[i].orszagkod == "FRA")
                {
                    fajlbairo.Write("{0};", adatok[i].rajtszam);
                    fajlbairo.Write("{0};", adatok[i].versenyzo);
                    fajlbairo.Write("{0};", adatok[i].talaj + adatok[i].lolenges + adatok[i].gyuru + adatok[i].nyujto + adatok[i].korlat + adatok[i].ugras);
                    fajlbairo.WriteLine("\n");//sortörés
                }
            }    
            fajlbairo.Close();
            fnev.Close();
            Console.ReadKey();
        }
    }
}
