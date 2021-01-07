using System;

namespace Vegyes_nov12_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            //négyzetszámok
            Console.WriteLine("Négyzetszámok 1000-ig:");
            while (i*i < 1001)
            {
                Console.Write("{0}, ", i*i);
                i += 1;     // i = i+1;   i++;
            }

            Console.ReadLine();
            //köbszámok
            Console.WriteLine("Köbszámok 1000-ig:");
            i = 1;
            while (i * i *i < 1001)
            {
                Console.Write("{0}, ", i * i * i);
                i += 1;     
            }
            Console.ReadLine();

            //átváltás tízes számrsz-be
            Console.WriteLine("Átváltás. Kérem a bitsorozatot (csak 1 és 0):");
            string bitek = Console.ReadLine();      //1011
            double hatvany = 2;
            string szamjegy = "";
            double osszeg = 0;

            for (int j = 0; j < bitek.Length; j++)
            {
                hatvany = Math.Pow(2,bitek.Length-j-1);
                szamjegy = bitek.Substring(j,1);            //kivágjuk a j. karaktert
                osszeg += int.Parse(szamjegy) * hatvany;
            }

            Console.WriteLine("Eredmény: {0}",osszeg);
            Console.ReadLine();
           
        }
    }
}
