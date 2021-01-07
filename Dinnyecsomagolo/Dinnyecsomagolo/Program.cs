using System;

namespace Dinnyecsomagolo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Milyen hosszú szalagra férnek el a dinnyék?");

            Console.WriteLine("A dinnyék maximális átmérője (cm): ");
            int d = int.Parse(Console.ReadLine());

            Console.WriteLine("A dinnyék száma: ");
            int db = int.Parse(Console.ReadLine());

            double szalaghossz = ((2 * d * Math.PI) + 50) * db;

            Console.WriteLine("A szükséges szalaghossz {0:00.00}: ", szalaghossz);
        }
    }
}
