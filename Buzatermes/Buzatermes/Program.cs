using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Buzatermes
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int menny;
            int szorzo;
            int hozam;
            Console.WriteLine("Búzatermés idén");

            Console.WriteLine("Búza mennyisége tonnában: ");
            menny = int.Parse(Console.ReadLine());
            szorzo = rnd.Next(5,16);
            hozam = menny * szorzo;

            Console.WriteLine("Várható mennyiség: {0}", hozam);

            if (hozam >= 90) Console.WriteLine("Átlag feletti év várható");
            else if (hozam >= 55 && hozam < 90) Console.WriteLine("Átlagos év várható");
            else if (hozam > 0 && hozam < 55) Console.WriteLine("Átlag alatti év várható");
        }
    }
}
