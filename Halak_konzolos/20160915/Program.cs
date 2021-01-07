using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20160915
{
    class Program
    {
        struct Adat
        {
            public int hossz;
            public int meret;
            public string szin;
            
        }
        const int M = 4;                   //nem változtatható adat
        static Adat[] halak = new Adat[M];
      
        static void Main(string[] args)
        {
            Feltolt();
            Kiir();
            



            Console.ReadKey();
        }
        static void Feltolt()
        {
            string s;
            string z;
            
            for (int i = 0; i < halak.Length; i++) //jobb mint az M
            {
                s = "Add meg a " + (i + 1).ToString() + ". hal hosszát";
                halak[i].hossz = Beolvas_szam(s);
            }
            for (int i = 0; i < halak.Length; i++) //jobb mint az M
            {
                z = "Add meg a " + (i + 1).ToString() + ". hal méretét";
                halak[i].meret = Beolvas_szam(z);
            }
            
        }

        static void Kiir()
        {
            for (int i = 0; i < halak.Length; i++)
            {
                Console.WriteLine("{0}. hal hossza: {1} ",i+1,halak[i].hossz );
            }
            for (int i = 0; i < halak.Length; i++)
            {
                Console.WriteLine("{0}. hal mérete: {1} ", i + 1, halak[i].meret);
            }
        }

        static int Beolvas_szam(string kerdes)
        {
            bool hiba;
            int szam = 0;
            do
            {
                hiba = false;
                Console.Write("{0} ", kerdes);
                try                                         //beírt karakter ellenörzése
                {
                    szam = int.Parse(Console.ReadLine());
                }
                catch 
                {

                    hiba = true;
                    Console.WriteLine("Próbáld újra");
                }
                if (szam<=0&& hiba == true)                 // ha a szám negatív, de szám
                {
                    hiba = true;
                    Console.WriteLine("Próbáld újra + számmal");
                }

            } while (hiba==true);
            return szam;


            /////////////////////////////////////////////////////

            /*
            szöveges állományok kezuelése,rekordok kezelése, 
            tipusos állományok kezelése (nem kötelező)

            A parancs = foglalt szó

            struct Halak-Strukt
            private-public-published (a published megjelenik a Properities)

            */






        }

    }
}
