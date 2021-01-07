using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harmadikora
{
    class Program
    {
        static void Main(string[] args)
        {

           // állítsunk elő véletlenszerű számokat a [0,10] tartományból, írjuk ki a számokat és hogy meilyk a nagyobb, egyenlőség esetén írja ki. h egyenlőek

            //int a = 0, b = 0;

            //Random vsz = new Random();

            //a = vsz.Next(0,11); // kezdő érték egay 0 akkor elhagyható (kezdő ért, végső+1)
            //b = vsz.Next(11);

            //Console.WriteLine("Első szám:{0}", a);
            //Console.WriteLine("Második szám:{0}", b);
            //if (a == b)

            //{
            //    Console.WriteLine("A két szám egyenlő", a);

            //}
            //else
            //    Console.WriteLine("A nagyobb szám: {0}", Math.Max(a,b));


            //---------------------

            // 1 véletlen szám [1,10] írjuk ki hogy páros vagy páratlan

           


            //int a = 0;
            //Random vsz = new Random();
            //a = vsz.Next(1, 11); 
           
            //if (a % 2 != 0)
            //{
            //    Console.WriteLine("A szám páratlan");
            //}
            //else
            //    Console.WriteLine("A szám páros");


            //Console.ReadKey();

            //----------------------------
            // 1-3 kiír + 1-5ig kiír

            //Console.WriteLine("1");
            //Console.WriteLine("2");
            //Console.WriteLine("3");

            //int i = 0;
            //for (i = 0; i <= 5; i++)   // i+=2 = kettesével lépked 
            //{
            //    Console.WriteLine(i);

            //}

            //----------------------------
            // elöl tesztel

            //int j = 1;
            //while (j<=5)
            //{
            //    Console.WriteLine(j);
            //    j++;

            //}
            //                Console.ReadKey();


            //----------------------------
            // hátul tesztel

            //int z = 1;

            //do
            //{
            //    Console.WriteLine(z); // a do magjában lévő ciklus mindíg lefut
            //    z++;

            //} 
            //while (z <= 5);

            //    Console.ReadKey();



           ////----------------------------
           //// Feladat: írassunk ki [1,10] páros számait
           //  // megoldás 1
           // int i = 1;
           // for (i = 2; i <= 10; i += 2)
           // {
           //     Console.WriteLine(i);
           // }
            // Console.ReadKey();
        //}

      // //----------------------------
           // // Feladat: írassunk ki [1,10] páros számait
           // // megoldás 2

           // int i = 1;
           // for (i = 2; i <= 10; i += 2)
           // {
           //     if (i % 2 == 0)
           //     {
           //         Console.Write("{0}, ",i); //egy sorban
           //     }
           // }
           //   Console.ReadKey();
        //}
     //----------------------------
           // // Feladat: írassunk ki [1,10] páros számait
           // // megoldás 3

           // int i = 1;
           // for (i = 2; i <= 10; i += 2)
           // {
                //if (i % 2 == 0)
           //     {
           //         Console.WriteLine("{0,4}",i); //egy sorban 4 karakternyi kihagyással (4 szóközzel)
           //     }
           // }
           //   Console.ReadKey();
        //----------------------------
        // 5db vsz from [0,50] és írjuk ki mindet 5 karakterny közzel

            
            //Random vsz = new Random();
            //int a = 0;
            //for (int i = 1; i <= 5; i++)
            //{
            //    a = vsz.Next(51);
            //    Console.Write("{0,5}", a);
            //}

            //----------------------------
            // 40 egész szám [-100,100] kiíratés, 6 karakter közzel, 1 sorba 8 számot, a végére írja ki hogy hány + van)

           
            //int szam = 0, db = 0; 
            //Random vsz = new Random();
            //for (int i = 1; i <= 40; i++)
            //{
            //    szam = vsz.Next(-100, 101);
            //    Console.Write("{0,6}", szam);
            //    if (i % 8 == 0)
            //    {
            //        Console.WriteLine();
            //        Console.WriteLine();
            //    }
            //    if (szam > 0)
            //    {
            //        db++;

            //    }

            //}
            //    Console.WriteLine("Pozitív számok: {0} db", db);
            //    Console.ReadKey();               
        
          // 10 vsz összege,szorzata, átlaga [0,1000]

            //long szam = 0, o = 0, sz = 1;
            //double at = 0;
            //Random vsz = new Random();
            //for (long i = 1; i <= 10; i++)
            //{
            //    szam = vsz.Next(100);
            //    Console.Write("{0,4}", szam);
            //    o = o + szam;
            //    sz = sz * szam;

            //}
            //at = Convert.ToDouble(o) / 10;
            //Console.WriteLine();
            // Console.Write("Az összeg: {0} ,A szorzat: {1}, Az átlag {2:0.00} ", o, sz, at);







           Console.ReadKey();

           


            // HÁZI
            //1. számokat kér be addig, amig az utolsó 2 szám meg nem egyezik
            //2. számokat kér be addig, amíg 0-t adunk meg
            //3.  adott egy pont a koordinátáival, határozzuk meg melyik síknegyedben van
            //4. közép éretségin max 150 pont szerezhető, kérje be a pontszámot és írja ki a jegyet (betűvel és számmal) ha 1:0-19% elégtelen,2:20-39 elégséges,3:40-59 közepes,4:60-79% jó,80-100 jeles
 
           

  
        }
    }
}
