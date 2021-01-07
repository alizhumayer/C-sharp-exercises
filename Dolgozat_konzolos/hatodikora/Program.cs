using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hatodikora
{
    class Program
    {
        static void Main(string[] args)
        {
            ////pontozás
            //char[] megoldas = new char[] { 'a', 'b', 'b', 'a', 'c', 'a', 'a', 'c', 'd', 'd' };

            //Console.WriteLine("A tömb elemei: ");               
            //int i = 0;
            //for ( i = 0; i < 10; i++)
            //{
            // Console.WriteLine("{0}, ",megoldas[i]);
            //}
            //Console.WriteLine();


            //char valasz = ' ';
            //int pontszam = 0;
            ////for (i = 0; i < 10; i++)
            ////{
            //// Console.WriteLine("Kérem a {0} választ: ",i+1);
            //// valasz = Convert.ToChar(Console.ReadLine());

            ////    if(valasz!='a' && valasz!='b' && valasz!='c' && valasz!='d') //helytelen adatok
            ////    {
            ////        do
            ////        {
            ////            Console.WriteLine("Érvénytelen válasz");
            ////            valasz = Convert.ToChar(Console.ReadLine());
            ////        } while (valasz != 'a' && valasz != 'b' && valasz != 'c' && valasz != 'd');
            ////    }


            ////    if(valasz == megoldas[i])
            ////    {
            ////        pontszam = pontszam + 1; //pontszam++;pontszam+=1

            ////    }

            ////}
            ////Console.WriteLine("Pontszám: {0}",pontszam);

            ////több tanuló tolti ki args tesztet, kérjük be args tanulók számát

            //int tanuloszam = 0;
            //Console.WriteLine("A nebulók száma");

            //tanuloszam = Convert.ToInt32(Console.ReadLine());
            //int[] pontszamok = new int[tanuloszam];
            //int j = 0;
            //for (j = 0; j < tanuloszam; j++)
            //{

            //    for (i = 0; i < 10; i++)
            //    {
            //         Console.WriteLine("Kérem a {1}. tanuló {0} választ: ",i+1,j+1);
            //         valasz = Convert.ToChar(Console.ReadLine());

            //    if(valasz!='a' && valasz!='b' && valasz!='c' && valasz!='d') //helytelen adatok
            //    {
            //        do
            //        {
            //            Console.WriteLine("Érvénytelen válasz");
            //            valasz = Convert.ToChar(Console.ReadLine());
            //        } while (valasz != 'a' && valasz != 'b' && valasz != 'c' && valasz != 'd');
            //    }


            //    if(valasz == megoldas[i])
            //    {
            //        pontszam = pontszam + 1; //pontszam++;pontszam+=1

            //    }

            //    }
            //    pontszamok[j] = pontszam;
            //    pontszam = 0;
            //}
            //for (j = 0; j < tanuloszam; j++)
            //{
            //    Console.WriteLine("Pontszám: {0}, ", pontszamok[j]);
            //}
            

            //Console.ReadKey();

            /*be: másodfokú egyenlet együtthatói, 
             * gyökök 2 tizedesig, 
             * HA a D negatív,nincs mego,
             * HA 'a' = 0,kérjük be újra. 
             * ha 3 nél töbször hibázik, lépjünk ki  */



            /*
            int a = 0;
            int b = 0;
            int c = 0;
            double d = 0;
            double x1 = 0;
            double x2 = 0;
            int e = 0;

            


            do 
            {
                if (e == 4)
                {
                    goto vege;
                }
                    Console.WriteLine("Adja meg az 'a'-t: ");
            a = Convert.ToInt32(Console.ReadLine());
                if(a==0)
                {
                    Console.WriteLine("Az a nem lehet 0");
                }
                e++;
            }while (a==0);
                
                 
            

            Console.WriteLine("Adja meg a 'b'-t: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Adja meg a 'c'-t: ");
            c = Convert.ToInt32(Console.ReadLine());
                d = Math.Pow(b, 2) - 4 * a * c;
            if (d < 0)
            {
                Console.WriteLine("A műveletnek nincs eredménye");
            }
            else
                if (d == 0)
                {
                    x1 = (-b + Math.Sqrt(d)) / (2 * a);
                    Console.WriteLine("Az X1 értéke: {0} ", x1);
                }
                else if (d > 0)
                {
                    x1 = (-b + Math.Sqrt(d)) / (2 * a);
                    x2 = (b + Math.Sqrt(d)) / (2 * a);
                    Console.WriteLine("Az X1 értéke: {0} , Az X2 értéke: {1}", x1, x2);
                }

            


            vege:
            Console.ReadKey();


            */

            /*irassuk ki while ciklussal 0-100ig a 3mal osztható számokat */

            int i = 0;
            while (i<=100)
            {
                if(i % 3 == 0)
                {
                    Console.WriteLine("{0},", i);

                }
                i++;
                
            }















            /*be  1<= szam <=100, kiiratás betűvel  
             * n-től m-ig, 7tel osztható számok (n nem mindig kisebb mint n,)
             * 5ös lottó számok sorsolása amig afelhasználó akarja
             * 
             * 
             *
             */
            











        }
    }

    //
}
