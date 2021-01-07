using System;

namespace Oszthatosag
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Oszthatósági szabályok");

            Console.WriteLine("Kérek egy számot: ");
            string n = Console.ReadLine();
            
            int hossz = n.Length;   //számjegyek száma
            int osszeg = 0;
            for (int i = 0; i < hossz; i++)
            {
                osszeg = osszeg + Convert.ToInt16(n[i])-48;
            }
            if (osszeg % 3 == 0) Console.WriteLine("A szám, amit megadtál, osztható 3-mal.");
            else Console.WriteLine("A szám nem osztható 3-mal.");

            if (osszeg % 9 == 0) Console.WriteLine("A szám, amit megadtál, osztható 9-cel.");
            else Console.WriteLine("A szám nem osztható 9-cel.");

            //ide jöhet még egy feltétel, hogy 4-nél nagyobb legyen a szám
            if (hossz>1)
            {
                if ((Convert.ToInt16(n[hossz-2]-48)*10 + Convert.ToInt16(n[hossz - 1]) - 48) % 4 == 0)
                {
                    Console.WriteLine("A szám osztható 4-el.");
                }
                else Console.WriteLine("A szám nem osztható 4-el.");
            }
        }
    }
}
