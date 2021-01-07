using System;
using System.IO; // 10. feladat

namespace OkjKiralynok
{
    class Kiralynok // 0. feladat (Fájl neve Kiralynok.cs)
    {
        static void Main(string[] args)
        {
            // 10. feladat  (System.IO névtér importja)
            const string fájlNeve = "tablak64.txt";
            if (File.Exists(fájlNeve)) File.Delete(fájlNeve);  // 10.a

            Console.WriteLine("4. feladat: Az üres tábla:");
            Tábla tábla = new Tábla('#');
            tábla.Megjelenít();

            Console.WriteLine("\n6. feladat: A feltöltött tábla:");
            tábla.Elhelyez(8);
            tábla.Megjelenít();

            Console.WriteLine("\n9. feladat: Üres oszlopok és sorok száma:");
            Console.WriteLine($"Oszlopok: {tábla.ÜresOszlopokSzáma}");
            Console.WriteLine($"Sorok: {tábla.ÜresSorokSzáma}");

            // 10. feladat:
            Console.WriteLine($"10. feladat: {fájlNeve}");
            StreamWriter sw = new StreamWriter(fájlNeve);
            for (int i = 1; i < 65; i++)
            {
                Tábla aktTábla = new Tábla('*'); // 10.b
                aktTábla.Elhelyez(i); // 10.d
                aktTábla.FájlbaÍr(sw); // 10.c
            }
            sw.Close();

            Console.ReadKey();
        }
    }
}
