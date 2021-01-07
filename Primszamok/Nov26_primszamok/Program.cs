using System;

namespace Nov26_primszamok
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prímtényezős felbontás és a prímek kiíratása");
            int szam;
            int ertek = 0;
            int osztok;
            Console.WriteLine("Kérem a megvizsgálandó értéket: ");
            ertek = int.Parse(Console.ReadLine());
            szam = 1;
            do
            {
                szam = szam + 1;
                osztok = 0;
                for (int i = 2; i <= szam % 2; i++)
                {
                    if (szam % i == 0) osztok++;
                }
                if (osztok == 0)
                {
                    if (ertek % szam == 0)
                    {
                        Console.WriteLine(szam);
                        ertek = ertek / szam;
                        szam = szam - 1;
                    }
                }
            }
            while (szam <= ertek);
            Console.ReadLine();

            int szam2=0;
            int osztok2;
            for (szam2 = 2; szam2 <= ertek; szam2++) //a bekért számig vizsgáljuk meg a számokat
            {
                osztok2 = 0;
                for (int i = 2; i <= szam2/2; i++)  //egy szám osztóit a szám feléig vizsgáljuk
                {
                    if (szam2 % i == 0) osztok2++;                    
                }
                if (osztok2 != 0) Console.WriteLine(ertek);                
            }
            //Console.WriteLine("a");
            Console.ReadLine();
        }
    }
}
