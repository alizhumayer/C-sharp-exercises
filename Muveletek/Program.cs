using System;

namespace feladat_muveletek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kérem adja meg az első számot: ");
            var StringSzam1 = Console.ReadLine();

            Console.Write("Kérem adja meg a második számot: ");
            var StringSzam2 = Console.ReadLine();

            var szam1 = Convert.ToDouble(StringSzam1);
            var szam2 = Convert.ToDouble(StringSzam2);

            Console.WriteLine("{0} + {1} = {2}", szam1, szam2, szam1 + szam2);
            Console.WriteLine("{0} - {1} = {2}", szam1, szam2, szam1 - szam2);
            Console.WriteLine("{0} * {1} = {2}", szam1, szam2, szam1 * szam2);
            Console.WriteLine("{0} / {1} = {2}", szam1, szam2, szam1 / szam2);

            Console.ReadKey();
        }
    }
}
