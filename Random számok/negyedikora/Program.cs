using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negyedikora
{
    class Program
    {
        static void Main(string[] args)
        {
            //számkitalálós: a gép véletlenszerűen talaljon ki egy szamot 1-100 között, a felh-tól kérjen be tippeket és mondja meg hogy a gondoltszám a tipptől kissebb v. nagyobb, a tipp addig megy amig a felh. el nem találta  a számot

            //int a = 0, b = 0;
            //Random sz = new Random();
            //a = sz.Next(1, 101);

            //    do
            //    {
            //        Console.WriteLine("Adja meg a tippjét");
            //        b = Convert.ToInt32(Console.ReadLine());
            //        if (a < b)
            //        {
            //            Console.WriteLine("A szám kisebb");
            //        }
            //        else if (a > b)
            //        {
            //            Console.WriteLine("A szám nagyobb");
            //        }
            //    } while (b != a);
            //Console.WriteLine("Siker");

            //Console.ReadKey();


            //-------------------------------------------------
            //bővítés: a tiipek számának kiírása
            //int a = 0, b = 0, c = 0;
            //Random sz = new Random();
            //a = sz.Next(1, 101);

            //do
            //{
            //    Console.WriteLine("Adja meg a tippjét");
            //    b = Convert.ToInt32(Console.ReadLine());
            //    c++;
            //    if (a < b)
            //    {
            //        Console.WriteLine("A szám kisebb");
            //    }
            //    else if (a > b)
            //    {
            //        Console.WriteLine("A szám nagyobb");
            //    }
            //} while (b != a);
            //Console.WriteLine("Siker");
            //Console.WriteLine("A {0}. tipp volt a nyerő",c);

            //Console.ReadKey();

            //66 kérjünk be egy molszámot és írjuk ki melyik szolgáltatóhoz tartozik / addig kérjen ber számokat, amíg nem 30.20.70 és nem 9 jegyú

            //string msz = "";


            //do
            //{
            //    Console.WriteLine("Kérem adjon meg egy telefonszámot: ");
            //    msz = Console.ReadLine();


            //}while(msz.Length != 9 ||
            //    msz[0].ToString() != "2" &&
            //    msz[0].ToString() != "3" &&
            //    msz[0].ToString() != "7" ||
            //    msz[1].ToString() != "0"); // amíg nem 9 karakter hosszú és nem 2,3,7

            //if (msz[0].ToString() == "2")
            //{
            //    Console.WriteLine("Pannon");
            //}
            //else if (msz[0].ToString() == "3")
            //{
            //    Console.WriteLine("T-mobil");
            //}
            //else if (msz[0].ToString() == "2")
            //{
            //    Console.WriteLine("Pannon");
            //}

            //Console.ReadKey();       


            //}

            //string msz = "";


            //do
            //{
            //    Console.WriteLine("Kérem adjon meg egy telefonszámot: ");
            //    msz = Console.ReadLine();


            //}while(msz.Length != 9 ||
            //    msz[0].ToString() != "2" &&
            //    msz[0].ToString() != "3" &&
            //    msz[0].ToString() != "7" ||
            //    msz[1].ToString() != "0"); // amíg nem 9 karakter hosszú és nem 2,3,7

            //switch (msz[0].ToString())
            //{
            //    case "2":
            //    Console.WriteLine("Pannonia");
            //        break;
            //    case "3":
            //    Console.WriteLine("T-fos");
            //        break;
            //    case "7":
            //        Console.WriteLine("Vodkafone");
            //        break;

            //}

            //Console.ReadKey();       


            //1. szám 1-20 és mellé a négyzetüket



            //double a = 1;
            //double b = 0;

            //for (a = 0; a <= 20; a++)
            //{
            //    b = Math.Pow(a, 2);

            //    Console.WriteLine("Szám: {0}, a négyzete {1}", a, b);
            //}

            //2.  99től az összes 3al oszthatót



            //int a = 1;

            //for (a = 99; a >= 3; a-- ) // a-=3
            //{
            //    if (a % 3 == 0)
            //    {
            //        Console.WriteLine("{0}",a);
            //    }

            //}

        //3. addíg kér be számokat amíg -30 és 40 közé esik az egyik szám

            

            //int a = 0;
         
            //do
            //{
            //    Console.WriteLine("Kérem a számot");
            //    a = Convert.ToInt32(Console.ReadLine());

            //} while (a < -30 || a > 40);
            //Console.WriteLine("Siker");


           

             //int i = 1;
             //for (i = -50; i <= 20; i += 2)
             //{
             //    if (i % 2 == 0)
             //    {
             //        Console.Write("{0}, ",i); //egy sorban
             //    }
             //}
             //  Console.ReadKey();

            //4.1 tömbökkel, a pozitív páros számokat
            //tömb feltöltés
            //int[] szamok = new int[20];
            //Random vsz = new Random();
            //int i = 0;
            //for (i = 0; i < 20; i++)
            //{
            //    szamok[i] = vsz.Next(-50, 21);
            //    Console.WriteLine("{0}, ",szamok[i]);
            //}
            //Console.WriteLine();
            //Console.WriteLine();
            //// pozitív páros szám vizasgálata
            //for (i = 0; i < 20; i++)
            //{
            //    if(szamok[i] > 0 && szamok[i] % 2 == 0 && szamok[i] != 0)
            //    {
            //        Console.WriteLine("{0}, ", szamok[i]);
            //    }
            //}
            
            /*HF
            1. Be: 1 szöveg, ki: 
             * minden 2. karaktert
             * minden 5. karaktert
             * hátulról az utolsó 5 karater
             * a beírt szöveget fordítva
             * a szavak betűit fordított sorrendben
             * határozza meg hogy van-e 't'
             * hat. meg van-e 'fa' szóösszetétel
             * adja meg hány magánh. van a szövegben
           
            */





































                Console.ReadKey();

        }
    }
}
















































































































       
