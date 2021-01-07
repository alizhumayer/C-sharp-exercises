using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ursiklo
{
    class Program
    {
        //adatszerkezet létrehozása
        struct adatsor
        {
            public string kod;
            public DateTime kiloves;
            public string ursiklonev;
            public double nap;
            public double ora;
            public string landolas;
            public int legenyseg;          
        }
        static adatsor[] adatok = new adatsor[200];//maximum 200 adatot tartalmazhat az adatok
        static void Main(string[] args)
        {
            string[] fajlbol = File.ReadAllLines("kuldetesek.csv");//adatok beolvasása fájlból
            
            int tindex = 0;//sorok száma a fájlban
            //adatok tárolása a struktúrában
            for (int i = 0; i < fajlbol.Count(); i++)
            {
                string[] egysordarabolva = fajlbol[i].Split(';');
                adatok[tindex].kod = egysordarabolva[0];
                adatok[tindex].kiloves = Convert.ToDateTime(egysordarabolva[1]);
                adatok[tindex].ursiklonev = egysordarabolva[2];
                adatok[tindex].nap = Convert.ToDouble(egysordarabolva[3]);
                adatok[tindex].ora = Convert.ToDouble(egysordarabolva[4]);
                adatok[tindex].landolas = egysordarabolva[5];
                adatok[tindex].legenyseg = Convert.ToInt32(egysordarabolva[6]);               
                tindex++;
            }
            //3. Határozza meg és írja ki a képernyőre a minta szerint, hogy 
            //hányszor küldtek a világűrbe úrhajót az Space Shuttle program keretein belül!
            Console.WriteLine("3. feladat:\n\tÖsszesen {0} alkalommal indítottak űrhajót.", tindex);

            //4. Határozza meg és írja ki a képernyőre a minta szerint, hogy 
            //hány utast szállítottak összesen a Space Shuttle űrsiklói!
            //összegzés tétele
                        int utasokosszesen = 0;
            for (int i = 0; i < tindex; i++)
            {
                utasokosszesen += adatok[i].legenyseg;
            }

                Console.WriteLine("4. feladat:\n\t {0} utas indult az űrbe összesen.", utasokosszesen);

            //5. Határozza meg és írja ki a képernyőre a minta szerint, hogy 
            //hány alkalommal indítottak űrsiklót kevesebb, mint 5 fővel a világűrbe!
            //megszámlálás tétele
            int alkalmak = 0;
            for (int i = 0; i < tindex; i++)
            {
                if(adatok[i].legenyseg<5)
                alkalmak++;
            }

            Console.WriteLine("5. feladat:\n\t Összesen {0} alkalommal küldtek kevesebb, mint 5 embert az űrbe.", alkalmak);

            //6. 2003.február 1‐jén a Földre való visszatérés közben a Columbia űrsikló megsemmisült, nem voltak
            //túlélők.Határozza meg és írja ki a képernyőre a minta szerint, hogy
            //hány asztronauta kísérte el a Columbiát utolsó útjára!
            //kiválasztás tétele
            /*Eljárás kiválasztás
i:=1
Ciklus amíg A[i] nem T tulajdonságú { ha T tulajdonságú akkor vége}
	i:=i+1
Ciklus vége
Sorsz:=i {a T tulajdonságú elem sorszáma lesz a Sorsz nevű változóba}
Eljárás vége
*/
            int j = tindex;//visszafele keresünk
            while (adatok[j].ursiklonev != "Columbia")
            {
                j--;
            }
            Console.WriteLine("6. feladat:\n\t{0} asztronauta volt a Columbia fedélzetén annak utolsó útján.", adatok[j].legenyseg);

            //7. Határozza meg és írja ki a képernyőre a minta szerint annak az űrsiklónak a nevét, a küldetés kódját és
            //az űrben töltött időt órában, amikor a leghosszabb ideig volt távol a Földtől űrhajó, amit Space Shuttle
            //program indított!Feltételezheti, hogy nem volt két ilyen hosszúságú küldetés.
            //maximumkiválasztás tétele
            double max = adatok[0].nap * 24 + adatok[0].ora;
            int maxindex = 0;
            for (int i = 1; i < tindex; i++)
            {
                if ((adatok[i].nap * 24 + adatok[i].ora)>max)
                {
                    max = adatok[i].nap * 24 + adatok[i].ora;
                    maxindex = i;
                }
                    
            }

            Console.WriteLine("7. feladat:\n\t A leghosszabb ideig a {0} volt az űrben a {1} küldetés során.", adatok[maxindex].ursiklonev, adatok[maxindex].kod);
            Console.WriteLine("\t összesen {0} órát volt távol a földtől", max);

            //8. Kérjen be egy évszámot! Határozza meg és írja ki a képernyőre a minta szerint, hogy a megadott évben
            //hány alkalommal indítottak űrsiklót útnak.Ha a megadott évben nem indult küldetés, az 
            //„Ebben az évben nem indult küldetés” szöveg jelenjen meg.

            Console.Write("8. feladat:\n\tÉvszám: ");
            int evszam = Convert.ToInt32(Console.ReadLine());
            //keresés tétele
            int k = 0;
            alkalmak = 0;
            bool van = false;
            while ((k < tindex) && adatok[k].kiloves.Year != evszam)
            {
                k++;
            }
            if (k < tindex) van = true;
            if (van)
            {
                //megszámlálás tétele
                for (int i = 0; i < tindex; i++)
                {
                    if (adatok[i].kiloves.Year == evszam)
                    {
                        alkalmak++;
                    }

                }
                Console.WriteLine("\t Ebben az évben {0} küldetés volt.", alkalmak);
            }
            else Console.WriteLine("\t Ebben az évben nem indult küldetés");

            //9. Határozza meg és írja ki a képernyőre a minta szerint, hogy 
            //a landolások hány %‐a történt az Kennedy űrközponton.
            //megszámlálás tétele
            double landolasokszama = 0;
            for (int i = 0; i < tindex; i++)
            {
                if (adatok[i].landolas == "Kennedy")
                {
                    landolasokszama++;
                }

            }
            Console.WriteLine("9. feladat:\n\t A küldetések {0}%-a fejeződött be a Kennedy űrközpontban.",Math.Round(landolasokszama / tindex*100,2));

            //10. írja ki az ursiklok.txt állományba a minta szerint, hogy 
            //melyik űrsikló összesen hány napot töltött az űrben!(Minden sikló neve csak egyszer szerepeljen!)
            //kiválogatás tétele
            int kulonbozoelemekszama = 0;
            string[] ursiklonevek = new string[100];
            for (int i = 0; i < tindex; i++)
            {
                j = 0;
                while ((j <= kulonbozoelemekszama) && (adatok[i].ursiklonev != ursiklonevek[j]))
                {
                    j++;
                }
                if (j > kulonbozoelemekszama)
                {
                    kulonbozoelemekszama++;
                    ursiklonevek[kulonbozoelemekszama] = adatok[i].ursiklonev;
                }

            }
            //fájlbaírás
            FileStream fnev = new FileStream("ursiklok.txt", FileMode.Create);
            StreamWriter fajlbairo = new StreamWriter(fnev);
           
            double[] osszesnapokszama = new double[100];
            for (j = 0; j < 100; j++) osszesnapokszama[j] = 0;
                for (int i = 1; i <= kulonbozoelemekszama; i++)
            {
               
                for ( j = 0; j < tindex; j++)
                {
                    if (adatok[j].ursiklonev == ursiklonevek[i])
                    {
                        osszesnapokszama[i] += (adatok[j].nap + (adatok[j].ora / 24));
                    }
                }               
            }
            for (j = 1; j <= kulonbozoelemekszama; j++)
            {
                {
                    fajlbairo.Write("{0};", ursiklonevek[j]);
                    fajlbairo.Write("\t{0};", Math.Round(osszesnapokszama[j],2));
                    fajlbairo.WriteLine("\n");//sortörés
                }
            }
            fajlbairo.Close();
            fnev.Close();
          
               
            Console.ReadKey();
        }
    }
}
