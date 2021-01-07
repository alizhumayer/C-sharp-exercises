using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csincsilla
{
    class Program
    {
        struct csincsillak
        {
            /*1. Készíts programot Csincsilla néven. Olvasd be a chi.txt állomány sorait egy olyan
adatszerkezetbe, aminek segítségével a következő kérdéseket meg tudod válaszolni!
2. Írd ki a képernyőre a minta szerint, hogy hány csincsilla adatai szerepelnek az állományban!
3. Írd ki a képernyőre a minta szerint, hogy az állományban szereplő csincsillák hány százaléka
szereti, ha simogatják!
4. Van-e olyan csincsilla, aki 8 éves vagy idősebb, de a súlya kevesebb, mint 360 gramm? Ha van,
írd ki a képernyőre az első ilyen kisállat nevét! Ha nincs, a „Nincs ilyen csincsilla.”
szöveg jelenjen meg! (tekintsünk egy évet 365 naposnak)
5. Rendezd az adatszerkezet elemeit a csincsillák súlya szerint csökkenő sorrendbe, majd Írd ki a
képernyőre a mintának megfelelően az 5 legnagyobb súlyú csincsilla nevét!
6. Hozd létre az evek.txt állományt, az állomány soraiba a minta szerint írd be, hogy melyik
évben hány csincsilla született!*/
            public string nev;
            public DateTime szul;
            public int suly;
            public bool simi;            
        }
        static csincsillak[] csincs = new csincsillak[100];
        static void Main(string[] args)
        {
            string[] fajlbol = File.ReadAllLines("chi.txt");

            int sorokszama = 0;//sorok száma a fájlban
            int i;//ciklusváltozó

            for (int k = 0; k < fajlbol.Count(); k++)
            {

                string[] egysordarabolva = fajlbol[k].Split(';');
                csincs[sorokszama].nev = egysordarabolva[0];                
                csincs[sorokszama].szul = Convert.ToDateTime(egysordarabolva[1]);
                csincs[sorokszama].suly = Convert.ToInt32(egysordarabolva[2]);
                csincs[sorokszama].simi = egysordarabolva[3]=="I";                
                sorokszama++;
            }

            Console.WriteLine("A csincsillák listája fájlból");
            int csincsillakszama = sorokszama;            
            Console.WriteLine("sorszám  név          születés       suly szereti ha simogatják");            
            for (i = 0; i < csincsillakszama; i++)
            {                
                Console.WriteLine("{0}. {1,-12} {2,-8} {3,-5} {4}",i+1, csincs[i].nev, csincs[i].szul, csincs[i].suly, csincs[i].simi);               
            }
            /*2. Írd ki a képernyőre a minta szerint, hogy hány csincsilla adatai szerepelnek az állományban!*/
            Console.WriteLine("\n2. feladat:");
            Console.WriteLine("Összesen {0} db csincsilla van",csincsillakszama);
            /*3. Írd ki a képernyőre a minta szerint, 
             * hogy az állományban szereplő csincsillák hány százaléka 
             * szereti, ha simogatják!*/
            double simidb = 0;
            for (i = 0; i < csincsillakszama; i++)
            {
                if (csincs[i].simi) simidb++;
            }
            Console.WriteLine("\n3. feladat:");
            Console.WriteLine("A csincsillák {0}%-a szereti ha simogatják",Math.Round(simidb/csincsillakszama*100,2));
            /*4. Van-e olyan csincsilla, aki 8 éves vagy idősebb, de a súlya kevesebb, mint 360 gramm? Ha van,
írd ki a képernyőre az első ilyen kisállat nevét! Ha nincs, a „Nincs ilyen csincsilla.”
szöveg jelenjen meg! (tekintsünk egy évet 365 naposnak)*/
            i = 0;
            while (i < csincsillakszama && !((DateTime.Now - csincs[i].szul).Days/365 >=8 && csincs[i].suly <= 360))
            {
                i++;
            }
            Console.WriteLine("\n4. feladat:");
            if(i<csincsillakszama)
                Console.WriteLine("{0} {1} éves és {2} gramm", csincs[i].nev, (DateTime.Now - csincs[i].szul).Days / 365, csincs[i].suly);
            else
                Console.WriteLine("Nincs ilyen csincsilla.");
            /*5. Rendezd az adatszerkezet elemeit a csincsillák súlya szerint csökkenő sorrendbe, majd Írd ki a
képernyőre a mintának megfelelően az 5 legnagyobb súlyú csincsilla nevét!*/
            //sorbarendezés min kiválasztással           
            int min,mini,j;            
            for (i = 0; i < csincsillakszama; i++)
            {
                mini = i;
                min = csincs[i].suly;
                for (j = i ; j < csincsillakszama; j++)
                {
                    if(csincs[j].suly> min)//< esetén növekvő lesz a sorrend
                    {
                        mini = j;
                        min = csincs[j].suly;                        
                    }
                }
                //csere
                var s = csincs[i];
                csincs[i] = csincs[mini];
                csincs[mini] = s;
                             
            }

            /*
            Console.WriteLine("sorszám  név          születés       suly szereti ha simogatják");
            for (i = 0; i < csincsillakszama; i++)
            {
                Console.WriteLine("{0}. {1,-12} {2,-8} {3,-5} {4}", i + 1, csincs[i].nev, csincs[i].szul, csincs[i].suly, csincs[i].simi);
            }
            */
            Console.WriteLine("\n5. feladat:");
            Console.WriteLine("5 legnagyobb súlyú csincsilla adatai");
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("{0}. {1,-12} {2} g", i + 1, csincs[i].nev,csincs[i].suly);
            }
            /*6. Hozd létre az evek.txt állományt, az állomány soraiba 
             * a minta szerint írd be, hogy melyik évben hány csincsilla született!*/
            Console.WriteLine("\nmelyik évben hány csincsilla született");
            int[] evekdb = new int[100];
            for (i = 0; i < csincsillakszama; i++)
            {
                evekdb[2018 - csincs[i].szul.Year]++;
            }
            for (i = 0; i < evekdb.Count(); i++)
               if(evekdb[i]!=0) Console.WriteLine("{0}: {1}",2018-i,evekdb[i]);
            //fájlbaírás
            FileStream fnev = new FileStream("evek.txt", FileMode.Create);
            StreamWriter fajlbairo = new StreamWriter(fnev);
            for (i = 0; i < evekdb.Count(); i++)
            {
                if (evekdb[i] != 0)
                { 
                    fajlbairo.Write("{0}: {1}", 2018 - i, evekdb[i]);               
                fajlbairo.WriteLine("\n");//sortörés
                }
            }
            fajlbairo.Close();
            fnev.Close();

            /*7. Rendezd az adatszerkezet elemeit a csincsillák életkora szerint csökkenő sorrendbe, majd Írd ki a
képernyőre a mintának megfelelően!*/
            //sorbarendezés min kiválasztással           
            DateTime minszul;
            for (i = 0; i < csincsillakszama; i++)
            {
                mini = i;
                minszul = csincs[i].szul;
                for (j = i; j < csincsillakszama; j++)
                {
                    if (csincs[j].szul < minszul)//> esetén növekvő lesz a sorrend
                    {
                        mini = j;
                        minszul = csincs[j].szul;
                    }
                }
                //csere
                var s = csincs[i];
                csincs[i] = csincs[mini];
                csincs[mini] = s;

            }
            Console.WriteLine("\nÉletkor szerinti sorrend");
            Console.WriteLine("sorszám  név          születés       suly szereti ha simogatják");
            for (i = 0; i < csincsillakszama; i++)
            {
                Console.WriteLine("{0}. {1,-12} {2,-8} {3,-5} {4}", i + 1, csincs[i].nev, csincs[i].szul, csincs[i].suly, csincs[i].simi);
            }
           
            Console.ReadKey();
        }
    }
}
