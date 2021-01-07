using System;

namespace feladat_beolvasfelteteles
{
    class Program
    {
        static bool OttelOszthatoParatlan(int szam)
        {
            return (szam % 5 == 0) && (szam % 2 == 1);
        }

        static void Main(string[] args)
        {
            int szam = 0;
            do
            {
                Console.Write("Írjon be egy öttel osztható páratlan számot: ");
                var be = Console.ReadLine();
                var siker = int.TryParse(be, out szam);
                if (!siker) continue;
            }
            while (!OttelOszthatoParatlan(szam));
            Console.WriteLine("A megadott bemenet: {0}", szam);
            Console.ReadKey();
        }
    }
}