using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harmadikhazi
{
    class Program
    {
        static void Main(string[] args)
        {

            //1. számokat kér be addig, amig az utolsó 2 szám meg nem egyezik


            int[] tomb1 = new int[100];
            int i = 0;
          
            Console.WriteLine("Kérem adjon megy egy számot: ");
            i = Convert.ToInt32(Console.ReadLine());
           
            







            //do
            //{
                
            //    i++;
            //    tomb1[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //while (tomb1[i] == tomb1[i - 1]);



            Console.ReadKey();
            //2. számokat kér be addig, amíg 0-t adunk meg
            
            //int x = -1;

            //do
            //{
            //    Console.WriteLine("Kérem adjon megy egy számot: ");
            //    x = Convert.ToInt32(Console.ReadLine());
            //} while (x != 0);


            //Console.ReadKey();
            //2.1 számokat kér be addig, amíg 0-t adunk meg, majd sorban kiírja őket

            //int[] tomb1 = new int[100];
            //int i = -1;
            //Console.WriteLine("Adj meg egészeket 0 végjelig");
            //do
            //{
            //    i++;
            //    tomb1[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //while (tomb1[i] != 0);
            //int n = i;
            //Console.WriteLine("A beolvasott elemek:");
            //for (i = 0; i < n; i++)
            //    Console.WriteLine(tomb1[i]);
            //Console.ReadKey();
        



        //3.  adott egy pont a koordinátáival, határozzuk meg melyik síknegyedben van

        //int x = 0, y = 0;
        //Console.WriteLine("Kérem a X koordinátát:");
        //x = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Kérem a Y koordinátát:");
        //y = Convert.ToInt32(Console.ReadLine());

        //if (x > 0 && y > 0)
        //{
        //    Console.WriteLine("A [{0},{1}] koordináta az I. síknegyedben van",x,y);
        //}
        //if (x < 0 && y > 0)
        //{
        //    Console.WriteLine("A [{0},{1}] koordináta az II. síknegyedben van", x, y);
        //}
        //if (x < 0 && y < 0)
        //{
        //    Console.WriteLine("A [{0},{1}] koordináta az III. síknegyedben van", x, y);
        //}
        //if (x > 0 && y < 0)
        //{
        //    Console.WriteLine("A [{0},{1}] koordináta az IV. síknegyedben van", x, y);
        //}

        //Console.ReadKey();
        //4. közép éretségin max 150 pont szerezhető, kérje be a pontszámot és írja ki a jegyet (betűvel és számmal) ha 1:0-19% elégtelen,2:20-39 elégséges,3:40-59 közepes,4:60-79% jó,80-100 jeles


        //double a = 0, b = 150;
        //Console.WriteLine("Kérem a pontokat:");
        //a = Convert.ToDouble(Console.ReadLine());

        //if(a < 0 || a > 150  )
        //{
        //    Console.WriteLine("Érvénytelen pontszám!");
        //}
        //if(a >= 0 && a <= (b*0.19))
        //{
        //    Console.WriteLine("Az ön eredménye: Elégtelen 1");
        //}
        //if (a > (b * 0.19) && a <= (b * 0.39))
        //{
        //    Console.WriteLine("Az ön eredménye: Elégséges 2");
        //}
        //if (a > (b * 0.39) && a <= (b * 0.59))
        //{
        //    Console.WriteLine("Az ön eredménye: Közepes 3");
        //}
        //if (a > (b * 0.59) && a <= (b * 0.79))
        //{
        //    Console.WriteLine("Az ön eredménye: Jó 4");
        //}
        //if (a > (b * 0.79) && a <= b)
        //{
        //    Console.WriteLine("Az ön eredménye: Kiváló 5");
        //}

        //Console.ReadKey();













































    }
}
}
