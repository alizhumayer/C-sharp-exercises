using System;

namespace Veletlenszam_generator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Véletlenszám-generátor");
            
            Console.WriteLine("Kérem az első számot:");
            int szam1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Kérem a második számot:");
            int szam2 = int.Parse(Console.ReadLine());

            Random veletlenszam = new Random();

            Console.WriteLine("A generált szám/ok: {0}, {1}", veletlenszam.Next(szam1,szam2), veletlenszam.Next(szam1, szam2));
        }
    }
}
