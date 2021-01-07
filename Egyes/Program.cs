using System;

namespace feladat_egyes
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Kérem adjon meg egy számot: ");
                var szam = Convert.ToByte(Console.ReadLine());

                int egyesek = 0;
                for (int i = 7; i >= 0; i--)
                {
                    int maszk = (1 << i);
                    int bit = (szam & maszk) >> i;
                    egyesek += bit;
                }
                Console.WriteLine("A {0} szam binaris alakja: {1}", szam, Convert.ToString(szam, 2));
                Console.WriteLine("1 értékű bitek száma: {0}", egyesek);

            }
            catch (Exception ex)
            {
                if (ex is FormatException)
                    Console.WriteLine("Nem jó a bementi szám formátuma");
                else if (ex is OverflowException)
                    Console.WriteLine("A szám nem fér el egy byte-ban");
                else
                    Console.WriteLine("Egyéb hiba történt: {0}", ex.Message);
            }
            Console.ReadKey();
        }
    }
}
