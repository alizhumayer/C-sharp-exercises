using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vb2018//1.	Készítsen programot a következő feladatok megoldására, amelynek a forráskódját/projektjét vb2018 néven mentse el!
{
    class Program
    {
        //vb2018.txt tartalma
        //varos;nev1;nev2;ferohely
        // Moszkva;Luzsnyiki Stadion; n.a.;78011
        //2.	Olvassa be a vb2018.txt állományban lévő adatokat és tárolja el egy összetett adatszerkezetben úgy,
        //hogy a további feladatok megoldására alkalmas legyen! Az állományban maximum 50 adatsor lehet.
        struct stadionok
        {
            public string varos;
            public string nev1;
            public string nev2;
            public double ferohely;
        }
        static stadionok[] stadion = new stadionok[50];
        static void Main(string[] args)
        {
            string[] fajlbol = File.ReadAllLines("vb2018.txt");
            int sorokszama = 0;//sorok száma a fájlban
            int i;//ciklusváltozó
            for (int k = 1; k < fajlbol.Count(); k++)//az első sor a mezőneveket tartalmazza, mem kell beolvasni
            {
                string[] egysordarabolva = fajlbol[k].Split(';');
                stadion[sorokszama].varos = egysordarabolva[0];
                stadion[sorokszama].nev1 = egysordarabolva[1];
                stadion[sorokszama].nev2 = egysordarabolva[2];
                stadion[sorokszama].ferohely = Convert.ToDouble(egysordarabolva[3]);
               
                sorokszama++;
            }

            Console.WriteLine("A stadionok listája fájlból");
            int stadionokszama = sorokszama;
            Console.WriteLine("varos                      nev1                       nev2                   ferohely");
            for (i = 0; i < stadionokszama; i++)            
                Console.WriteLine("{0,-2} {1,-20} {2,-30} {3,-25} {4,-25}", i + 1, stadion[i].varos, stadion[i].nev1, stadion[i].nev2, stadion[i].ferohely);
            //3.	Jelenítse meg a képernyőn, hogy hány stadionban játszották a VB mérkőzéseit!
            Console.WriteLine("3. feladat: Stadionok száma: {0}",stadionokszama);

            //4.	Határozza meg, és írja a képernyőre a legkevesebb férőhellyel rendelkező stadion adatait!
            double min = stadion[0].ferohely;
            int mini = 0;
            for (i = 1; i < stadionokszama; i++)
                if (stadion[i].ferohely < min)
                {
                    min = stadion[i].ferohely;
                    mini = i;
                }
                    
            Console.WriteLine("4. feladat: A legkevesebb férőhely:");
            Console.WriteLine("\tVáros: {0}", stadion[mini].varos);
            Console.WriteLine("\tStadion neve: {0}", stadion[mini].nev1);
            Console.WriteLine("\tFérőhely: {0}", stadion[mini].ferohely);

            //5.	Határozza meg és írja ki a képernyőre a stadionok férőhelyszámának átlagát, 
            //az eredményt egy tizedesjegyre kerekítve jelenítse meg!
            double atlagosferohely = 0;
            for (i = 0; i < stadionokszama; i++)
                atlagosferohely += stadion[i].ferohely;
            atlagosferohely = atlagosferohely / stadionokszama;
            Console.WriteLine("5. feladat: Átlagos férőhelyszám: {0}",Math.Round(atlagosferohely,1));

            //6.	Számolja meg, hogy hány stadion rendelkezik alternatív névvel! Az eredményt írja a képernyőre!
            int alternativdb = 0;
            for (i = 0; i < stadionokszama; i++)
                if (String.Compare(stadion[i].nev2, "n.a.") != 0)
                    alternativdb++;

            Console.WriteLine("6. feladat: Két néven is ismert stadionok száma: {0}",alternativdb);

            // 7.Kérje be a felhasználótól egy város nevét!
            //   Az adatbevitelt mindaddig ismételje, amíg a bevitt név (szöveg)hossza nem éri el a három karaktert!
            string varosnev;
            do
            {
                Console.Write("7. feladat: Kérem a város nevét: ");
                varosnev = Console.ReadLine();
            }
            while (varosnev.Count() < 3);

            //8.	Döntse el, hogy az előző feladatban megadott városban zajlottak-e VB mérkőzések! 
            //Ha a választ meg tudja adni, akkor ne folytassa a keresést! Az eredményt a képernyőn jelenítse meg!
            //Oldja meg, hogy az összehasonlításnál ne számítsanak a kis- és nagybetűk! 
            //Ha az előző feladatot nem tudta megoldani, akkor dolgozzon a „Szocsi” névvel!
            Boolean van = true;
            i = 0;
            while(i<stadionokszama && !stadion[i].varos.ToLower().Contains(varosnev))
            {
                i++;
            }
            van = i < stadionokszama ? true : false;
            if(van)
                Console.WriteLine("8. feladat: A megadott város VB helyszin. A város neve: {0} ", stadion[i].varos);
            else
                Console.WriteLine("8. feladat: A megadott város nem VB helyszin ");
            //9.	Határozza meg és írja a képernyőre, hogy hány különböző városban zajlottak a VB mérkőzései!
            //különböző elemek kigyűjtése
            int m = 0, j = 0;
            string[] varosok = new string[50];
            for (i = 0; i < stadionokszama; i++)
            {
                j = 0;
                while ((j <= m) && (stadion[i].varos != varosok[j]))
                {
                    j++;
                }
                if (j > m)
                {                    
                    varosok[m] = stadion[i].varos;
                    m++;
                }
            }
            Console.Write("9. feladat: {0} különböző városban voltak mérkőzések.\n",m);
            for (i = 0; i <m; i++) Console.Write("{0},  ", varosok[i]);

            //10. Listázzuk ki az összes városnevet, amit a 7. feladatnál megadtunk
            Console.Write("\n10. feladat: ");
            i = 0;
            while (i < stadionokszama)
            {
                if(stadion[i].varos.ToLower().Contains(varosnev))
                    Console.Write("\n\tA város neve: {0} ", stadion[i].varos);
                i++;
            }
            

            Console.ReadKey();
        }
    }
}
